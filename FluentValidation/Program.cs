using System.Reflection;
using FluentValid;
using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddControllers().AddFluentValidation(c => c.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly()));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EmployeeDbContext>(op =>
{
    op.UseSqlServer(config.GetConnectionString("ConString"));
});

builder.Services.AddScoped<IRepository<Employee>, Repository<Employee>>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
