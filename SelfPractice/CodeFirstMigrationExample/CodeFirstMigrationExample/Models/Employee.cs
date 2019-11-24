using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstMigrationExample.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Please Enter Employee Name")]
        [StringLength(50)]
        [Display(Name ="Employee Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please Enter Department Name")]
        [StringLength(20)]
        public string Department { get; set; }

        [Required(ErrorMessage ="Please Enter Email")]
        [Column(TypeName = "varchar")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Please Enter Employee salary")]
        public double Salary { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [StringLength(10, MinimumLength = 5, ErrorMessage ="Password should be at least 5 charachers")]
        [Column(TypeName ="varchar")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter Employee name")]
        [Compare("Password", ErrorMessage ="Password Didn't match")]
        [Display(Name = "Confirm Password")]
        [NotMapped]
        public string ConfirmPassword { get; set; }
    }
}