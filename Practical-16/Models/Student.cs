using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practical16.Models
{
    public class Student
    {
        
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "Mobile Number Can't be more than 11 Digits")]
        public string Mobile { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}") ]
        public DateTime? DOB { get; set; }
    }
}
