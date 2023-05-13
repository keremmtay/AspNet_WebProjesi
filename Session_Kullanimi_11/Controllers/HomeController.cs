using Microsoft.AspNetCore.Mvc;
using Session_Kullanimi_11.Models;
using System.Text.Json;

namespace Session_Kullanimi_11.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Session = oturum anlamına gelmektedir.
            // Session server tabanlı çalışan bir yapı, server üzerinde çalışıyor. Bir veriyi Session'da saklamak istediğimizde, bu veri server tarafında saklanıyor.

            // syntax:
            // HttpContext.Session.SetString("key", veri);    Session'a veri ekleme
            // HttpContext.Session.GetString("key");   Veri okuma

            // String veriyi sessiona ekleme
            HttpContext.Session.SetString("isim", "Mustafa Kavusdu");

            //Sayısal veriyi sessiona ekleme
            HttpContext.Session.SetInt32("yas", 35);

            //Nesneleri session'a ekleme List<T>, kendi oluşturduğumuz sınıflar olabilir.

            Product product = new Product()
            {
                Id = 1,
                Name = "Kırmızı Kalem",
                Description = "Çok güzel bir kırmızı kalem",
            };

            // Bir nesneyi Session'a koymak istiyorsak öncelikle Json'a çevirmemiz gerekecek.

            string jsonUrun = JsonSerializer.Serialize(product);

            // Json string türde olduğu için rahatlıkla Session'a ekleyebiliriz.

            HttpContext.Session.SetString("urun", jsonUrun);

            // Product türündeki bir listi session'a koyalım..

            List<Product> urunler = new List<Product>()
            {
                new Product() {Id = 1,
                Name = "Kırmızı Kalem",
                Description = "Çok güzel bir kırmızı kalem"},
                new Product() {Id = 2,
                Name = "Mavi Kalem",
                Description = "Çok güzel bir mavi kalem"},
                new Product() {Id = 3,
                Name = "Yeşil Kalem",
                Description = "Çok güzel bir yeşil kalem"},
            };

            string jsonUrunler = JsonSerializer.Serialize(urunler);

            HttpContext.Session.SetString("urunler", jsonUrunler);

            return View();
        }

        public string SessionVerisiGor()
        {
            // String veriyi sessiondan okuma
            var sess = HttpContext.Session.GetString("isim");

            return sess;
        }

        public int YasVerisiGor()
        {
            // Sayısal veriyi sessiondan okuma
            int sess = HttpContext.Session.GetInt32("yas").Value;

            return sess*2;
        }

        public string SessiondanUrunAl()
        {
            // Nesne türünde bir veriyi Sessiondan almak istediğimde

            string sess = HttpContext.Session.GetString("urun");

            Product product = JsonSerializer.Deserialize<Product>(sess);

            string sonuc = $"Id: {product.Id} - Name: {product.Name} - Açıklama: {product.Description}";

            return sonuc;
        }

        public IActionResult UrunleriGetir()
        {
            return View();
        }
    }
}
