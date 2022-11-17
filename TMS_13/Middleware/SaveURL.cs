using Microsoft.AspNetCore.Http.Extensions;

namespace TMS_13.Middleware
{
    public class SaveURL
    {
        private readonly RequestDelegate _next;
        public SaveURL(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            var absoluteUri = string.Concat(
                        context.Request.Scheme,
                        "://",
                        context.Request.Host.ToUriComponent(),
                        context.Request.PathBase.ToUriComponent(),
                        context.Request.Path.ToUriComponent(),
                        context.Request.QueryString.ToUriComponent());
            string path = @"D:\url.txt";
            using(StreamWriter st = new StreamWriter(path, true))
            {
                // alternative
                //st.WriteLine(context.Request.GetDisplayUrl()); 
                st.WriteLine(absoluteUri);
            }
            await _next(context);
        }
    }
}
