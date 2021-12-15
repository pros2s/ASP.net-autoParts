using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webProjects.Data.Interfaces;
using webProjects.Data.Models;
using webProjects.ViewModels;

namespace webProjects.Controllers {
    public class CarsController : Controller {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iallCars, ICarsCategory iCarsCat) {
            _allCars = iallCars;
            _allCategories = iCarsCat;
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category) {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";

            if (string.IsNullOrEmpty(category)) {
                cars = _allCars.Cars.OrderBy(i => i.id);
            }
            else {
                if (string.Equals("engine", category, StringComparison.OrdinalIgnoreCase)) {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Двигатель")).OrderBy(i => i.id);
                    currCategory = "Engine parts";
                }
                else if (string.Equals("chassis", category, StringComparison.OrdinalIgnoreCase)) {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Ходовая")).OrderBy(i => i.id);
                    currCategory = "Car chassis parts";
                }
                else if (string.Equals("Interior", category, StringComparison.OrdinalIgnoreCase)) {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Салон")).OrderBy(i => i.id);
                    currCategory = "Сar interior parts";
                }
                else if (string.Equals("body", category, StringComparison.OrdinalIgnoreCase)) {                    
                  cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Кузов")).OrderBy(i => i.id);
                    currCategory = "Car body parts";
                }
            }

            var carObj = new CarsListViewModel {
                allCars = cars,
                currCategory = currCategory
            };

            ViewBag.title = "Mazda car parts";

            return View(carObj);
        }
    }
}
