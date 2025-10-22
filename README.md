Task 1: Create an ASP.NET Core Application

Create a new ASP.NET Core project (API).

Run the project and verify that the default “Hello World” or “WeatherForecast” API works.

Task 2: Configuration with appsettings.json

Add a new key in appsettings.json, for example:

"ApplicationName": "My First WebApp"


Retrieve the value in Program.cs and print it to the console when the application starts.

(Reflection): Why is appsettings.json useful in professional projects?

Task 3: Middleware

Create a simple custom middleware that logs the timestamp and URL for each request.

Add it to the pipeline in Program.cs.

Test by sending multiple requests in the browser or with Postman.

Task 4: Dependency Injection (DI)

Create an interface IGreetingService and an implementation GreetingService that returns a text string (e.g., "Hello from DI!").

Register the service in Program.cs using AddTransient.

Use the service in a controller via constructor injection and return the result from an API endpoint.

Task 5: Code Structure

Refactor the application so that you have a service class and a repository class (it can be a mock, e.g., a repository that returns a hardcoded list of books or users).

Use a By Layer structure:

Controllers

Services

Repositories

(Extra): Try organizing by Feature instead, and discuss the difference.
