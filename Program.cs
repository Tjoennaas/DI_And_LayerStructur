
 using Serilog;
using Middleware;


Log.Logger = new LoggerConfiguration()

.WriteTo.Console()
.WriteTo.File("logs/requests.txt", rollingInterval: RollingInterval.Day)
.CreateLogger();

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseSerilog();

// Required for UseAuthorization()
builder.Services.AddAuthorization();
var app = builder.Build();

app.UseHttpsRedirection(); 
app.UseAuthorization();

app.UseMiddleware<LogRequest>();

app.MapGet("/", () => "Hello World!");
app.Run();


//oppg.1  -----------------------------------------

/*
var builder = WebApplication.CreateBuilder(args);


app.MapGet("/", () => "Hello World!");
app.Run();  */




// oppg.2 -----------------------------------------

/*
var builder = WebApplication.CreateBuilder(args);
var appName = builder.Configuration["Name"];

var app = builder.Build();

Console.WriteLine($"Starter applikasjonen: {appName}");
app.MapGet("/", () => $"Velkommen til {appName}!");

app.run() */

//--------------------------------------//

/*
using Model;
using Controller;


var builder = WebApplication.CreateBuilder(args);

// Register the controllers
builder.Services.AddControllers();

// Bind ApplicationOptions from appsettings.json
builder.Services.Configure<ApplicationOption>(
    builder.Configuration);

var app = builder.Build();

// Map the controller endpoints
app.MapControllers();

app.Run();
*/

/*

//oppg.3 -----------------------------------------


/*
Middleware are components that handle HTTP requests and responses.
They provide functionality such as logging, authentication, and error handling.
They are added to the HTTP pipeline via Program.cs and executed in the order in which they are registered.
 


 Overview built in middlewere : https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-9.0#built-in-middleware


eks:  */

/*
using Serilog;


Log.Logger = new LoggerConfiguration()

.WriteTo.Console()
.WriteTo.File("logs/requests.txt", rollingInterval: RollingInterval.Day)
.CreateLogger();

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseSerilog();

// Required for UseAuthorization()
builder.Services.AddAuthorization();
var app = builder.Build();

app.UseHttpsRedirection(); 
app.UseAuthorization();
// Optional: Serilog’s built-in middleware for request logging
app.UseSerilogRequestLogging();


app.MapGet("/", () => "Hello World!");
app.Run(); 

*/

// Custom middleware for logging request:

