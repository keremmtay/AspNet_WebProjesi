using Microsoft.AspNetCore.Mvc;
using ViewComponent_10.Models;

namespace ViewComponent_10.ViewComponents
{
    public class KategoriViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            // Burada ilgili kodların olması gerekiyor. Örneğin ViewComponent'in ihtiyacı olan datayı veritabanından alınması gibi... Alınan bu veriyi de View'e parametre olarak veriyoruz.

            List<Kategori> kategoriler = new List<Kategori>()
            {
                new Kategori() {Id=1, KategoriAdi="Elektronik", Aciklama="Elektronik"},
                new Kategori() {Id=2, KategoriAdi="Beyaz Eşya", Aciklama="Beyaz Eşya"},
                new Kategori() {Id=3, KategoriAdi="Giyim", Aciklama="Giyim"},
                new Kategori() {Id=4, KategoriAdi="Yiyecek", Aciklama="Yiyecek"},
            };

            return View(kategoriler);
        }

    }
}



/*
 
            ViewComponent Nedir?
 - PartialView bir data kullanacaksa bu data mutlaka Controller üzerinden gelmek zorunda. Bunun başka bir yolu yok.
 
 - ComponentView ise Controller'ı devreden çıkarır ve kendisine ait olan class/sınıfa gider. Verisini alır ve bunu View'da kullanır.

 - Öncelikli olarak, bu sınıfı oluşturmalıyız. WebUI katmanı içinde ViewComponents isimli bir klasör oluşturuyoruz. Bu klasör içinde de ilgili sınıfı (yeni bir sınıfı) oluşturuyoruz. Class'a bir isim vermeliyiz: Kategori, ismin sonuna da ViewComponent'i ekliyoruz.

 - Daha sonra bu sınıfın ViewComponent olarak çalışabilmesi için bu sınıfın ViewComponent sınıfından türemesi gerekiyor. Yani ViewComponent sınıfını miras alması gerekiyor. (using Microsoft.AspNetCore.Mvc; ekliyoruz.)

 - Bu sınıfın tetiklenebilmesi için içinde bir tane metodu barındırması gerekiyor:

        public IViewComponentResult Invoke()
      {
            return View();
      }
 
 - Metodun geridönüş türü IViewComponentResult olmalı ve Metot adı kesinlikle Invoke() olmalı.

 - İlgili View nerede barındırılacak?

 - 2 farklı yerde konumlandırılabilir. 

 1- Views klasörü altında ilgili Controller klasörünün altında, Components klasörü olmalı. Bu klasörün altında da bu sınıf ismiyle aynı isme sahip bir klasör olmalı. Bu klasörün içine ilgili View'imizi konumlandırıyoruz.

    Views/Home/Components/Kategori/Default.cshtml
 
 2- Shared klasörü altında Components altında, Class ismi ile aynı isimde oluşturulan klasörün içinde ilgili View'i barındırmalıyız.

    Views/Shared/Components/Kategori/Default.cshtml

 - View ismi ne olmalı?
    - Eğer farklı bir isim vermeyeceksek Default ismini kullanabiliriz. Bu durumda bu ismi return View() satırında parametre olarak vermemize gerek kalmayacak.
    - Farklı bir isim vereceksek, bu durumda bu ismi Invoke metodu içinde return View()'de parametre olarak vermeliyiz.

- ComponentView'i kullanmak istediğimizde ilgili View içinde aşağıdaki gibi kullanabiliriz.

@await Component.InvokeAsync("Kategori")

veya

@Component Invoke("Kategori");

 
 */