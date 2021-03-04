﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Models
{
    public class ProductViewModel 
    {
        public int Id{ get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public string Name { get; set; }
        public int InventoryValue { get; set; }

        
    }
}
