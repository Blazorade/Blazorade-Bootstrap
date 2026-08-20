using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Displays a collection of collapsible accordion items.
    /// </summary>
    public partial class Accordion : BootstrapComponentBase
    {
        private readonly List<AccordionItem> items = new();

        /// <summary>
        /// The ID of the accordion element.
        /// </summary>
        [Parameter]
        public string? Id { get; set; }

        /// <summary>
        /// Specifies whether the accordion uses the flush style.
        /// </summary>
        [Parameter]
        public bool IsFlush { get; set; }

        /// <summary>
        /// Specifies whether multiple items can be open at the same time.
        /// </summary>
        [Parameter]
        public bool IsAlwaysOpen { get; set; }

        /// <summary>
        /// Invoked when an item starts opening.
        /// </summary>
        [Parameter]
        public EventCallback<AccordionItem> OnShow { get; set; }

        /// <summary>
        /// Invoked when an item has finished opening.
        /// </summary>
        [Parameter]
        public EventCallback<AccordionItem> OnShown { get; set; }

        /// <summary>
        /// Invoked when an item starts closing.
        /// </summary>
        [Parameter]
        public EventCallback<AccordionItem> OnHide { get; set; }

        /// <summary>
        /// Invoked when an item has finished closing.
        /// </summary>
        [Parameter]
        public EventCallback<AccordionItem> OnHidden { get; set; }

        /// <inheritdoc />
        protected override void OnParametersSet()
        {
            this.Id ??= $"accordion-{Guid.NewGuid():N}"[..18];
            this.AddClasses("accordion");

            if (this.IsFlush)
            {
                this.AddClasses("accordion-flush");
            }

            base.OnParametersSet();
        }

        internal void RegisterItem(AccordionItem item)
        {
            if (!this.items.Contains(item))
            {
                this.items.Add(item);
            }

            this.EnsureSingleOpenItem(item);
        }

        internal void UnregisterItem(AccordionItem item)
        {
            this.items.Remove(item);
        }

        internal async Task HideOtherItemsAsync(AccordionItem item)
        {
            if (this.IsAlwaysOpen)
            {
                return;
            }

            foreach (var otherItem in this.items.ToArray())
            {
                if (otherItem != item && otherItem.IsExpanded)
                {
                    await otherItem.HideAsync();
                }
            }
        }

        internal void OnItemParametersChanged(AccordionItem item)
        {
            this.EnsureSingleOpenItem(item);
        }

        internal Task RaiseShowAsync(AccordionItem item)
        {
            return this.OnShow.InvokeAsync(item);
        }

        internal Task RaiseShownAsync(AccordionItem item)
        {
            return this.OnShown.InvokeAsync(item);
        }

        internal Task RaiseHideAsync(AccordionItem item)
        {
            return this.OnHide.InvokeAsync(item);
        }

        internal Task RaiseHiddenAsync(AccordionItem item)
        {
            return this.OnHidden.InvokeAsync(item);
        }

        private void EnsureSingleOpenItem(AccordionItem item)
        {
            if (this.IsAlwaysOpen || !item.IsExpanded)
            {
                return;
            }

            foreach (var otherItem in this.items)
            {
                if (otherItem != item)
                {
                    otherItem.SetExpanded(false);
                }
            }
        }
    }
}
