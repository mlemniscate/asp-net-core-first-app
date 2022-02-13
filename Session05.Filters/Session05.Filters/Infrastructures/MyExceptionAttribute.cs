using Microsoft.AspNetCore.Mvc.Filters;

namespace Session05.Filters.Infrastructures
{
    public class MyExceptionAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {

        }
    }
}
