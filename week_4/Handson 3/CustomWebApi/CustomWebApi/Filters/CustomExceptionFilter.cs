using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.IO;

namespace CustomWebApi.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            string logPath = Path.Combine(Directory.GetCurrentDirectory(), "Logs");
            Directory.CreateDirectory(logPath);
            string logFile = Path.Combine(logPath, "exceptions.txt");

            File.AppendAllText(logFile, $"[{DateTime.Now}] {context.Exception.Message}{Environment.NewLine}");

            context.Result = new ObjectResult("An unexpected error occurred.")
            {
                StatusCode = 500
            };
        }
    }
}