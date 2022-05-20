using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_16.Models
{
    public class User
    {
        [Key]
        [Required]
        [Display(Name = "First_Name")]
        public string Firstname { get; set; }


        [Required]
        [Display(Name = "Last_Name")]
        public string Lastname { get; set; }

    }
}
