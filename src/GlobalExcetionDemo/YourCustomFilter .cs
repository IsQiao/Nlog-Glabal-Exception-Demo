using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalExcetionDemo
{
    public class YourCustomFilter : ActionFilterAttribute, IExceptionFilter
    {
        private readonly ILogger<YourCustomFilter> _logger;
        public YourCustomFilter(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<YourCustomFilter>();
        }
        //public YourCustomFilter
        public void OnException(ExceptionContext context)
        {
            _logger.LogError(context.Exception.ToString());
        }
    }
}
