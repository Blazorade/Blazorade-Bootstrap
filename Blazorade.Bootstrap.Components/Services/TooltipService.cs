using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components.Services
{
    /// <summary>
    /// A service implementation that is used to manage tooltips.
    /// </summary>
    /// <remarks>
    /// This service implementation needs to be added to the services collection of you application. Usually this is done during
    /// your startup configuration.
    /// </remarks>
    /// <example>
    /// <para>This example shows how you add the service in your <c>Startup</c> class.</para>
    /// <code>
    /// <![CDATA[
    /// public void ConfigureServices(IServiceCollection services)
    /// {
    ///     services.AddSingleton(new TooltipService
    ///     {
    ///         // Here you set all the options you want to have in your application.
    ///     });
    /// }
    /// ]]>
    /// </code>
    /// </example>
    public class TooltipService
    {

        /// <summary>
        /// Creates new instance of the service class.
        /// </summary>
        public TooltipService()
        {
            this.SanitizeHtml = true;
        }

        /// <summary>
        /// Specifies whether to allow HTML markup in tooltips. Default is <c>false</c>.
        /// </summary>
        public bool AllowHtml { get; set; }

        /// <summary>
        /// Determines whether HTML markup will be sanitized using the configured sanitization mechanism. Default is <c>true</c>.
        /// </summary>
        public bool SanitizeHtml { get; set; }

    }
}
