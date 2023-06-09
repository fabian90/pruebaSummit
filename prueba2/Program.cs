using prueba.Repository;
using System.Collections;

var builder = WebApplication.CreateBuilder(args);

#region Repositories
builder.Services.AddScoped<IConversor, Conversor>();
builder.Services.AddScoped<IDiccionario, Diccionario>();
#endregion
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

app.Run();
