using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplicationRestaurante.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<WebApplicationRestauranteContextVenta>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebApplicationRestauranteContextVenta") ?? throw new InvalidOperationException("Connection string 'WebApplicationRestauranteContextVenta' not found.")));
builder.Services.AddDbContext<WebApplicationRestauranteContextTipoDocumento>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebApplicationRestauranteContextTipoDocumento") ?? throw new InvalidOperationException("Connection string 'WebApplicationRestauranteContextTipoDocumento' not found.")));
builder.Services.AddDbContext<WebApplicationRestauranteContextPedido>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebApplicationRestauranteContextPedido") ?? throw new InvalidOperationException("Connection string 'WebApplicationRestauranteContextPedido' not found.")));
builder.Services.AddDbContext<WebApplicationRestauranteContextMenu>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebApplicationRestauranteContextMenu") ?? throw new InvalidOperationException("Connection string 'WebApplicationRestauranteContextMenu' not found.")));
builder.Services.AddDbContext<WebApplicationRestauranteContextIngredientes>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebApplicationRestauranteContextIngredientes") ?? throw new InvalidOperationException("Connection string 'WebApplicationRestauranteContextIngredientes' not found.")));
builder.Services.AddDbContext<WebApplicationRestauranteContextFactura>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebApplicationRestauranteContextFactura") ?? throw new InvalidOperationException("Connection string 'WebApplicationRestauranteContextFactura' not found.")));
builder.Services.AddDbContext<WebApplicationRestauranteContextCliente>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebApplicationRestauranteContextCliente") ?? throw new InvalidOperationException("Connection string 'WebApplicationRestauranteContextCliente' not found.")));

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
