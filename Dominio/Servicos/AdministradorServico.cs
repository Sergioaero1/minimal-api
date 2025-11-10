using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Interfaces;
using MinimalApi.DTOs;
using MinimalApi.Infraestrutura.Db;
// using System.Data.Common;
namespace MinimalApi.Dominio.Servicos;

public class AdministradorServico : IAdministradorServico
{
    private readonly DbContexto _contexto;
    public AdministradorServico(DbContexto contexto)
    {
        _contexto = contexto;
    }

    public Administrador? Login(LoginDTO loginDTO)
{
    var adm = _contexto.Administrador
        .FirstOrDefault(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha);

    return adm; // ✅ retorna o objeto ou null
}


    // public Administrador? Login(LoginDTO loginDTO)
    // {
    //     var adm = _contexto.Administrador.Where(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha).FirstOrDefault();
    //     return adm > 0;
    // }
}
