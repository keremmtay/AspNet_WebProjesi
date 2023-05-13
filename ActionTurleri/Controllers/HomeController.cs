using ActionTurleri.Models;
using Microsoft.AspNetCore.Mvc;

namespace ActionTurleri.Controllers
{
    //[NonController]
    public class HomeController : Controller
    {

        // Action Türleri

        // Action: Gelen istekleri Controller içinde karşılayan metotlardır. Metot controller içinde tanımlandığında biz buna Action diyoruz.

        //Geri dönüş tipleri Base Class sayesinde bize sunuluyor...

        #region ViewResult

        // Response olarak bir View dosyasını render etmemizi sağlayan geri dönüş tipidir(Action tipidir.). View cshtml türünde bir dosyadır.

        public ViewResult Index()
        {
            return View();
        }

        #endregion

        #region PartialViewResult

        // bir View dosyasını render etmemizi sağlayan cshtml dosyasıdır.

        // PartialViewResult View içindeki bir bölümü oluşturmak için kullanılır.

        // ViewResult'tan farkı, client tabanlı ajax isteklerinde sıkça kullanılmasıdır. Burada sayfanın tamamı değil sadece ilgili PartialView yenilenir/güncellenir.

        //public PartialViewResult Index()
        //{
        //    return PartialView();
        //}


        #endregion


        #region JsonResult

        // Üretilen veriyi Json formatına dönüştüren ve client'a gönderen yani response eden Action türüdür. Yani elimizdeki veriyi Json formatına döndürür ve gönderir.

        // JsonResult, veriyi Json formatta response olarak gönderiyor.

        //public JsonResult Index()
        //{
        //    JsonResult result = Json(new Product()
        //    {
        //        Id = 1,
        //        Name = "Kirmizi Kalem",
        //        Price = 50
        //    });

        //    return result;
        //}


        #endregion

        #region EmptyResult

        // Bazen gelen istekler doğrultusunda geriye bir şey döndürmek istemeyebiliriz. Bu gibi durumlarda gelen isteği karşılamak için EmptyResult türünde bir Action kullanırız.

        // Gelen Request'e karşılık bir response var ama RESULT yok.

        // void metotlar ile de aynı işi yapabiliriz.

        //public EmptyResult Index()
        //{
        //    return new EmptyResult();
        //}

        #endregion

        #region ContentResult

        // Metinsel bir veri döndürülmek isteniyorsa ContentResult türünde döndürülebilir.

        // Sonuç HTML olarak gelmez. Bir metinsel veri olarak gelir. Yani Text olarak gelir.

        // Metinsel bir veriyi sayfanın bir bölümünde göstermek istersek bunu kullanabiliriz.

        //public ContentResult Index()
        //{
        //    ContentResult result = Content("Bugün Asp.Net Core MVC'de Action Türlerini öğreniyorum..");

        //    return result;
        //}

        #endregion

        #region ActionResult

        // Bütün Result türlerinin atasıdır. Yani base Class'ıdır. Gelen bir istek neticesinde geriye döndürülecek action türleri değişkenlik gösterdiğinde kullanılabilir.

        //public ActionResult Index() 
        //{ 
        //    // Gelen istek sonucunda bir takım işlemler yapılır if ile for ile falan sonrasında duruma göre geriye bir result döndürülür. (Json, Content, Empty, Partial vb...)

        //    if (true)
        //    {
        //        ContentResult result = Content("Bugün Asp.Net Core MVC'de Action Türlerini öğreniyorum..");

        //        return result;
        //    }
        //    else if (false) 
        //    {
        //        return new EmptyResult();
        //    }
        //    else if (false)
        //    {
        //        JsonResult result = Json(new Product()
        //        {
        //            Id = 1,
        //            Name = "Kirmizi Kalem",
        //            Price = 50
        //        });

        //        return result;
        //    }

        //    return View();
        //}

        #endregion

        #region IActionResult

        // IActionResult ise ActionResult'un interface'idir.

        //public IActionResult Index()
        //{ 
        //    return View();        
        //}

        #endregion

        #region NonAction

        // [NonAction] olarak işaretlenen bir metot artık action gibi istek alamayacaktır.

        // Bu metotları daha çok diğer actionlardan çağırarak bir iş yapması için oluştururuz.

        // [NonAction] olarak işaretlemezsek bu metot da bir action gibi çalışmaya devam edecektir.

        //[NonAction]
        //public string ActionDegil()
        //{
        //    return "burası ActionDegil metodu";
        //}

        #endregion

        #region NonController

        // Bir Controller [NonController] olarak işaretlenmişse artık o Controller bir class gibi çalışmaya başlayacak ve istek kabul etmeyecektir.

        // Bu kodun en başında tanımlanır.

        #endregion









    }
}
