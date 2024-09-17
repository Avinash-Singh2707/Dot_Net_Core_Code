var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();    // we get all the setting of controller and views
var app = builder.Build();

app.UseStaticFiles();  // (To access client-side library)/To run static files in wwwroot
//app.MapGet("/", () => "Hello World!");

app.MapControllerRoute(
    name:"default",
    pattern:"{controller=Home}/{action=Index}/{id?}"
    );

app.Run();
