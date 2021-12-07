using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webProjects.Data.Interfaces;
using webProjects.Data.Models;

namespace webProjects.Data.Mocks {
    public class MockCars : IAllCars {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {
            get {
                return new List<Car> {
                    new Car {
                        name = "Tesla",
                        shortDesc = "",
                        img = "",
                        price = 45000,
                        available = true,
                        isFavorite = true,
                        Category = _categoryCars.AllCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId) {
            throw new NotImplementedException();
        }
    }
}
