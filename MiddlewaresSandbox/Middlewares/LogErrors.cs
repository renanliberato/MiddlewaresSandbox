using Microsoft.AspNetCore.Http;
using MiddlewaresSandbox.Models;
using MiddlewaresSandbox.Repositories;
using System;
using System.IO;
using System.Threading.Tasks;

namespace MiddlewaresSandbox.Middlewares
{
    public class LogErrorsMiddleware : IMiddleware
    {
        private readonly IErrorsRepository ErrorsRepository;

        public LogErrorsMiddleware(IErrorsRepository errorsRepository)
        {
            ErrorsRepository = errorsRepository;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            } catch (Exception e)
            {
                
                context.Request.Headers.TryGetValue("X-Guid", out var GuidValue);

                using (var reader = new StreamReader(context.Request.Body))
                {
                    var body = await reader.ReadToEndAsync();

                    var error = new Error(
                        Guid.Parse(GuidValue),
                        context.Request.Path,
                        context.Request.Method,
                        body,
                        DateTime.Now,
                        e.Message,
                        e.StackTrace
                    );

                    ErrorsRepository.AddError(error);
                }

                throw e;
            }

            
        }
    }
}
