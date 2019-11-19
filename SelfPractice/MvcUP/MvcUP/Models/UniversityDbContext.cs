using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcUP.Models
{
    public class UniversityDbContext : DbContext 
    {
        public DbSet<Department> Departments { get; set; } 
    }
}