using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webProjects.Data.Models {
    public class Order {
        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime orderTime { get; set; }
        public List<orderDetail> orderDetails { get; set; }

    }
}
