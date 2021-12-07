using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webProjects.Data.Models;

namespace webProjects.ViewModels {
    public class CarsListViewModel {
        public IEnumerable<Car> allCars { get; set; }
        public string currCategory { get; set; }
    }
}
