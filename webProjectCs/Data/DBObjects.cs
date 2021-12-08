using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webProjects.Data.Models;

namespace webProjects.Data {
    public class DBObjects {
        public static void Initial(AppDBContent content) {

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any()) {
                content.AddRange(
                    new Car {
                        name = "Tesla",
                        shortDesc = "",
                        img = "",
                        price = 45000,
                        available = true,
                        isFavorite = true,
                        Category = Categories["Electro"]
                    }
                );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories {
            get {
                if (category == null) {
                    var list = new Category[] {
                        new Category {
                            categoryName = "Electro",
                            desc = "Modern"
                        },
                        new Category {
                            categoryName = "Classic",
                            desc = "internal combustion"
                        }
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category element in list)
                        category.Add(element.categoryName, element);
                }

                return category;
            }
        }
    }
}
