using System.ComponentModel.DataAnnotations;

namespace Hastane.Models
{
    public class UserModel
    {
        
        [Required(ErrorMessage = "Kullanıcı adı zorunludur.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre zorunludur.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

