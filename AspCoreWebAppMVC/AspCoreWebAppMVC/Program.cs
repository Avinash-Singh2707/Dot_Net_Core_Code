var builder = WebApplication.CreateBuilder(args);  // creating our web application with createbuilder and store in variable builder

// Add services to the container.
builder.Services.AddControllersWithViews();   // so that our controller and views are working properly

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())   // cheking app environment is suitable for development or not   
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


// Below these are build-in middleware
app.UseHttpsRedirection();
app.UseStaticFiles();   // for static images files

app.UseRouting();

app.UseAuthorization();


// here we are defining Routing Pattern
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
