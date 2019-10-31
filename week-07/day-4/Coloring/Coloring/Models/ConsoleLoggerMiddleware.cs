using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coloring.Models
{
    public class ConsoleLoggerMiddleware : IMiddleware
    {
        private IColor color;
        public ConsoleLoggerMiddleware(IColor color)
        {
            this.color = color;
        }
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine("Hello from middleware");
            color.PrintColor();

            return next(context);
        }
    }
}
