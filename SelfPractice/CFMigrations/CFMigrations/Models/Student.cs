using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CFMigrations.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage ="Please enter name")]
        public string StudentName { get; set; }

        [Required(ErrorMessage ="Please enter email")]
        [Column(TypeName="varchar")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Please enter reg no")]
        [DisplayName("Registration No.")]
        public string RegNo { get; set; }

        [Required(ErrorMessage ="Please enter department")]
        public string Department { get; set; }

        [Range(18,99)]
        public int Age { get; set; }

        [Required(ErrorMessage ="Please enter password")]
        [MinLength(5)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        [Compare("Password", ErrorMessage ="Password didn't match")]
        [DisplayName("Confirm Password")]
        [NotMapped]
        public string ConfirmPassword { get; set; }
    }
}