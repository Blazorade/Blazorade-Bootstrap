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
        /// Specifies whether the button is styled as a link.
        /// </summary>
        public bool IsLink { get; set; }

        /// <summary>
        /// Specifies whether the button is a submit button. The default type is <c>button</c>.
        /// </summary>
        public bool IsSubmit { get; set; }

        [Parameter]
        public string Link { get; set; }



        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Buttons.Button);

            if(this.ComponentStyle != ComponentStyle.None && !this.IsLink)
            {
                this.AddClass(this.GetStyleClassName(ClassNames.Buttons.Button));
            }
            else if(this.IsLink)
            {

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
}
