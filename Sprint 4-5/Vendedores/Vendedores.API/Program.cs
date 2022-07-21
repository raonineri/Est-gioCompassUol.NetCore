using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;
using Vendedores.Application.Services;
using Vendedores.Application.Services.Interfaces;
using Vendedores.Data.Contexts;
using Vendedores.Data.Repository;
using Vendedores.Domain.Entidades;
using Vendedores.Domain.Repository;
using Vendedores.Domain.Services;
using Vendedores.Domain.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IVendedoresService, VendedoresService>();
builder.Services.AddScoped<IBaseRepository<Vendedor, VendedorAlteracao>, VendedoresRepository>();
builder.Services.AddScoped<IVendedorDomainService, VendedorDomainService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "ToDo API",
        Description = "Uma Web API ASP.NET Core para gerenciamento de Vendedores de um Marktplace"
    });

    // using System.Reflection;
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

// configuração da coneção com o Banco de Dados (uso do user secrets) 
var mySecret = builder.Configuration["ConnectionStrings:VendedorConnection"];
builder.Services.AddDbContext<DbVendedorContext>
    (options => options.UseSqlServer(mySecret));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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
