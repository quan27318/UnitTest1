using UnitTest.Models;
using UnitTest.Responsitory;
using UnitTest.Service;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<PersonDbContext>(
    option => option.UseSqlServer("Server=ADMIN-PC;Initial Catalog=Product;Integrated Security=True")
);
builder.Services.AddTransient<IPersonResponsitory, PersonResponsitory>();
builder.Services.AddTransient<IPerson, PersonServices>();
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
