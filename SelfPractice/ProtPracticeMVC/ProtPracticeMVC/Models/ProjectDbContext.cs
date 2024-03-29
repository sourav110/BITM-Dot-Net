﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ProtPracticeMVC.Models
{
    public class ProjectDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Semester> Semesters { get; set; }
    }
}