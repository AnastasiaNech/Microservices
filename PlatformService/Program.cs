using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Sentry;

namespace PlatformService
{
    public class Program
    {
        public static void Main(string[] args)
        {
        
        using (SentrySdk.Init(o =>
        {
            // Tells which project in Sentry to send events to:
            o.Dsn = "https://f3eb32a3050c48c09eb6e87ecc799746@o4504003917840384.ingest.sentry.io/4504004213669888";
            // When configuring for the first time, to see what the SDK is doing:
            o.Debug = false;
            // Set traces_sample_rate to 1.0 to capture 100% of transactions for performance monitoring.
            // We recommend adjusting this value in production.
            o.TracesSampleRate = 1.0;
            // Enable Global Mode if running in a client app
            o.IsGlobalModeEnabled = true;
        }))
                CreateHostBuilder(args).Build().Run();

        }


        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
