using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components.Showroom
{
    public class ToastHost : ComponentBase
    {

        public void AddToast(string content)
        {
            this.StateHasChanged();
        }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);

            builder.OpenComponent<Toast>(0);
            builder.AddAttribute(1, "ChildContent", (RenderFragment)((builder2) =>
            {
                builder2.AddContent(2, "Hello! This is a toast!");
            }));
            builder.CloseComponent();
        }
    }
}
