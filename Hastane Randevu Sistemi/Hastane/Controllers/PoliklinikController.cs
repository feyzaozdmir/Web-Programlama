using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

public class PoliklinikController : Controller
{
    private List<string> poliklinikListesi = new List<string>
    {
        "Dahiliye", "Göz Hastalıkları", "Ortopedi", "Kardiyoloji",
        "Cildiye", "Nöroloji", "Üroloji", "Psikiyatri","Acil Servis",
        "Beyin ve Sinir Cerrahisi","Çocuk Sağlığı ve Hastalıkları","Dermatoloji",
        "Genel Cerrahi"
        // poliklinik ekle buraya
    };

    public IActionResult Index()
    {
        
        var grupluPoliklinikler = poliklinikListesi
            .OrderBy(poliklinik => poliklinik)
            .GroupBy(poliklinik => poliklinik[0].ToString())
            .ToDictionary(group => group.Key, group => group.ToList());

        return View(grupluPoliklinikler);
    }
}
