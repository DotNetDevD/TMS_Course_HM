using Microsoft.AspNetCore.Mvc.Filters;

namespace TMS_13.Filters
{
    public class MyAuthorizationFilter : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            Logger.OnExecuted("Authorization");
        }
    }
}
