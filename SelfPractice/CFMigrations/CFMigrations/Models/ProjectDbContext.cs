﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CFMigrations.Models
{
    public class ProjectDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}