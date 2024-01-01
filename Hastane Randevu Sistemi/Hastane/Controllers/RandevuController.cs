using Hastane.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Hastane.Controllers
{
    public class RandevuController : Controller
    {
        HastaneContext db=new HastaneContext();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(RandevuModel randevu)
        {
            db.Add(randevu);
            db.SaveChanges();
            return RedirectToAction("Index","Home");
        }
    }
}
