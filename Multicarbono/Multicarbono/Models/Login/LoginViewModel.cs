using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.Login
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Username precisa ser preenchido")]
        public string User { get; set; }

        [Required(ErrorMessage = "Password precisa ser preenchido")]
        public string Password { get; set; }

    }
}
