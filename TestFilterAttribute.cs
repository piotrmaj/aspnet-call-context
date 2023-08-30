using Microsoft.AspNetCore.Mvc.Filters;

namespace CallContext
{
    public class TestFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            //var loggerFactory = context.HttpContext.RequestServices.GetService<ILoggerFactory>();
            //var logger = loggerFactory.CreateLogger<GlobalExceptionFilterAttribute>();
            //logger.LogRequestId("OnActionExecuted before:");
            //CallContext.SetRequestId("4");
            //logger.LogRequestId("OnActionExecuted after:");
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var loggerFactory = context.HttpContext.RequestServices.GetService<ILoggerFactory>();
            var logger = loggerFactory.CreateLogger<GlobalExceptionFilterAttribute>();
            logger.LogRequestId("OnActionExecuted before:");
            CallContext.SetRequestId("TestFilterAttribute OnActionExecuting");
            logger.LogRequestId("OnActionExecuted after:");
        }
    }
}
