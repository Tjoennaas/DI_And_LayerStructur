


using Serilog;
using Middleware;
using Services;
using Model;



Log.Logger = new LoggerConfiguration()

.WriteTo.Console()
.WriteTo.File("logs/requests.txt", rollingInterval: RollingInterval.Day)
.CreateLogger();

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseSerilog();
builder.Services.AddControllers();
builder.Services.AddScoped<IGreeting, GreetingService>();
builder.Services.Configure<ApplicationOption>(builder.Configuration.GetSection("ApplicationOption"));


var app = builder.Build();


app.UseHttpsRedirection(); 
//app.UseSerilogRequestLogging();
app.UseMiddleware<LogRequest>();
app.MapControllers();


app.Run();





