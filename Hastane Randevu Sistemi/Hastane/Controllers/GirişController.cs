using Hastane.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hastane.Controllers
{
    public class GirişController: Controller
    {  
        public IActionResult Index()
        {
            return View();
        }
    }
}
