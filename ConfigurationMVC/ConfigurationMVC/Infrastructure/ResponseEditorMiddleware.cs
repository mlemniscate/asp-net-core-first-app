using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ConfigurationMVC.Infrastructure
{
    public class ResponseEditorMiddleware
    {
        private readonly RequestDelegate next;
        private readonly SiteUpTime siteUpTime;

        public ResponseEditorMiddleware(RequestDelegate next, SiteUpTime siteUpTime)
        {
            this.next = next;
            this.siteUpTime = siteUpTime;
        }

        public async Task Invoke(HttpContext context)
        {
            await next.Invoke(context);
            if (context.Response.StatusCode == 403)
            {
                await context.Response.WriteAsync($"Invalid Request Time. Site Up Time is {siteUpTime.GetUpTime()}");
            }
        }
    }
}
