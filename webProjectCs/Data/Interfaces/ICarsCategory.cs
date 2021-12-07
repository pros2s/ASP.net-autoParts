using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webProjects.Data.Models;

namespace webProjects.Data.Interfaces {
    interface ICarsCategory {
        IEnumerable<Category> AllCategories { get; }
    }
}
