using Blazorade.Bootstrap.Components.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Extension methods for configuring Blazorade Bootstrap at startup.
    /// </summary>
    public static class StartupExtensions
    {

        public static BlazoradeBootstrapBuilder AddBlazoradeBootstrap(this IServiceCollection services, Action<BlazoradeBootstrapOptions> configure = null)
        {
            var builder = new BlazoradeBootstrapBuilder(services);
            services.AddSingleton(builder.BlazoradeBootstrapOptions);
            services.AddSingleton(builder.TooltipOptions);


            if(null != configure)
            {
                configure(builder.BlazoradeBootstrapOptions);
            }

            return builder;
        }

        public static BlazoradeBootstrapBuilder WithTooltip(this BlazoradeBootstrapBuilder builder, Action<TooltipOptions> configure = null)
        {
            if(null != configure)
            {
                configure(builder.TooltipOptions);
            }

            return builder;
        }
    }
}
