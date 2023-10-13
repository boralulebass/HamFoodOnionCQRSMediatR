using HamFood.Core.Application.Interfaces;
using HamFood.Core.Application.Services;
using HamFood.Infrastructure.Persistance.Context;
using HamFood.Infrastructure.Persistance.Repositories;
using HamMenu.Core.Application.Mapping;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<HamFoodContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(ICategoryRepository), typeof(EfCategoryRepository));
builder.Services.AddAutoMapper(typeof(AutoMapperConfig));
builder.Services.AddApplicationServices();

builder.Services.AddControllers().AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("HamFood", opts =>
    {
        opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

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
