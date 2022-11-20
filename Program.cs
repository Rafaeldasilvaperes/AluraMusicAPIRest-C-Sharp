
using AluraMusicAPIRest.Service.Interfaces;
using AluraMusicAPIRest.Service;
using AluraMusicAPIRest.Data;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using AluraMusicAPIRest.DAO.Interfaces;
using AluraMusicAPIRest.DAO;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var ConnStringMySQL = builder.Configuration.GetConnectionString("ConnectionMySQL");
builder.Services.AddDbContext<DbContext>(
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
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
