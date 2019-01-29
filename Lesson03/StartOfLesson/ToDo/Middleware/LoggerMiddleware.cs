using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace ToDoApp.Middleware
{
    //implement interface
    public class LoggerMiddleware : IMiddleware
    {
        private readonly ILogger<LoggerMiddleware> _logger;
        public LoggerMiddleware(ILogger<LoggerMiddleware> logger)
        {
            _logger = logger;
        }
        //invoke interface by using this 
        //context request path
        //route data https context value 
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            //Contract.Ensures(Contract.Result<Task>() != null);
            _logger.LogError(context.Request.Path);
            await next(context);
        }
    }
}
