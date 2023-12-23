using Hastane.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Hastane.Controllers
{
    public class IletisimController : Controller
    {
        public IActionResult Index() {
            ViewBag.CurrentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            return View(); 
        }
    }

}
