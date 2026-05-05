using Chaos.Api.Models.Request;
using Chaos.Api.Models.Response;
using Chaos.Api.Services;
using Chaos.Api.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure JSON serialization to use string representation for enums
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(
            new System.Text.Json.Serialization.JsonStringEnumConverter()
        );
    });

// Register the price calculation service for dependency injection
builder.Services.AddScoped<CalculateAnimalPriceInterface<DogRequest, DogResponse>, DogPriceService>();


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/health", () =>
{
    return Results.Ok(new
    {
        Status = "OK",
        Timestamp = DateTime.UtcNow
    });
});

app.MapGet("/status", () =>
{
    var response = new StatusResponse
    {
        ServiceName = "Chaos API",
        Environment = app.Environment.EnvironmentName,
        Version = "1.0.0",
        UpdatedAt = DateTime.UtcNow
    };

    return Results.Ok(response);
});

app.MapPost("/status", (StatusResponse input) =>
{
    input.UpdatedAt = DateTime.UtcNow;
    input.Path = "/Path";
    return Results.Ok(input);
});

// Map controller routes for handling dog price calculations and other endpoints
app.MapControllers();

app.Run();