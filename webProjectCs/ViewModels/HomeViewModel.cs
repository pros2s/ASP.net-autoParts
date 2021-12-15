using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webProjects.Data.Models;

namespace webProjects.ViewModels {
    public class HomeViewModel {
        public IEnumerable<Car> favCars { get; set; }
    }
}
