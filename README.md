# MiniToDo.NET
Minimal API com conexão ao Banco de Dados

*Instalar pacotes Design, SqLite

-Banco de dados configurado na pasta Data

-Program.cs

builder.Services.AddDbContext<AppDbContext>(); 

//O AddDbContext garante que haja apenas uma conexão aberta e fecha a conexão ao fim do uso.

*Migrations foi instalado com o comando abaixo, e o banco de dados foi criado com o nome da classe criada dentro da pasta Data.

- dotnet ef migrations add initialCreation


//update vai executar o script, se o banco não existir ele será criado

- dotnet ef database update

-instalar pacote Flunt do NuGet ou digitar no termianal:

- dotnet add package Flunt

**Baixar no NuGet

- Swashbuckle.AspNetCore.Swagger

- Swashbuckle.AspNetCore.SwaggerGen

- Swashbuckle.AspNetCore.SwaggerUI


aula balta.io youtube
