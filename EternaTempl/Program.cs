using EternaTempl.DataAccessLayer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});
var app = builder.Build();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
app.UseStaticFiles();

app.Run();