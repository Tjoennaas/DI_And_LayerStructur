
 


//oppg.1
/*
var builder = WebApplication.CreateBuilder(args);


app.MapGet("/", () => "Hello World!");
app.Run(); */




// oppg.2
/*
var builder = WebApplication.CreateBuilder(args);
var appName = builder.Configuration["Name"];

var app = builder.Build();

Console.WriteLine($"Starter applikasjonen: {appName}");
app.MapGet("/", () => $"Velkommen til {appName}!");

app.run()


//oppg.3 

/*
Middleware are components that handle HTTP requests and responses.
They provide functionality such as logging, authentication, and error handling.
They are added to the HTTP pipeline via Program.cs and executed in the order in which they are registered.
 


 Overview built in middlewere : https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-9.0#built-in-middleware


eks: */


var builder = WebApplication.CreateBuilder(args);

// Required for UseAuthorization()
builder.Services.AddAuthorization();
var app = builder.Build();

app.UseHttpsRedirection(); 
app.UseAuthorization();

app.MapGet("/", () => "Hello World!");
app.Run();






