﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webProjects.Data.Interfaces;
using webProjects.Data.Models;

namespace webProjects.Data.Repository {
    public class CategoryRepository : ICarsCategory {
        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent appDBContent) {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
