using Microsoft.AspNetCore.Diagnostics;

namespace LionService.Middleware;

public static class GlobalExceptionHandler
{
    public static void UseCustomGlobalExceptionHandler(this IApplicationBuilder app)
    {
        app.UseExceptionHandler(errorApp =>
        {
            errorApp.Run(async context =>
            {
                var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
                var exception = exceptionHandlerPathFeature?.Error;

                context.Response.ContentType = "application/json";
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;

                await context.Response.WriteAsJsonAsync(new
                {
                    context.Response.StatusCode,
                    Message = exception?.Message ?? "An unexpected error occurred."
                });
            });
        });
    }
}