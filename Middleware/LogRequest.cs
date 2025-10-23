
using Serilog;

namespace Middleware;

public class LogRequest
{
    private readonly RequestDelegate _next;

    public LogRequest(RequestDelegate next)
    {
        _next = next;
    }


 public async Task InvokeAsync(HttpContext context)

    {
        var time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        var url = context.Request.Path;

        Log.Information($"[{time}] Request to: {url}");

        await _next(context); 
    }
}
