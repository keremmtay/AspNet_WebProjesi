var builder = WebApplication.CreateBuilder(args);
// Yukar�daki sat�r bir WebApplication'� in�a etmek �zere tan�mlanm�� bir sat�rd�r.
// Bu b�l�m�nde bu uygulamada kullan�lacak olan servisleri projemize dahil ediyoruz. 

builder.Services.AddControllersWithViews();


// A�a��daki sat�r ile de yukar�da tan�mlad���m�z servisler ile uygulaman�n in�a edilmesi yani build edilmesini ya da aya�a kalkmas�n� sa�l�yoruz.
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


// certmgr.msc sertifikalardan dolay� �al��mazsa, gir ve ilk 2 k�s�mdaki local host olanlar� sil, visual studio ba�tan a��p dene