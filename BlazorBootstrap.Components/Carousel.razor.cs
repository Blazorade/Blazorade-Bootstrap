using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBootstrap.Components
{
    public abstract class CarouselBase : BootstrapComponentBase
    {
        protected CarouselBase()
        {
            this.AutoStart = true;
        }



        [Parameter]
        public bool AutoStart { get; set; }

        [Inject]
        protected IJSRuntime JsInterop { get; set; }


        protected async override void OnParametersSet()
        {
            this.AddClass(ClassNames.Carousels.Carousel);

            base.OnParametersSet();
        }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                if (this.AutoStart)
                {
                    await this.JsInterop.InvokeVoidAsync("blazorbs.carousels.carousel", $"#{this.Attributes["id"]}");
                }
            }

            await base.OnAfterRenderAsync(firstRender);
        }
    }
}
