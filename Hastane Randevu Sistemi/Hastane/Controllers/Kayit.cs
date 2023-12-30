using Hastane.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hastane.Controllers
{
    public class Kayit : Controller
    {
        HastaneContext db=new HastaneContext();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(KayitModel kayit)
        {
            db.Kayit.Add(kayit);
            int veri = db.SaveChanges();
            //if (veri > 0)
            //{
            //    ViewBag.Result = "Kayıt Başarılı";
            //    ViewBag.Status = "success";
            //}
            //else
            //{
            //    ViewBag.Result = "Kayıt Başarısız.. Alanları Doğru Girdiğinizden Emin Olunuz.";
            //    ViewBag.Status = "danger";

            //}

            // Yukarıdaki kodu kullanıcıya gösterebilirsin istersen ama o işin süs tarafı şu an için elzem değil
             

            return RedirectToAction("Index","Home");
        }
    }
}
