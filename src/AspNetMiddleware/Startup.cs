namespace AspNetMiddleware
{
    using Microsoft.AspNet.Builder;
    using Microsoft.Extensions.Logging;

    public class Startup
    {
        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            loggerFactory.MinimumLevel = LogLevel.Warning;
            loggerFactory.AddDebug(LogLevel.Warning);

            app.UseIISPlatformHandler();
            app.UseArnoldQuotes();
        }
    }
}