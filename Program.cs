var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); // Ensure MVC is enabled

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Explicitly define custom routes
app.UseEndpoints(endpoints =>
{
    // Default MVC Route
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    // Custom route to make /About work
    endpoints.MapControllerRoute(
        name: "AboutPage",
        pattern: "About",
        defaults: new { controller = "Home", action = "About" });
});

app.Run();
