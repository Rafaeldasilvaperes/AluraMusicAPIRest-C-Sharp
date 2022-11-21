
global using AluraMusicAPIRest.DataContext;
using AluraMusicAPIRest.Service.Interfaces;
using AluraMusicAPIRest.Service;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using AluraMusicAPIRest.DAO.Interfaces;
using AluraMusicAPIRest.DAO;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var ConnStringMySQL = builder.Configuration.GetConnectionString("ConnectionMySQL");
builder.Services.AddDbContext<ProductDbContext>(
    options =>
    {
        options.UseMySql(ConnStringMySQL, ServerVersion.Parse("8.0.31"));
    });

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// My Dependency Injections
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductDAO, ProductDAO>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI( options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = "v1/api-doc";
    }
        );
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
