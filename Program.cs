//Fajar Raja Nico Nainggolan
//2481023
//Framework.NET

using Microsoft.EntityFrameworkCore;
using StudentinformationSystem.Data;

var builder = WebApplication.CreateBuilder(args);

// Register MVC and API controller services.
builder.Services.AddControllersWithViews();

// Configure MySQL database connection.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Missing database connection.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 36))));

var app = builder.Build();

// Configure production error handling.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// Redirect HTTP requests to HTTPS.
app.UseHttpsRedirection();

// Serve static files such as CSS and JavaScript.
app.UseStaticFiles();

// Enable HTTP request routing.
app.UseRouting();

// Enable authorization middleware.
app.UseAuthorization();

// Configure the default MVC route.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Enable attribute-routed API controllers.
app.MapControllers();

// Seed initial student records in Development mode.
if (app.Environment.IsDevelopment())
{
    using var scope = app.Services.CreateScope();
    var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    await StudentSeeder.SeedAsync(db);
}

// Start the application.
app.Run();