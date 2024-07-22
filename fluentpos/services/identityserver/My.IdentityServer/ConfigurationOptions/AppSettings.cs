using My.IdentityServer.ConfigurationOptions.ExternalLogin;
using My.Infrastructure.Caching;
using My.Infrastructure.Interceptors;
using My.Infrastructure.Logging;
using My.Infrastructure.Monitoring;
using System.Collections.Generic;

namespace My.IdentityServer.ConfigurationOptions
{
    public class AppSettings
    {
        public ConnectionStrings ConnectionStrings { get; set; }

        public IdentityServerOptions IdentityServer { get; set; }

        public LoggingOptions Logging { get; set; }

        public CachingOptions Caching { get; set; }

        public MonitoringOptions Monitoring { get; set; }

        public Dictionary<string, string> SecurityHeaders { get; set; }

        public InterceptorsOptions Interceptors { get; set; }

        public ExternalLoginOptions ExternalLogin { get; set; }

        public CookiePolicyOptions CookiePolicyOptions { get; set; }
    }
}
