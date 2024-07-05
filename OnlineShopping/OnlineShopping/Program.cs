var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/hello", () =>
{  
    return "Welcome To MS.Net";
});

app.Run("http://localhost:8989");


