using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Hastane.Models
{
    public class RandevuModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad alanı zorunludur.")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Soyad alanı zorunludur.")]
        public string SoyAd { get; set; }

        [Required(ErrorMessage = "Tarih alanı zorunludur.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString =@"{0:hh\:mm}")]
        public DateTime Saat { get; set; }
        //public IEnumerable<SelectList> SaatSecenekleri { get; set; }

        [Required(ErrorMessage = "Doktor seçimi zorunlu.")]
        public int DoktorId { get; set; }
        [Required(ErrorMessage = "Poliklinik seçimi zorunlu.")]
        public int PoliklinikId { get; set; }

        //public List<SelectListItem> Doktorlar { get; set; }
        //public List<SelectListItem> Poliklinikler { get; set; }
    }
}
