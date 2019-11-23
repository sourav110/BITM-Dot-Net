using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAnnotationCodeFirst.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Please Enter Department Name")]
        [StringLength(10, MinimumLength =2, ErrorMessage = "Department code should be in range between 3 and 10")]
        [Display(Name = "Department Code")]
        public string DepartmentCode { get; set; }

        [Required(ErrorMessage = "Please Enter Department Name")]
        [StringLength(50)]
        [Display(Name = "Department Name")]
        public string DepartmentName { get; set; }
    }
}