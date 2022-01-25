using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ConfigurationMVC.Infrastructure
{
    public class ContentGeneratorMiddleware
    {
        private readonly RequestDelegate next;

        public ContentGeneratorMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Path.ToString().ToLower() == "/about")
            {
                await context.Response.WriteAsync("This is about page!! And this is my first middleware :)");
            }
            else
            {
                await next.Invoke(context);
            }
        }
    }
}
