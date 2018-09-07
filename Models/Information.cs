using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FormPractice.Models
{
    public class Information
    {
        [Required]
        [MinLength(4)]
        [Display(Name = "First Name")] 
        public string FirstName { get; set; }
        [Required]
        [MinLength(4)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Range(0, 123)]
        public int Age { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}