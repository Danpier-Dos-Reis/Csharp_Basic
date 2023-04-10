using DAL;
using Microsoft.EntityFrameworkCore;
using WebApiOne.Data;
using WebApiOne.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

//Este servicio es necesario para comunicarnos con la db
builder.Services.AddDbContext<PruebaDBContext>(connstring => connstring.UseSqlServer(DALConnectionString.connstring));

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
