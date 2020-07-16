using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components.Configuration
{

    /// <summary>
    /// The builder that is used to build the configuration for Blazorade Bootstrap with.
    /// </summary>
    public class BlazoradeBootstrapBuilder
    {
        internal BlazoradeBootstrapBuilder(IServiceCollection services)
        {
            this.Services = services;

            this.BlazoradeBootstrapOptions = new BlazoradeBootstrapOptions();
            this.TooltipOptions = new TooltipOptions();
        }

        public IServiceCollection Services { get; private set; }


        internal BlazoradeBootstrapOptions BlazoradeBootstrapOptions { get; private set; }

        internal TooltipOptions TooltipOptions { get; private set; }

    }
}
