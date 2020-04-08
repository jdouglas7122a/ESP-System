using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntryTestApp
{
    class Manager
    {
        private Staff staff;
        public string storeName;

        //constructor
        public Manager(Staff _staff, string _storeName)
        {
            staff = _staff;
            storeName = _storeName;
        }
    }
}
