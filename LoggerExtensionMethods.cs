namespace CallContext
{
    public static class LoggerExtensionMethods
    {
        public static void LogRequestId(this ILogger logger, string prefix = null)
        {
            if(prefix != null)
            {
                logger.LogError("{prefix} RequestId {requestId}", prefix, CallContext.GetRequestId());
            }
            else
            {
                logger.LogError("RequestId {requestId}", CallContext.GetRequestId());
            }
        }
    }
}
