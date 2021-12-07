using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webProjects.Data.Interfaces;
using webProjects.Data.Models;

namespace webProjects.Data.Mocks {
    public class MockCategory : ICarsCategory {
        public IEnumerable<Category> AllCategories {
            get {
                return new List<Category> {
                    new Category {
                        categoryName = "Electro",
                        desc = "Modern"
                    },
                    new Category {
                        categoryName = "Classic",
                        desc = "internal combustion"
                    }
                };
            }
        }
    }
}
