using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CinemaInfo.WebUI.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Kullanıcı Epostanızı Giriniz.")]
        [RegularExpression("^[\\w-\\.]+@([\\w -]+\\.)+[\\w-]{2,4}$", ErrorMessage = "Kullanıcı Epostanızı Uygun Formatta Giriniz.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Kullanıcı Şifrenizi Giriniz.")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Kullanıcı Şifrenizi Uygun Formatta Giriniz.")]
        public string Password { get; set; }
    }
}