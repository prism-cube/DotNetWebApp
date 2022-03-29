using Microsoft.EntityFrameworkCore;
using DotNetWebApp.Data;
using DotNetWebApp.Repositories;
using DotNetWebApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DatabaseContext>(options => options.UseInMemoryDatabase("DotNetWebAppDB"));

builder.Services.AddScoped<TodoService>();

builder.Services.AddScoped<TodoRepository>();

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

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

// app.UseAuthorization();

// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller=Home}/{action=Index}/{id?}");

// DatabaseContextのOnModelCreatingを実行
using IServiceScope scope = app.Services.CreateScope();
IServiceProvider provider = scope.ServiceProvider;
using var context = provider.GetRequiredService<DatabaseContext>();
await context.Database.EnsureCreatedAsync();

app.Run();

