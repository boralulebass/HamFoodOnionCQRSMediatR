using HamFood.Core.Application.Interfaces;
using HamFood.Core.Application.Services;
using HamFood.Infrastructure.Persistance.Context;
using HamFood.Infrastructure.Persistance.Repositories;
using HamFood.Presentation.UI.Services;
using HamMenu.Core.Application.Mapping;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<HamFoodContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IApiService, ApiService>();
builder.Services.AddAutoMapper(typeof(AutoMapperConfig));
builder.Services.AddApplicationServices();
builder.Services.AddHttpClient();
builder.Services.AddScoped(typeof(ICategoryRepository), typeof(EfCategoryRepository));
builder.Services.AddHttpClient();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
