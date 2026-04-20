using Chaos.Api.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
    return Results.Ok(input);
});

app.Run();