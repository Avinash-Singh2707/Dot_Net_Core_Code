var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");    // when our application run simple forward slash root -> Callback funtions


// To define middleware we use run() method

// To handle httprequest we are using context paramters we can say also http context.
// Custom Middleware -> Order is very important -> FIFO

//app.Run(async (context) => 
//{
//    await context.Response.WriteAsync("Welcome to ASP.Net CORE 8 ");
//});

// run method will never execute subsequent middleware if we want to multiple middleware so define your middleware using use() method 
// becuase we can pass next parameter and in run method we pass only one parameter


app.Use(async (context,next) =>
{
    await context.Response.WriteAsync("Welcome to ASP.Net CORE 6 ");
    await next (context);  // transfering our request to our next middleware so that next middleware has also access to HTTP context
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Welcome to ASP.Net CORE 8 ");
});

// next is basically a request delegate that is generally used to execute our next middlewares

app.Run();   // this line is used to run our server and our application is hosted on that server.
