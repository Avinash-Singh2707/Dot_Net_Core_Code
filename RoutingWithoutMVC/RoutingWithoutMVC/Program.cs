var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();   // Adding Service Registration

var app = builder.Build();



//app.MapGet("/", () => "Hello World!");

//app.MapDefaultControllerRoute();   // by default Home controller -> Index method will be called

// -> CONVENTIONAL BASED ROUTING

//app.MapControllerRoute(
//    name: "default",             // You can give any name
//    pattern: "{controller=Home}/{action=Index}/{id?}"    // Here defining pattern of URL -> Conventional Based Routing, id is optional but controller and action method is mandatory
//    );

//-> ATTRIBUTE BASED ROUTING

app.MapControllers();  // by using this middleware we are going to use attribute based routing


app.Run();
