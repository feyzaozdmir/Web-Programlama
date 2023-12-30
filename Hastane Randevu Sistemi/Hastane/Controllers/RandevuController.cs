using Microsoft.AspNetCore.Mvc;

namespace Hastane.Controllers
{
    public class RandevuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
