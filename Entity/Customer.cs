﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Customer
    {
        public int customerId { get; set; }
        public string name { get; set; }

        public string address { get; set; }
        public int phone { get; set; }
        public string active { get; set; }
    }
}
