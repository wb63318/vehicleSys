using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using vehicle.api.infrastructure.data;
using vehicle.api.mappingprofile;
using vehicle.api.services.repo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions( x =>
    {
        // serialize enums as strings in api responses (e.g. Role)
        x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    }
    );
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// +db dependency injection
builder.Services.AddDbContext<VehicleDbContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("VehicleSql")));

// +automapper dependency injection
builder.Services.AddAutoMapper(typeof(VehicleMappingProfile));


// +services dependency injections
builder.Services.AddScoped<IVehicleMakeService, VehicleMakeService>();

// +cors implementation
builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(x => x
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());

app.MapControllers();

app.Run();
