using MiniToDo.Data;
using MiniToDo.Models;
using MiniToDo.ViewModels;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(); //AddDbContext garante que haja apenas uma conexão aberta
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

//após configurar o AddDbContext posso instanciar ele aqui
app.MapGet("v1/todos", (AppDbContext context) =>
{
    var todos = context.Todos.ToList();
    return Results.Ok(todos);
});

app.MapPost("v1/todos", (AppDbContext context, CreateToDoViewModel model) => {
    var todo = model.MapTo();
    if (!model.IsValid)
    return Results.BadRequest(model.Notifications);

//se a verificação der certo vai adicionar no Banco de Dados
    context.Todos.Add(todo);
    context.SaveChanges();

    return Results.Created($"/v1/todos/{todo.Id}", todo);
});


app.Run();
