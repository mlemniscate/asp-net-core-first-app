using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace ConfigurationMVC.Infrastructure
{
    public class RequestMiddleware
    {
        private readonly RequestDelegate next;

        public RequestMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            DateTime now = DateTime.Now;
            context.Items["AllowedContinue"] = now.Hour <= 8;
            await next.Invoke(context);
        }
    }
}
