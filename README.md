# Cadastro de Veículos - ASP.NET Minimal API 🚗

Este projeto é uma API REST desenvolvida com **ASP.NET Core 9.0** utilizando o modelo de **Minimal APIs**, com persistência de dados via **Entity Framework Core** e banco de dados **MySQL**.

---

## 🧠 Funcionalidades

- ✅ Autenticação de administrador via e-mail e senha
- ✅ Cadastro e consulta de veículos
- ✅ Migrações e atualização de banco com EF Core
- ✅ Seed automático de administrador padrão
- ✅ Uso de `[FromBody]` para receber dados via JSON

---

## 🛠️ Tecnologias Utilizadas

- ASP.NET Core 9.0 (Minimal APIs)
- Entity Framework Core 9.0
- Pomelo.EntityFrameworkCore.MySql
- MySQL
- C#

---

## ⚙️ Configuração

### 1. Clonar o repositório

```bash
git clone https://github.com/seu-usuario/Cadastro_de_Veiculos-com-ASP.NET_Minimal_APIs.git
cd minimal-api

2. Configurar appsettings.json
Adicione a string de conexão:

{
  "ConnectionStrings": {
    "mysql": "server=localhost;database=veiculosdb;user=root;password=senha"
  }
}

3. Restaurar pacotes e compilar

dotnet restore
dotnet build

4. Criar e aplicar migração

dotnet ef migrations add VeiculosMigration
dotnet ef database update

🚀 Endpoints
POST /login
Autentica administrador:

{
  "email": "administrador@teste.com",
  "senha": "123456"
}

POST /veiculos
Cadastra um novo veículo:

{
  "modelo": "Civic",
  "marca": "Honda",
  "ano": 2022
}

GET /veiculos
Retorna todos os veículos cadastrados.

👤 Administrador Padrão
Criado automaticamente via seed:
- Email: administrador@teste.com
- Senha: 123456
- Perfil: Adm

📄 Licença
Este projeto é open-source e está sob a licença MIT

