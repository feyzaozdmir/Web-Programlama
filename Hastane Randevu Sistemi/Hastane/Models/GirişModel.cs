﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

public class GirişModel
{
    [Key]
    public string GirisId { get; set; }
    [Required(ErrorMessage = "Email alanı zorunludur.")]
    [EmailAddress(ErrorMessage = "Geçerli bir email adresi giriniz.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Şifre alanı zorunludur.")]
    public string Password { get; set; }
}



