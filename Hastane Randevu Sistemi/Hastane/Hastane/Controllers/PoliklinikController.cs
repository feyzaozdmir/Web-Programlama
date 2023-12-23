using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class PoliklinikController : Controller
{
    private List<string> poliklinikListesi = new List<string>
    {
        "Dahiliye", "Göz Hastalıkları", "Ortopedi", "Kardiyoloji",
        "Cildiye", "Nöroloji", "Üroloji", "Psikiyatri","Acil Servis",
        "Beyin ve Sinir Cerrahisi","Çocuk Sağlığı ve Hastalıkları","Dermatoloji",
        "Genel Cerrahi","Aferez","Ağız ve Diş Sağlığı","Alerji ve İmmünoloji","Algoloji (Ağrı Polikliniği)",
        "Anestezi ve Reanimasyon","Beslenme ve Diyet","Biyokimya Laboratuvarı","Böbrek Nakli","Check-up",
        "Çocuk Alerjisi","Çocuk Cerrahisi","Çocuk Endokrinolojisi","Çocuk Gastroenteroloji","Çocuk Gelişim Danışmanı",
        "Çocuk Hematolojisi ve Onkolojisi","Çocuk Kardiyolojisi","Çocuk Kardiyovasküler Cerrahisi","Çocuk Nefrolojisi",
        "Çocuk Nörolojisi","Çocuk Psikoloji","Çocuk Romatolojisi","Çocuk ve Ergen Psikiyatrisi","Dil ve Konuşma Terapisi",
        "Diyaliz","El Cerrahisi ve Mikro Cerrahi","Endokrinoloji ve Metabolizma Hastalıkları","Enfeksiyon Hastalıkları",
        "Fizik Tedavi ve Rehabilitasyon","Havacılık Tıp Merkezi","Hematoloji","Hemodiyaliz","İç Hastalıkları","Jinekolojik Onkoloji",
        "Kadın Hastalıkları ve Doğum","Laboratuvar","Mikrobiyoloji","Radyasyon Onkolojisi","Radyoloji","Tüp Bebek","Uyku Laboratuvarı"
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
