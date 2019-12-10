using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniversityProject.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Please enter Department code")]
        [StringLength(7,MinimumLength = 2,ErrorMessage = "Code must be 2-7 character long")]
        [Column(TypeName = "Varchar")]
        [Display(Name = "Department Code")]
        [Remote("IsCodeExits","Department",ErrorMessage = "Department code already exits")]
        public string DepartmentCode { get; set; }

        [Required(ErrorMessage = "Please enter Department Name")]
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        [Display(Name = "Department Name")]
        [Remote("IsNameExists", "Department", ErrorMessage ="Department name already exists")]
        public string DepartmentName { get; set; }
    }
}