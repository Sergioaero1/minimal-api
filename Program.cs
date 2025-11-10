using MinimalApi.Infraestrutura.Db;
using MinimalApi.DTOs;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Microsoft.EntityFrameworkCore;
using MinimalApi.Dominio.Interfaces;
using MinimalApi.Dominio.Servicos;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IAdministradorServico, AdministradorServico>();

builder.Services.AddDbContext<DbContexto>(options =>
{
    var stringConexao = builder.Configuration.GetConnectionString("mysql");
    options.UseMySql(stringConexao, ServerVersion.AutoDetect(stringConexao));
});

var app = builder.Build();

app.MapGet("/", () => "Hello on this World!");

app.MapPost("/login", ([FromBody]LoginDTO loginDTO, IAdministradorServico administradorServico) =>
{
    if (administradorServico.Login(loginDTO) != null)
    {
        return Results.Ok(new { Message = "Login successful!" });
    }
    return Results.Unauthorized();
});

app.Run();
