using CustomerRelations.Data;
using Microsoft.EntityFrameworkCore;
using CustomerRelations.Models;
using CustomerRelations.Services;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CustomerRelationsContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<CustomerService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



app.Run();
