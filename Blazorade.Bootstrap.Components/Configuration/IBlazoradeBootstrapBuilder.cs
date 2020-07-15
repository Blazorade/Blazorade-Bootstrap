using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components.Configuration
{
    /// <summary>
    /// The interface that defines the configuration builder used by Blazorade Bootstrap.
    /// </summary>
    public interface IBlazoradeBootstrapBuilder
    {
        /// <summary>
        /// Returns the service collection for the current application.
        /// </summary>
        IServiceCollection Services { get; }
    }


    internal class BlazoradeBootstrapBuilder : IBlazoradeBootstrapBuilder
    {
        public BlazoradeBootstrapBuilder(IServiceCollection services)
        {
            this.Services = services;
        }

        public IServiceCollection Services { get; private set; }

    }
}
