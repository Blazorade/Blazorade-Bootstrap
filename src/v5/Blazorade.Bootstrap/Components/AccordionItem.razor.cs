using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Represents one item in an <see cref="Accordion"/>.
    /// </summary>
    public partial class AccordionItem : BootstrapComponentBase, IDisposable
    {
        private Accordion? parent;
        private bool hasReceivedIsOpen;
        private bool lastIsOpen;
        private bool isExpanded;
        private DotNetObjectReference<AccordionItem>? dotNetReference;

        [CascadingParameter]
        private Accordion? ParentAccordion { get; set; }

        /// <summary>
        /// The ID of the accordion item.
        /// </summary>
        [Parameter]
        public string? Id { get; set; }

        /// <summary>
        /// Specifies whether the item is initially open.
        /// </summary>
        [Parameter]
        public bool IsOpen { get; set; }

        /// <summary>
        /// The template for the accordion header.
        /// </summary>
        /// <remarks>
        /// When supplied, this template is rendered as the accordion header. Direct child content is used only
        /// when neither <see cref="Header"/> nor <see cref="Body"/> is supplied.
        /// </remarks>
        [Parameter]
        public RenderFragment? Header { get; set; }

        /// <summary>
        /// The template for the accordion body.
        /// </summary>
        /// <remarks>
        /// When supplied, this template is rendered as the collapsible accordion body. Direct child content is used
        /// only when neither <see cref="Header"/> nor <see cref="Body"/> is supplied.
        /// </remarks>
        [Parameter]
        public RenderFragment? Body { get; set; }

        internal Accordion? Parent => this.parent;

        internal bool IsExpanded => this.isExpanded;

        internal string HeaderId => $"{this.Id}-header";

        internal string BodyId => $"{this.Id}-body";

        internal string? ParentSelector => this.parent is not null && !this.parent.IsAlwaysOpen
            ? $"#{this.parent.Id}"
            : null;

        /// <inheritdoc />
        protected override void OnParametersSet()
        {
            this.Id ??= $"accordion-item-{Guid.NewGuid():N}"[..24];
            this.AddClasses("accordion-item");
            this.parent = this.ParentAccordion;

            if (!this.hasReceivedIsOpen)
            {
                this.isExpanded = this.IsOpen;
                this.hasReceivedIsOpen = true;
            }
            else if (this.IsOpen != this.lastIsOpen)
            {
                this.isExpanded = this.IsOpen;
                this.parent?.OnItemParametersChanged(this);
            }

            this.lastIsOpen = this.IsOpen;
            this.parent?.RegisterItem(this);
            base.OnParametersSet();
        }

        /// <inheritdoc />
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);

            if (firstRender)
            {
                this.dotNetReference = DotNetObjectReference.Create(this);

                await this.JsInterop.InvokeVoidAsync(
                    "blazoradeBootstrap.registerEventCallback",
                    $"#{this.BodyId}",
                    "show.bs.collapse",
                    this.dotNetReference,
                    nameof(this.OnShowAsync),
                    false);

                await this.JsInterop.InvokeVoidAsync(
                    "blazoradeBootstrap.registerEventCallback",
                    $"#{this.BodyId}",
                    "shown.bs.collapse",
                    this.dotNetReference,
                    nameof(this.OnShownAsync),
                    false);

                await this.JsInterop.InvokeVoidAsync(
                    "blazoradeBootstrap.registerEventCallback",
                    $"#{this.BodyId}",
                    "hide.bs.collapse",
                    this.dotNetReference,
                    nameof(this.OnHideAsync),
                    false);

                await this.JsInterop.InvokeVoidAsync(
                    "blazoradeBootstrap.registerEventCallback",
                    $"#{this.BodyId}",
                    "hidden.bs.collapse",
                    this.dotNetReference,
                    nameof(this.OnHiddenAsync),
                    false);
            }
        }

        /// <summary>
        /// Opens the item using Bootstrap's Collapse plugin.
        /// </summary>
        public async Task ShowAsync()
        {
            if (this.parent is not null)
            {
                await this.parent.HideOtherItemsAsync(this);
            }

            await this.JsInterop.InvokeVoidAsync("blazoradeBootstrap.accordions.show", $"#{this.BodyId}");
        }

        /// <summary>
        /// Closes the item using Bootstrap's Collapse plugin.
        /// </summary>
        public Task HideAsync()
        {
            return this.JsInterop.InvokeVoidAsync("blazoradeBootstrap.accordions.hide", $"#{this.BodyId}").AsTask();
        }

        /// <summary>
        /// Toggles the item using Bootstrap's Collapse plugin.
        /// </summary>
        public Task ToggleAsync()
        {
            return this.JsInterop.InvokeVoidAsync("blazoradeBootstrap.accordions.toggle", $"#{this.BodyId}").AsTask();
        }

        /// <summary>
        /// Handles the Bootstrap show event.
        /// </summary>
        [JSInvokable]
        public async Task OnShowAsync()
        {
            this.isExpanded = true;
            await this.InvokeAsync(this.StateHasChanged);
            if (this.parent is not null)
            {
                await this.parent.RaiseShowAsync(this);
            }
        }

        /// <summary>
        /// Handles the Bootstrap shown event.
        /// </summary>
        [JSInvokable]
        public async Task OnShownAsync()
        {
            this.isExpanded = true;
            await this.InvokeAsync(this.StateHasChanged);
            if (this.parent is not null)
            {
                await this.parent.RaiseShownAsync(this);
            }
        }

        /// <summary>
        /// Handles the Bootstrap hide event.
        /// </summary>
        [JSInvokable]
        public async Task OnHideAsync()
        {
            this.isExpanded = false;
            await this.InvokeAsync(this.StateHasChanged);
            if (this.parent is not null)
            {
                await this.parent.RaiseHideAsync(this);
            }
        }

        /// <summary>
        /// Handles the Bootstrap hidden event.
        /// </summary>
        [JSInvokable]
        public async Task OnHiddenAsync()
        {
            this.isExpanded = false;
            await this.InvokeAsync(this.StateHasChanged);
            if (this.parent is not null)
            {
                await this.parent.RaiseHiddenAsync(this);
            }
        }

        internal void SetExpanded(bool value)
        {
            this.isExpanded = value;
        }

        /// <inheritdoc />
        public void Dispose()
        {
            this.parent?.UnregisterItem(this);
            this.dotNetReference?.Dispose();
        }
    }
}
