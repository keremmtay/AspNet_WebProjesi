using Microsoft.AspNetCore.Mvc;

namespace AspNet_WebProjesi.Controllers
{
    public class ProductController : Controller
    {
        // domain/Product/Urunler
        public string Urunler()
        {
            return "bütün ürünler listelendi... Product/Urunler";
        }
        // domain/Product/Index
        public string Index()
        {
            return "Ürünler anasayfası... Product/Index";
        }
        // tarayıcadaki linke verdiğimiz parametre/veri'yi alabilmek için default route ile, oradaki değişken adı ile buradaki ation'daki paramaetre adının aynı olması gerekir.
        // pattern: "{controller=Home}/{action=Index}/{id?}");
        //public string UrunGetir(int id)
        //https//localhost:7176/product/urungetir/22 şeklinde parametreyi ilgili actiona gönderebildiğim gibi
        //https://localhost:7176/product/urungetir?id=55 şeklinde bir link kullnarak da parametreyi ilgili action'a gönderebilirim.
        //domain/controller/action/parametre
        //domain/controller/action?id=55
        public string UrunGetir(int id)
        {
            return $"{id} nolu ürün listelendi..";
        }
        // domain/product/deneme?isim=Ahmet
        public string Deneme(string isim)
        {
            return $"Benim adım {isim}.";
        }
        //domain/product/test?isim=Ahmet&yas=55
        public string Test(string isim, string yas)
        {
            return $"Benim adım {isim} ve yaşım {yas}.";
        }


    }
}
