# Ouput
```
fail: CallContext.GlobalExceptionFilterAttribute[0]
      RequestIdMiddleware: RequestId Middleware
fail: CallContext.Controllers.WeatherForecastController[0]
      WeatherForecastController constructor before: RequestId Middleware
fail: CallContext.Controllers.WeatherForecastController[0]
      WeatherForecastController constructor after: RequestId WeatherForecastController constructor
fail: CallContext.GlobalExceptionFilterAttribute[0]
      OnActionExecuted before: RequestId WeatherForecastController constructor
fail: CallContext.GlobalExceptionFilterAttribute[0]
      OnActionExecuted after: RequestId TestFilterAttribute OnActionExecuting
fail: CallContext.Controllers.WeatherForecastController[0]
      Get before: RequestId TestFilterAttribute OnActionExecuting
fail: CallContext.Controllers.WeatherForecastController[0]
      Get after: RequestId Get
fail: CallContext.Controllers.WeatherForecastController[0]
      MethodSync before: RequestId Get
fail: CallContext.Controllers.WeatherForecastController[0]
      MethodSync after: RequestId MethodSync
fail: CallContext.Controllers.WeatherForecastController[0]
      Get after MethodSync: RequestId MethodSync
fail: CallContext.Controllers.WeatherForecastController[0]
      MethodAsync before: RequestId MethodSync
fail: CallContext.Controllers.WeatherForecastController[0]
      MethodAsync after: RequestId MethodAsync
fail: CallContext.Controllers.WeatherForecastController[0]
      MethodAsyncNested before: RequestId MethodAsync
fail: CallContext.Controllers.WeatherForecastController[0]
      MethodAsyncNested after: RequestId MethodAsyncNested
fail: CallContext.Controllers.WeatherForecastController[0]
      MethodAsync after Nested: RequestId MethodAsync
fail: CallContext.Controllers.WeatherForecastController[0]
      Get after MethodAsync: RequestId MethodSync
fail: CallContext.GlobalExceptionFilterAttribute[0]
      GlobalExceptionFilterAttribute: RequestId WeatherForecastController constructor
```