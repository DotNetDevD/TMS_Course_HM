using Microsoft.AspNetCore.Mvc.Filters;

namespace TMS_13.Filters
{
    public class MyExceptionFilter : Attribute, IAsyncExceptionFilter
    {
        public Task OnExceptionAsync(ExceptionContext context)
        {
            string actionName = context.ActionDescriptor.DisplayName;
            string exceptionStack = context.Exception.StackTrace;
            string exceptionMessage = context.Exception.Message;

            using (StreamWriter sw = new("ErrorLog.txt", true))
                sw.WriteLine($"В методе {actionName} возникло исключение: \n {exceptionMessage} \n {exceptionStack}");
            
            throw new NotImplementedException();
        }
    }
}
