using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practical16.Models
{
    public class User : IdentityUser
    {
        [Required]  
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "User Email")]
        public string UserMail { get; set; }

        [Required]
        [Display(Name = "User ID")]
        public string UserID { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
