using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace ConfigurationMVC.Infrastructure
{
    public class ShortCircuitMiddleware
    {
        private readonly RequestDelegate next;

        public ShortCircuitMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Items["AllowedContinue"] as bool? == false)
            {
                context.Response.StatusCode = 403;
            }
            else
            {
                await next.Invoke(context);
            }
        }
    }
}
