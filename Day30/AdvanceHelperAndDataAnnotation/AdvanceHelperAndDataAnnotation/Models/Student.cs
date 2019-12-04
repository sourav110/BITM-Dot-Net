using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AdvanceHelperAndDataAnnotation.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter student name")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Name must be 3-10 character long")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter email")]
        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", ErrorMessage ="Please enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please select gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please select department")]
        [DisplayName("Department")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Please enter address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        [StringLength(10, MinimumLength =3, ErrorMessage ="Password must be at least 3 character long")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Re-enter your password")]
        [DisplayName("Confirm Password")]
        [Compare("Password", ErrorMessage ="Password didn't match")]
        public string ConfirmPassword { get; set; }
    }
}