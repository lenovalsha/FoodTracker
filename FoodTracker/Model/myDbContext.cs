﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTracker.Model
{
     class myDbContext : DbContext
    {
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Food> Foods { get; set; }
    }
}
