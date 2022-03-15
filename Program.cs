using Microsoft.EntityFrameworkCore;
using TodoApi.src.BusinessRules.Validators;
using TodoApi.src.Database;
using TodoApi.src.DataBase.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddGraphQLServer();
builder.Services.AddDbContext<TodoContext>(option => option.UseInMemoryDatabase("TodoDatabase"));

// Validators
builder.Services.AddScoped<ITaskValidator, TaskValidator>();
builder.Services.AddScoped<ITaskRepository, TaskRepository>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapGraphQL();

app.Run();
