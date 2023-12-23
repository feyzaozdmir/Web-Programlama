using Hastane.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Hastane.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserModel model)
        {
            // Kayıt işlemleri burada gerçekleştirilebilir
            // Örneğin, veritabanına kullanıcı bilgilerini kaydetmek

            return RedirectToAction("Index");
        }
    }
}
