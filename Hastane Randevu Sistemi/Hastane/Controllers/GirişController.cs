using System;
using System.Security.Claims;
using Hastane.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;




namespace Hastane.Controllers
{
    public class GirişController : Controller
    {
        HastaneContext db = new HastaneContext();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(KayitModel giris)
        {
            var login = db.Kayit.FirstOrDefault(x => x.Email == giris.Email && x.Password == giris.Password);
            if (login != null)
            {
                return RedirectToAction("Index", "Home");
            }
           
            else
            {
                ViewBag.Result = "Kullanıcı Adı veya Şifre Hatalı";
                return View("Index", "Giriş");
            }

        }
    }
}