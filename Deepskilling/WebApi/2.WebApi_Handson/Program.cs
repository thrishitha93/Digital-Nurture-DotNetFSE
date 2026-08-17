using Microsoft.OpenApi;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Swagger Demo",
        Version = "v1",
        Description = "Web API Hands-on"
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger Demo");
    });
}

app.UseHttpsRedirection();

app.MapGet("/api/values", () =>
{
    return new[] { "value1", "value2" };
});

app.MapPost("/api/values", (string value) =>
{
    return Results.Ok(value);
});

app.MapPut("/api/values/{id}", (int id, string value) =>
{
    return Results.Ok(value);
});

app.MapDelete("/api/values/{id}", (int id) =>
{
    return Results.Ok();
});

app.Run();