using WebAPI.Data; 
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore; // Adicionado para a interface visual

var builder = WebApplication.CreateBuilder(args);

// 1. Habilita o uso de Controllers (importante para PersonagensController)
builder.Services.AddControllers(); 

builder.Services.AddOpenApi();

var connectionString = builder.Configuration.GetConnectionString("AppDbConnectionString");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

var app = builder.Build();

// 2. Configura a interface visual do Scalar
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference(); // Ativa a página em /scalar/v1
}

// 3. Mapeia os seus Controllers para que as rotas api/Personagens funcionem
app.MapControllers();

// Rota de teste mantida
var summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        )).ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

// Redireciona a página inicial para facilitar sua vida
app.MapGet("/", () => Results.Redirect("/scalar/v1"));

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}