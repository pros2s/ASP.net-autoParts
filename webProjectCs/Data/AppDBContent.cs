﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webProjects.Data.Models;

namespace webProjects.Data {
    public class AppDBContent : DbContext {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) {

        } 

        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
