using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WAD_Assignment1.Models
{
    public class Register
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string FullName { get; set; }
    }
}
