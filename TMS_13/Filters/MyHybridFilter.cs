using Microsoft.AspNetCore.Mvc.Filters;

namespace TMS_13.Filters
{
    // Гибридный фильтр - одновременно фильтр действия и фильтр результата
    public class MyHybridFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Logger.OnExecuting("Action");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Logger.OnExecuted("Action");
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            Logger.OnExecuting("Result");
        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            Logger.OnExecuted("Result");
        }
    }
}
