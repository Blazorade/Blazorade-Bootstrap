using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
        /// Creates a new instance of the component.
        /// </summary>
        public InputGroup()
        {
            this.InputType = InputType.Text;
        }



        /// <summary>
        /// The event that is fired when the text in the auto-generated input control has changed.
        /// </summary>
        /// <remarks>
        /// This event callback is ignored and will not fire if you specify your custom inputs with the <see cref="InputsTemplate"/> template.
        /// </remarks>
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
        /// Sets or returns the value displayed in the input control.
        /// </summary>
        /// <remarks>
        /// This parameter is ignored if you specify your own input controls with the <see cref="InputsTemplate"/> template parameter.
        /// </remarks>
        [Parameter]
        public string InputValue { get; set; }

        /// <summary>
        /// Specifies the type of the auto-generated input control.
        /// </summary>
        /// <remarks>
        /// This parameter is ignored if you specify your own input controls with the <see cref="InputsTemplate"/> template parameter.
        /// </remarks>
        [Parameter]
        public InputType InputType { get; set; }

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
        /// <example>
        /// <para>This sample demonstrates how you can add one text addon and one button addon to your <c>InputGroup</c></para>
        /// <code>
        /// <![CDATA[
        /// <InputGroup AddonPlacement="AddonPlacement.Append" InputPlaceholder="Enter the name you want to use">
        ///     <AddonsTemplate>
        ///         <InputGroupTextAddon>Name</InputGroupTextAddon>
        ///         <Button Color = "NamedColor.Primary" IsOutline="true">Submit</Button>
        ///     </AddonsTemplate>
        /// </InputGroup>
        /// ]]>
        /// </code>
        /// </example>
        [Parameter]
        public RenderFragment AddonsTemplate { get; set; }

        /// <summary>
        /// Addons added to this template will be prepended, i.e. added before any input controls in <see cref="InputsTemplate"/>.
        /// </summary>
        /// <remarks>
        /// All addons added to this template will always be prepended to the inputs in the <c>InputGroup</c>. <see cref="AddonsTemplate"/>
        /// for examples.
        /// </remarks>
        /// <seealso cref="AddonsTemplate"/>
        /// <seealso cref="AddonText"/>
        /// <seealso cref="AddonPlacement"/>
        [Parameter]
        public RenderFragment PrependAddonsTemplate { get; set; }

        /// <summary>
        /// Addons added to this template will be appended, i.e. added after any input controls in <see cref="InputsTemplate"/>.
        /// </summary>
        /// <remarks>
        /// All addons added to this template will always be appended to the inputs in the <c>InputGroup</c>. <see cref="AddonsTemplate"/>
        /// for examples.
        /// </remarks>
        /// <seealso cref="AddonsTemplate"/>
        /// <seealso cref="AddonText"/>
        /// <seealso cref="AddonPlacement"/>
        [Parameter]
        public RenderFragment AppendAddonsTemplate { get; set; }

        /// <summary>
        /// Allows you to customize how input controls are added to the input group. Also allows you to add multiple input controls.
        /// </summary>
        /// <remarks>
        /// Use standard &lt;input /&gt;, &lt;select /&gt; or &lt;textarea /&gt; elements with <c>class="form-control"</c> to style
        /// your input controls properly.
        /// </remarks>
        /// <example>
        /// <para>
        /// This example shows how you can specify your own inputs. You can add multiple inputs in the same template.
        /// </para>
        /// <code>
        /// <![CDATA[
        /// <InputGroup AddonText="Your name">
        ///     <InputsTemplate>
        ///         <input type="text" class="form-control" placeholder="First name" />
        ///         <input type="text" class="form-control" placeholder="Last name" />
        ///     </InputsTemplate>
        /// </InputGroup>
        /// ]]>
        /// </code>
        /// </example>
        [Parameter]
        public RenderFragment InputsTemplate { get; set; }




        /// <summary>
        /// Returns the specified placement for addons, or the default value if not specified explicitly.
        /// </summary>
        protected AddonPlacement GetAddonsPlacement()
        {
            return this.AddonPlacement ?? Components.AddonPlacement.Prepend;
        }

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



        private string GetInputTypeString()
        {
            string it;

            switch (this.InputType)
            {
                case InputType.Colour:
                    it = "color";
                    break;

                case InputType.Date:
                    it = "date";
                    break;

                case InputType.DateTimeLocal:
                    it = "datetime-local";
                    break;

                case InputType.Email:
                    it = "email";
                    break;

                case InputType.Month:
                    it = "month";
                    break;

                case InputType.Number:
                    it = "number";
                    break;

                case InputType.Password:
                    it = "password";
                    break;

                case InputType.Tel:
                    it = "tel";
                    break;

                case InputType.Time:
                    it = "time";
                    break;

                case InputType.Url:
                    it = "url";
                    break;

                case InputType.Week:
                    it = "week";
                    break;

                default:
                    it = "text";
                    break;
            }

            return it;
        }

        private async Task HandleOnChangedAsync(ChangeEventArgs e)
        {
            await this.OnChanged.InvokeAsync($"{e.Value}");
        }

        private bool ShowAppendAddons()
        {
            return
                (this.GetAddonsPlacement() == Components.AddonPlacement.Append && (!string.IsNullOrEmpty(this.AddonText) || null != this.AddonsTemplate))
                || null != this.AppendAddonsTemplate;
        }

        private bool ShowPrependAddons()
        {
            return
                (this.GetAddonsPlacement() == Components.AddonPlacement.Prepend && (!string.IsNullOrEmpty(this.AddonText) || null != this.AddonsTemplate))
                || null != this.PrependAddonsTemplate;
        }

    }
}
