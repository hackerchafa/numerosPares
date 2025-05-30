using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Habilitar servicios de Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Habilitar Swagger en desarrollo
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Ruta raíz
app.MapGet("/", () => "API de verificación de números pares e impares");

// Endpoint documentado
app.MapGet("/api/parimpar", (int numero) =>
{
    var resultado = numero % 2 == 0 ? "par" : "impar";
    return Results.Ok(new { numero, resultado });
})
.WithName("Verificar si es par o impar")
.WithSummary("Devuelve si un número es par o impar")
.WithDescription("Pasa un número como parámetro en la URL (?numero=) y devuelve si es par o impar.");

app.Run();
