namespace AspNetMiddleware
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNet.Builder;
    using Microsoft.AspNet.Http;
    using Microsoft.Extensions.Logging;

    public class ArnoldQuotesMiddleware
    {
        private readonly ILogger _logger;

        private readonly List<string> _quotes = new List<string>
        {
            "I'll be back.",
            "It's not a tumor!",
            "Get to the chopper!!",
            "Hasta la vista, baby.",
            "Your clothes... give them to me, now.",
            "If it bleeds, we can kill it."
        };

        public ArnoldQuotesMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<ArnoldQuotesMiddleware>();
        }

        public async Task Invoke(HttpContext context)
        {
            var arnoldSays = _quotes[(int)(DateTime.Now.Ticks % _quotes.Count)];

            _logger.LogWarning(arnoldSays);

            await context.Response.WriteAsync(arnoldSays);
        }
    }
}