var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//app.Map("/Home", () => "Hello World!");             // Map methods is going work with all kind of HTTPS methods

// enpoints is parameters
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/Home", async (context) =>
    {
        // Request delegates in curly braces
        await context.Response.WriteAsync("This is HOME Page -GET" );        // In this we can write multiple lines
    });
    endpoints.MapPost("/Home", async (context) =>
    {
        // Request delegates in curly braces
        await context.Response.WriteAsync("This is HOME Page - POST");        // In this we can write multiple lines
    });
});

// In above middleware MapGet() we pass URL and request delegates
// When our First time application is runing there is root element forward slash "/" 
app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Page not Found");
});



// mapget,mapput,mapdelete,mapput :- 
//  These middleware is used when we want to apply specific logic on specific URL like GET,POST,PUT,DELETE





//app.MapGet("/Home", () => "Hello World! -> GET");  // For any specific URL -> specific HTTP methods we can use Mapget() 








app.Run();
