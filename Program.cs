

/*
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run(); */




var builder = WebApplication.CreateBuilder(args);
var appName = builder.Configuration["Name"];

var app = builder.Build();

Console.WriteLine($"Starter applikasjonen: {appName}");
app.MapGet("/", () => $"Velkommen til {appName}!");



app.Run();