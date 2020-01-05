using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewaresSandbox.Middlewares
{
    public static class LogErrorsMiddlewareExtensions
    {
        public static IServiceCollection AddErrorLog(this IServiceCollection services)
        {
            services.TryAddSingleton<LogErrorsMiddleware, LogErrorsMiddleware>();

            return services;
        }

        public static IApplicationBuilder UseErrorLog (this IApplicationBuilder app)
        {
            return app.UseMiddleware<LogErrorsMiddleware>();
        }
    }
}
