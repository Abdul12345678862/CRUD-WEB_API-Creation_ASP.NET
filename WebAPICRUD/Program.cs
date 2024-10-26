using Microsoft.EntityFrameworkCore;
using WebAPICRUD.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//**DATABASE CONNECTION 
var provider = builder.Services.BuildServiceProvider(); 
var config = provider.GetRequiredService<IConfiguration>();
builder.Services.AddDbContext<SchoolContext>(item => item.UseSqlServer(config.GetConnectionString("DB-S")));
//***

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
