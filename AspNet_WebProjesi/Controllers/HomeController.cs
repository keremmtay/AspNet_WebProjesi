using Microsoft.AspNetCore.Mvc;

namespace AspNet_WebProjesi.Controllers
{
    public class HomeController : Controller
    {
        // Bir Class'ın Controller olarak çalışması için yani gelen requestleri karşılayabilmesi için mutlaka Controller sınıfından türemesi gerekir.
        //action dediğimizde Controller içindeki metotlar olarak bileceğiz.
        // 
        public string Index()
        {
            return "Merhaba. Burası HomeController içindeki Index Metodu..";
        }

        // domainAdi/controller/action
        //https//localhost:7176/home/merhaba
        public string Merhaba()
        {
            return "Merhaba NA203 Akşam sınıfı";
        }


    }
}
