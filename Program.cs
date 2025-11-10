var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
  app.UseExceptionHandler("/Home/Error");
  app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Auth}/{action=Login}/{id?}");
app.UseRouting();

app.MapControllerRoute(
    name: "Dashboards",
    pattern: "Dashboards/{action=Index}/{id?}",
    defaults: new { controller = "Cars" });

app.MapControllerRoute(
    name: "bills",
    pattern: "bills/{action=Index}/{id?}",
    defaults: new { controller = "Bills" });

app.Run();
