using Abstracciones.Interfaces.DA;
using Abstracciones.Interfaces.DA.Marcas;
using Abstracciones.Interfaces.DA.Modelos;
using Abstracciones.Interfaces.DA.Vehiculos;
using Abstracciones.Interfaces.Flujo.Marcas;
using Abstracciones.Interfaces.Flujo.Modelos;
using Abstracciones.Interfaces.Flujo.Vehiculos;
using DA.Modelos;
using DA.Repositorios;
using DA.Vehiculos;
using Flujo.Marcas;
using Flujo.Modelos;
using Flujo.Vehiculos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IVehiculoFlujo, VehiculoFlujo>();
builder.Services.AddScoped<IVehiculosDA, VehiculoDA>();
builder.Services.AddScoped<IMarcasDA, MarcasDA>();
builder.Services.AddScoped<IMarcasFlujo, MarcasFlujo>();
builder.Services.AddScoped<IModelosFlujo, ModelosFlujo>();
builder.Services.AddScoped<IModelosDA, ModelosDA>();
builder.Services.AddScoped<IRepositorioDapper, RepositorioDapper>();

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
