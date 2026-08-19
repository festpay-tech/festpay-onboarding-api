# Festpay Onboarding API

API desenvolvida em **.NET 9 / C#** para o gerenciamento de contas e transações da Festpay.

O projeto utiliza uma arquitetura separada em **API, Application, Domain e Infrastructure**, com **CQRS/MediatR**, **Carter**, **Entity Framework Core** e **SQLite**.

> **Status da implementação:** a estrutura base de contas está implementada. A entidade `Transacao` e sua configuração no Entity Framework Core foram adicionadas, porém o CRUD completo de transações previsto no teste técnico ainda não está implementado nesta versão. 

---

## 1. Tecnologias utilizadas

| Tecnologia | Versão | Utilização |
|---|---:|---|
| .NET | 9.0 | Plataforma da aplicação |
| C# | Compatível com .NET 9 | Linguagem |
| ASP.NET Core | 9.x | Web API |
| Carter | 9.0.0 | Minimal APIs / organização dos endpoints |
| MediatR | 12.5.0 | CQRS e desacoplamento entre endpoints e handlers |
| FluentValidation | 11.11.0 | Validação de comandos |
| Entity Framework Core | 9.0.4 | ORM |
| SQLite | EF Core SQLite 9.0.4 | Banco de dados |
| Swashbuckle | 8.1.1 | Swagger/OpenAPI |
| Microsoft.AspNetCore.OpenApi | 9.0.4 | OpenAPI |
| Newtonsoft.Json | 13.0.3 | Serialização JSON |
| xUnit | 2.9.2 | Testes automatizados |
| Moq | 4.20.72 | Mocking nos testes |
| EF Core InMemory | 9.0.4 | Banco em memória para testes |
| Coverlet | 6.0.2 | Cobertura de testes |

---

## 2. Arquitetura

A solução está organizada em camadas:


Festpay.Onboarding.Api

Festpay.Onboarding.Application
 Festpay.Onboarding.Domain
 Festpay.Onboarding.Infra
SQLite


### Projetos

#### `Festpay.Onboarding.Api`

Responsável pela inicialização da aplicação HTTP.

Principais componentes:

- `Program.cs`
- Middleware de exceções
- CORS
- Session
- Swagger
- OpenAPI
- Carter
- Mapeamento dos endpoints

#### `Festpay.Onboarding.Application`

Contém as regras de aplicação e os casos de uso.

Principais tecnologias/padrões:

- CQRS
- MediatR
- Carter
- FluentValidation
- Handlers
- Validators
- Result pattern

Exemplos:


Features
V1
  ─ Account/
  ─ CreateAccount.cs
  ─ GetAccounts.cs
  ─ ChangeAccountStatus.cs
  ─ Transactions/
  ─ GetTransations.cs


#### `Festpay.Onboarding.Domain`

Contém as entidades e regras de domínio.

Entidades atuais:

- `EntityBase`
- `Account`
- `Transacao`

Também contém:

- Exceções de domínio
- Extensões de validação
- Builders das entidades

#### `Festpay.Onboarding.Infra`

Responsável pelo acesso a dados e configurações do Entity Framework Core.

Componentes principais:

- `FestpayContext`
- `FestpayContextFactory`
- Configurações das entidades
- Migrations
- Configuração do SQLite
- Injeção de dependência

#### `ConsoleApp1`

Projeto auxiliar utilizado para operações relacionadas ao Entity Framework Core/design-time.

Não é necessário para iniciar a API.



## 3. Pré-requisitos

Para executar o projeto localmente, é necessário instalar:

.NET SDK 9

O projeto possui:


Pode ser utilizado:

- Visual Studio 2022
- JetBrains Rider


## 4. Banco de dados

A aplicação utiliza:

SQLite

A conexão é definida pela variável de ambiente:


DATABASE_CONNECTION_STRING
```

Caso a variável de ambiente não esteja configurada, o `FestpayContextFactory` utiliza atualmente um caminho fixo de fallback:

caminho fixo.
"DATABASE_CONNECTION_STRING" ?? "Data Source=C:\\teste-fastpay\\festpay-onboarding-api\\Festpay.Onboarding.Infra\\festpay.db;";

**Recomendação:** configurar sempre `DATABASE_CONNECTION_STRING` para evitar dependência desse caminho fixo.

---

## 5. Variável de ambiente

### Windows CMD

```cmd
set DATABASE_CONNECTION_STRING=Data Source=festpay.db
```

### Windows PowerShell

```powershell
$env:DATABASE_CONNECTION_STRING="Data Source=festpay.db"
```

### Linux/macOS

```bash
export DATABASE_CONNECTION_STRING="Data Source=festpay.db"
```

---

## 6. Clonar o projeto

Exemplo:

```bash
git clone <URL_DO_REPOSITORIO>
cd festpay-onboarding-api
```

---

## 7. Restaurar dependências

Na raiz da solução:

```bash
dotnet restore
```

Ou:

```bash
dotnet restore Festpay.Onboarding.Api.sln
```

---

## 8. Compilar

```bash
dotnet build
```

Para compilar sem executar:

```bash
dotnet build Festpay.Onboarding.Api.sln
```

---

## 9. Executar a API

Entre no projeto da API:

```bash
cd Festpay.Onboarding.Api
```

Execute:

```bash
dotnet run
```

Ou diretamente pela raiz:

```bash
dotnet run --project Festpay.Onboarding.Api
```

---

## 10. URLs locais

Conforme o `launchSettings.json`, a aplicação está configurada para utilizar:

### HTTPS

```text
https://localhost:7266
```

### HTTP

```text
http://localhost:5081
```

### Swagger

```text
https://localhost:7266/swagger
```

ou:

```text
http://localhost:5081/swagger
```

O Swagger é aberto automaticamente quando o projeto é executado pelo perfil configurado no `launchSettings.json`.

---

## 11. Executando pelo Visual Studio

1. Abra `Festpay.Onboarding.Api.sln`.
2. Defina `Festpay.Onboarding.Api` como projeto de inicialização.
3. Selecione o perfil `https`.
4. Execute com `F5` ou `Ctrl + F5`.
5. A aplicação deverá abrir o Swagger.



