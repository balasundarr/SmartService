using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Helper
{
    public static class LogHelper
    {
        public static ILogger<T> GetLogger<T>()
        {
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .BuildServiceProvider();

            serviceProvider
                .GetService<ILoggerFactory>()
                .AddConsole(LogLevel.Debug)
                .AddConsole(LogLevel.Trace)
                .AddConsole(LogLevel.Information)
                .AddConsole(LogLevel.Warning)
                .AddConsole(LogLevel.Critical)
                .AddConsole(LogLevel.Error);

            return serviceProvider.GetService<ILoggerFactory>().CreateLogger<T>();
        }
    }
}
