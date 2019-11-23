using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DataAnnotationCodeFirst.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required(ErrorMessage ="Please Enter Student Name")]
        [StringLength(50)]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }

        [Required(ErrorMessage ="Please Enter Registration No.")]
        [Display(Name = "Registration No.")]
        public string RegNo { get; set; }

        [Required(ErrorMessage ="Please Enter Age")]
        [Range(18,99, ErrorMessage ="Invalid Range")]
        public int Age { get; set; }

        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        [Display(Name = "Department Id")]
        public virtual Department Department { get; set; }
    }
}