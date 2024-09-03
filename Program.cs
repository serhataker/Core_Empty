var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
//app.UseWelcomePage();
//app.UseCertificateForwarding();
    app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Anasayfa}");

app.Run();

// Controller:Manage  all program to the at our program and direct
// Action: The main purpose of the action method is to meet HTTP requests and return HTTP responses by completing the necessary operations within the service.
//Model:the model contains the application's data management and transaction rules. It communicates directly with the database and processes business logic.
//It is one of the layers in the MVC architecture and allows pages to be displayed and rendered. The View creates an interface that can be displayed to the user, using the model data sent to it by the Controller.
//Razor: In Razor syntax, the "@" sign is used to insert C# code into the View.
//RazorView is a view engine used in ASP.NET MVC. Razor enables the use of C# or VB.NET codes along with HTML, CSS and JavaScript.
// wwwroot:It contains files that enable the use of basic static objects in the project such as CSS, Javascript or Bootstrap.
//builder.Build():builder.Build() method is used to create the web application instance in ASP.NET Core MVC project
//app.Run() :Allows the application to stand up
