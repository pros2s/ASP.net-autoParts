using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webProjects.Data.Models {
    public class Order {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Имя")]
        [StringLength(25)]
        public string Name { get; set; }

        [Display(Name = "Фамилия")]
        [StringLength(25)]
        public string Surname { get; set; }

        [Display(Name = "Адрес")]
        [StringLength(35)]
        public string Adress { get; set; }

        [Display(Name = "Номер телефона")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10)]
        public string Phone { get; set; }

        [Display(Name = "Email адрес")]
        [DataType(DataType.EmailAddress)]
        [StringLength(15)]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<orderDetail> orderDetails { get; set; }

    }
}
