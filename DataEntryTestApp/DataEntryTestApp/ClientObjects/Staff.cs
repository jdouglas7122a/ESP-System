﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntryTestApp
{
    public class Staff
    {
        public string name { get; }
        private float pay { get; set; } // pounds per hour

        //constructor
        public Staff(string _name, float _pay)
        {
            name = _name;
            pay = _pay;
        }
    }
}