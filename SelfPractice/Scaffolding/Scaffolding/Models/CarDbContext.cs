﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Scaffolding.Models
{
    public class CarDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
}