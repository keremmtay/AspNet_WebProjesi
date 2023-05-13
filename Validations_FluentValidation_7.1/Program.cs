using FluentValidation.AspNetCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddControllersWithViews();

builder.Services.AddControllersWithViews()
    .AddFluentValidation(option =>
    {

        option.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
    });

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Customer}/{action=CreateCustomer}/{id?}");

app.Run();