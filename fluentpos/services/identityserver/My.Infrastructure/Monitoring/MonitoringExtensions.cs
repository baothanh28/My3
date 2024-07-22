﻿using My.Infrastructure.Monitoring.AzureApplicationInsights;
using My.Infrastructure.Monitoring.MiniProfiler;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace My.Infrastructure.Monitoring
{
    public static class MonitoringExtensions
    {
        public static IServiceCollection AddMonitoringServices(this IServiceCollection services, MonitoringOptions monitoringOptions = null)
        {
            if (monitoringOptions?.MiniProfiler?.IsEnabled ?? false)
            {
                services.AddMiniProfiler(monitoringOptions.MiniProfiler);
            }

            if (monitoringOptions?.AzureApplicationInsights?.IsEnabled ?? false)
            {
                services.AddAzureApplicationInsights(monitoringOptions.AzureApplicationInsights);
            }

            return services;
        }

        public static IApplicationBuilder UseMonitoringServices(this IApplicationBuilder builder, MonitoringOptions monitoringOptions)
        {
            if (monitoringOptions?.MiniProfiler?.IsEnabled ?? false)
            {
                builder.UseMiniProfiler();
            }

            return builder;
        }
    }
}
