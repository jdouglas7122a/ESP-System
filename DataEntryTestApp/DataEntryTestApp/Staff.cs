using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntryTestApp
{
    class Staff
    {
        public string name { get; }
        private float pay { get; set; } // pounds per hour
        public float salesTotal { get; set; }

        //constructor
        public Staff(string _name, float _pay, float _salesTotal)
        {
            name = _name;
            pay = _pay;
            salesTotal = _salesTotal;
        }
    }
}
