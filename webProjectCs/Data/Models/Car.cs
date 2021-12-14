﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webProjects.Data.Models {
    public class Car {
        public int id { set; get; }
        public string name { set; get; }
        public string shortDesc { set; get; }
        public string longDesc { set; get; }
        public string img { set; get; }
        public ushort price { set; get; }
        public bool isFavorite { set; get; }
        public string manufacturer { set; get; }
        public string durability { set; get; }
        public virtual Category Category { set; get; }
    }
}
