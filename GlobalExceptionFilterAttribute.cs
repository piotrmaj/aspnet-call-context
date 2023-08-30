using Microsoft.AspNetCore.Mvc.Filters;

namespace CallContext
{
    public class GlobalExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var loggerFactory = context.HttpContext.RequestServices.GetService<ILoggerFactory>();
            var logger = loggerFactory.CreateLogger<GlobalExceptionFilterAttribute>();
            logger.LogRequestId("GlobalExceptionFilterAttribute:");
        }
    }
}
