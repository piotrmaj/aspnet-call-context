namespace CallContext
{
    public class RequestIdMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestIdMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            CallContext.SetRequestId("Middleware");
            var loggerFactory = context.RequestServices.GetService<ILoggerFactory>();
            var logger = loggerFactory.CreateLogger<GlobalExceptionFilterAttribute>();
            logger.LogRequestId("RequestIdMiddleware:");

            // Call the next delegate/middleware in the pipeline.
            await _next(context);
        }
    }

    public static class RequestIdMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestid(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestIdMiddleware>();
        }
    }
}