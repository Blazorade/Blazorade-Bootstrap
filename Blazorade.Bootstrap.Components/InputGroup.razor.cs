using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// The <c>InputGroup</c> allows you to easily extend form controls by adding text, buttons, or button groups on either side of textual inputs, custom selects, and custom file inputs.
    /// </summary>
    partial class InputGroup
    {

        /// <summary>
        /// The event that is fired when the text in the auto-generated input control has changed.
        /// </summary>
        [Parameter]
        public EventCallback<string> OnChanged { get; set; }

        /// <summary>
        /// Defines the placement for your addon(s).
        /// </summary>
        /// <remarks>
        /// If this parameter is not specified, addon placement will default to <see cref="AddonPlacement.Prepend"/>.
        /// This parameter is ignored for addons added to either <see cref="AppendAddonsTemplate"/> or <see cref="PrependAddonsTemplate"/>.
        /// </remarks>
        [Parameter]
        public AddonPlacement? AddonPlacement { get; set; }

        /// <summary>
        /// Specifies the text to show in the addon.
        /// </summary>
        [Parameter]
        public string AddonText { get; set; }

        /// <summary>
        /// The text to use as placeholder on the input control.
        /// </summary>
        /// <remarks>
        /// This parameter is ignored if you specify your inputs using the <see cref="InputsTemplate"/> template parameter.
        /// </remarks>
        [Parameter]
        public string InputPlaceholder { get; set; }

        /// <summary>
        /// Specifies whether the input control is a multiline text field.
        /// </summary>
        /// <remarks>
        /// This parameter is ignored if you specify your input controls with the <see cref="InputsTemplate"/> template.
        /// </remarks>
        [Parameter]
        public bool Multiline { get; set; }

        /// <summary>
        /// The size of the input group.
        /// </summary>
        /// <remarks>
        /// If this parameter is not set, the input group will be sized as if the size was set to <see cref="ComponentSize.Normal"/>.
        /// </remarks>
        [Parameter]
        public ComponentSize? Size { get; set; }

        /// <summary>
        /// The template that you use for your custom addons.
        /// </summary>
        /// <remarks>
        /// The placement for the addons added to this template will be adjusted accoording to <see cref="AddonPlacement"/>.
        /// </remarks>
        [Parameter]
        public RenderFragment AddonsTemplate { get; set; }

        /// <summary>
        /// Addons added to this template will be prepended, i.e. added before any input controls in <see cref="InputsTemplate"/>.
        /// </summary>
        [Parameter]
        public RenderFragment PrependAddonsTemplate { get; set; }

        /// <summary>
        /// Addons added to this template will be appended, i.e. added after any input controls in <see cref="InputsTemplate"/>.
        /// </summary>
        [Parameter]
        public RenderFragment AppendAddonsTemplate { get; set; }

        /// <summary>
        /// Allows you to customize how input controls are added to the input group. Also allows you to add multiple input controls.
        /// </summary>
        [Parameter]
        public RenderFragment InputsTemplate { get; set; }



        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            this.AddClasses(ClassNames.InputGroups.InputGroup);
            if(this.Size.HasValue)
            {
                if(this.Size.Value == ComponentSize.Large)
                {
                    this.AddClasses(ClassNames.InputGroups.Large);
                }
                else if (this.Size.Value == ComponentSize.Small)
                {
                    this.AddClasses(ClassNames.InputGroups.Small);
                }
            }

        }


        private async Task HandleOnChangedAsync(ChangeEventArgs e)
        {
            await this.OnChanged.InvokeAsync($"{e.Value}");
        }
    }
}
