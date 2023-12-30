using System;
using Hastane.Models;
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
        public IActionResult Index(GirişModel giris)
        {
            var login = db.Giris.FirstOrDefault(x => x.Email == giris.Email && x.Password == giris.Password);
            //if (login != null)
            //{
            //    return RedirectToAction("Index", "Home");
            //}
            //else
            //{
            //    ViewBag.Result = "Kullanıcı Adı veya Şifre Hatalı";
            //    return View("Index", "Giriş");
            //}
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Index(GirişModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        // Burada gerçek kimlik doğrulama işlemleri gerçekleştirilecek
        //        // Bu örnekte sadece basit bir kontrol yapılıyor

        //        // Örneğin: Veritabanında kullanıcı adı ve şifreyi kontrol et
        //        if (model.Email == "example@example.com" && model.Password == "password")
        //        {

        //            // Kimlik doğrulama başarılı ise, gerekli işlemleri yapabilirsiniz
        //            return RedirectToAction("Index", "Home"); // Örneğin Ana sayfaya yönlendirme
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", "Geçersiz kullanıcı adı veya şifre.");
        //            ModelState.AddModelError(string.Empty, "Giriş başarısız. Lütfen geçerli bir e-posta ve şifre girin.");
        //        }
        //    }

        //    // Model geçerli değilse, sayfayı tekrar göster
        //    return View(model);
        //}

        //public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        //{
        //    returnUrl ??= Url.Content("~/");

        //    ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

        //    if (ModelState.IsValid)
        //    {
        //        // This doesn't count login failures towards account lockout
        //        // To enable password failures to trigger account lockout, set lockoutOnFailure: true
        //        var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: false);
        //        if (result.Succeeded)
        //        {
        //            _logger.LogInformation("User logged in.");
        //            return LocalRedirect(returnUrl);
        //        }
        //        if (result.RequiresTwoFactor)
        //        {
        //            return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
        //        }
        //        if (result.IsLockedOut)
        //        {
        //            _logger.LogWarning("User account locked out.");
        //            return RedirectToPage("./Lockout");
        //        }
        //        else
        //        {
        //            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
        //            return View(model);
        //        }
        //    }

        //    // If we got this far, something failed, redisplay form
        //    return View("Index");
        //}
    }
}