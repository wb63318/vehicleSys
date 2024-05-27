using Microsoft.EntityFrameworkCore;
using vehicle.api.infrastructure.data;
using vehicle.api.mappingprofile;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// +db dependency injection
builder.Services.AddDbContext<VehicleDbContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("VehicleSql")));

// +automapper dependency injection
builder.Services.AddAutoMapper(typeof(VehicleMappingProfile));


// +services dependency injections

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
