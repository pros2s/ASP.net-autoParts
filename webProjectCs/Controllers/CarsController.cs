using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webProjects.Data.Interfaces;
using webProjects.ViewModels;

namespace webProjects.Controllers {
    public class CarsController : Controller {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iallCars, ICarsCategory iCarsCat) {
            _allCars = iallCars;
            _allCategories = iCarsCat;
        }

        public ViewResult List() {
            ViewBag.title = "AutoParts";
            CarsListViewModel obj = new CarsListViewModel();

            obj.allCars = _allCars.Cars;
            obj.currCategory = "Autos";

            return View(obj);
        }
    }
}
