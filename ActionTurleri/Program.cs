
var builder = WebApplication.CreateBuilder(args);

// Yukarýdaki satýr bir WebApplication'ý inþa etmek üzere tanýmlanmýþ bir satýrdýr.
// Bu bölümünde bu uygulamada kullanýlacak olan servisleri projemize dahil ediyoruz. 

builder.Services.AddControllersWithViews();


// Aþaðýdaki satýr ile de yukarýda tanýmladýðýmýz servisler ile uygulamanýn inþa edilmesi yani build edilmesini ya da ayaða kalkmasýný saðlýyoruz.

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


