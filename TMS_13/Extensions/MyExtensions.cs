using TMS_13.Middleware;

namespace TMS_13.Extensions
{
    public static class MyExtensions
    {
        public static IApplicationBuilder SaveURL(this IApplicationBuilder app)
        {
            return app.UseMiddleware<SaveURL>();
        }
    }
}
