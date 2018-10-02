using System;
using AspCoreAttributes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AspCoreAttributes.Attributes
{
    public class TestAttribute : TypeFilterAttribute
    {
        public TestAttribute(params UserRole[] roles) : base(typeof(TestFilter))
        {
            Arguments = new object[] { roles }; // roles will never null but length 0
        }
    }

    public class TestFilter : IAuthorizationFilter
    {
        public TestFilter(UserRole[] roles)
        {
            Console.WriteLine($"GetHashCode UserRole: {roles.GetHashCode()}, values: {String.Join(", ", roles)}");
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {

        }
    }
}