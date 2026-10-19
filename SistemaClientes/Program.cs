var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Minha primeira Minimal API funciona!");



app.Run();
