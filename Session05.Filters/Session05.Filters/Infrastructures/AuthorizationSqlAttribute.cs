using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace Session05.Filters.Infrastructures
{
    public interface IRepo
    {

    }
    public class Repo : IRepo
    {

    }
    public class AuthorizationSqlAttribute : Attribute,IAuthorizationFilter
    {
        private readonly IRepo repo;

        public AuthorizationSqlAttribute(IRepo repo)
        {
            this.repo = repo;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {

        }
    }
}
