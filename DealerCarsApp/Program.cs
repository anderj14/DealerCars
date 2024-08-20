using DealerCarsApp.Data;
using DealerCarsApp.Interfaces;
using DealerCarsApp.Model;
using DealerCarsApp.Repositories;
using DealerCarsApp.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//Inject Data
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IVehicleRepository, VehicleRepository>();
builder.Services.AddScoped<IBrandRepository, BrandRepository>();
builder.Services.AddScoped<IFuelRepository, FuelRepository>();
builder.Services.AddScoped<IModelRepository, ModelRepository>();
builder.Services.AddScoped<ITrimRepository, TrimRepository>();
builder.Services.AddScoped<IBodyStyleRepository, BodyStyleRepository>();
builder.Services.AddScoped<IDriveTrainRepository, DriveTrainRepository>();
builder.Services.AddScoped<IEngineRepository, EngineRepository>();
builder.Services.AddScoped<IStatusRepository, StatusRepository>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<DataContext>();
    dbContext.Database.Migrate(); // Apply any pending migrations
}

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
