using Microsoft.AspNetCore.Builder;

namespace CodeTenorSchool.ExceptionHandler
{
    public static class ExceptionMiddlewareConfig
    {
        public static void ConfigureExceptionHanlder(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
