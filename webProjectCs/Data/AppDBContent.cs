using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace webProjects.Data {
    public class AppDBContent : DbContext {
        public AppDBContent(DbContextOptions<AppDBContent>)
    }
}
