using Microsoft.AspNetCore.Mvc.Filters;

namespace TMS_13.Filters
{
    public class MyResourceFilter : Attribute, IResourceFilter
    {
        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            Logger.OnExecuting("Resource");
        }
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Logger.OnExecuted("Resource");
        }
    }
}
