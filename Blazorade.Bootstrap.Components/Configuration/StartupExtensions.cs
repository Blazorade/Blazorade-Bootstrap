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

        public static IBlazoradeBootstrapBuilder AddBlazoradeBootstrap(this IServiceCollection services, Action<BlazoradeBootstrapOptions> configure = null)
        {
            var options = new BlazoradeBootstrapOptions();
            if(null != configure)
            {
                configure(options);
            }

            services.AddSingleton(options);
            return new BlazoradeBootstrapBuilder(services);
        }
    }
}
