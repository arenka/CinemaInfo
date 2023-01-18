using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CinemaInfo.WebUI.Models
{
    public class UserResponseModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
    }
}