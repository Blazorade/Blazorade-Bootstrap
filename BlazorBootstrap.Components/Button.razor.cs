using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBootstrap.Components
{
    public abstract class ButtonBase : BootstrapStyledBase
    {

        /// <summary>
        /// Callback for when the button is clicked.
        /// </summary>
        [Parameter]
        public EventCallback OnClick { get; set; }

        /// <summary>
        /// Specifies whether the button appears active.
        /// </summary>
        [Parameter]
        public bool IsActive { get; set; }

        /// <summary>
        /// Specifies whether the button is a block-level button.
        /// </summary>
        [Parameter]
        public bool IsBlockLevel { get; set; }

        /// <summary>
        /// Specifies whether the button is disabled.
        /// </summary>
        [Parameter]
        public bool IsDisabled { get; set; }

        /// <summary>
        /// Specifies whether the button is styled as a link.
        /// </summary>
        [Parameter]
        public bool IsLink { get; set; }

        /// <summary>
        /// Specifies whether the button is styled as an outline button.
        /// </summary>
        [Parameter]
        public bool IsOutline { get; set; }

        /// <summary>
        /// Specifies whether the button is a submit button. The default type is <c>button</c>.
        /// </summary>
        public bool IsSubmit { get; set; }

        [Parameter]
        public string Link { get; set; }

        [Parameter]
        public ButtonSize Size { get; set; }



        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Buttons.Button);

            if(this.Color != ComponentColor.None && !this.IsLink)
            {
                this.AddClass(this.GetStyleClassName(!this.IsOutline ? ClassNames.Buttons.Button : ClassNames.Buttons.OutlineButton));
            }
            else if(this.IsLink)
            {
                this.AddClass(ClassNames.Buttons.LinkButton);
            }

            if (this.IsBlockLevel)
            {
                this.AddClass(ClassNames.Buttons.BlockLevel);
            }

            if (this.IsActive)
            {
                this.AddClass(ClassNames.Active);
            }

            switch (this.Size)
            {
                case ButtonSize.Large:
                    this.AddClass(ClassNames.Buttons.Large);
                    break;

                case ButtonSize.Small:
                    this.AddClass(ClassNames.Buttons.Small);
                    break;
            }

            if (this.IsDisabled)
            {
                this.AddAttribute("disabled", "disabled");
            }

            if(!this.IsSubmit)
            {
                this.AddAttribute("type", "button");
            }
            else
            {
                this.AddAttribute("type", "submit");
            }

            base.OnParametersSet();
        }

        protected async Task OnButtonClick(object args)
        {
            await this.OnClick.InvokeAsync(args);
        }
    }

    public enum ButtonSize
    {
        Normal = 0,
        Large = 1,
        Small = 2
    }
}
