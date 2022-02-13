using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System;

namespace Session05.Filters.Infrastructures
{
    public class MyActionAttribute : Attribute, IActionFilter
    {
        private readonly Stopwatch stopwatch = new Stopwatch();
        public void OnActionExecuted(ActionExecutedContext context)
        {
            stopwatch.Start();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            HttpResponseWritingExtensions.WriteAsync(
                context.HttpContext.Response,
                $"Execution Time is: {stopwatch.Elapsed}"
                );
        }
    }
}
