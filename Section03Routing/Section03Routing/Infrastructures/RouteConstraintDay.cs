using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;
using System.Linq;

namespace Section03Routing.Infrastructures
{
    public class RouteConstraintDay : IRouteConstraint
    {
        private List<string> ValidDate = new List<string>
        {
            "saturday",
            "sunday",
            "monday"
        };
        public bool Match(HttpContext httpContext,
            IRouter route,
            string routeKey,
            RouteValueDictionary values,
            RouteDirection routeDirection)
        {
            return ValidDate.Contains(values[routeKey]);
        }
    }
}
