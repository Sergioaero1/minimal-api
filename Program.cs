var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello on this World! This is a minimal API example.");

app.MapPost("/login", (MinimalApi.DTOs.LoginDTO loginDTO) =>
{
    if (loginDTO.Email == "admin@teste.com" && loginDTO.Senha == "1232456")
    {
        return Results.Ok(new { Message = "Login successful!" });
    }
    return Results.Unauthorized();
});

app.Run();
