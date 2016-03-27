namespace AspNetMiddleware
{
    using Microsoft.AspNet.Builder;

    public static class ArnoldQuotesExtensions
    {
        public static void UseArnoldQuotes(this IApplicationBuilder app)
        {
            app.UseMiddleware<ArnoldQuotesMiddleware>();
        }
    }
}