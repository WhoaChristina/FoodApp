using Microsoft.EntityFrameworkCore;
using FoodApp.Models;
using FoodApp.Services.Interfaces;
using FoodApp.Services;
using FoodApp.Repositories.Interfaces;
using FoodApp.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

//Cors
builder.Services.AddCors(option =>
{
    option.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("http://localhost:3000")
        .AllowAnyMethod()
        .AllowAnyHeader();
    });
});

//EF
builder.Services.AddDbContext<RestaurantDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("RestaurantDB"));
});

//Swagger
builder.Services.AddSwaggerGen();


//DI för services
builder.Services.AddTransient<IRestaurantService, RestaurantService>();
builder.Services.AddTransient<IDishesService, DishService>();

//DI för repos
builder.Services.AddTransient<IRestaurantRepo, RestaurantRepo>();
builder.Services.AddTransient<IDishesRepo, DishRepo>();

var app = builder.Build();

app.UseCors();

app.UseRouting();
app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

app.UseSwagger();
app.UseSwaggerUI();

app.Run();
