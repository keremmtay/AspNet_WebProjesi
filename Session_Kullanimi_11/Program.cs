var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// Session

builder.Services.AddSession(option => {
    option.IdleTimeout = TimeSpan.FromMinutes(10);  // 10 dakika olarak ayarlandý. Default  timeout 20dk
});

builder.Services.AddHttpContextAccessor();

var app = builder.Build();

app.UseSession();   // Session artýk uygulamada kullanýlabilir
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();