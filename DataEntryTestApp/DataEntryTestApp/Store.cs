using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntryTestApp
{
    class Store
    {
        public string storeName;
        public List<StoreItem> inventory;
        public List<Staff> staffOnDuty;
        public Manager manager;

        //constructor
        public Store(string _storeName, List<StoreItem> _inventory, List<Staff> _staffOnduty, Manager _manager)
        {
            storeName = _storeName;
            inventory = _inventory;
            staffOnDuty = _staffOnduty;
            manager = _manager;
        }
    }
}
