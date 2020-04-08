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
        public Staff manager;

        //copy constructor
        public Store(string _storeName, List<StoreItem> _inventory, List<Staff> _staffOnduty, Staff _manager)
        {
            storeName = _storeName;
            inventory = _inventory;
            staffOnDuty = _staffOnduty;
            manager = _manager;
        }

        //empty constructor
        public Store(string _storeName)
        {
            storeName = _storeName;
            inventory = new List<StoreItem>();
            staffOnDuty = new List<Staff>();
        }

        //creates store item from item object, adds it to store inventory
        public void AssignInventoryItem(Item _item, int _stock)
        {
            inventory.Add(new StoreItem(_item, _stock));
        }

        //adds single staff members to the store
        public void AssignStaffMember(Staff _staffMember)
        {
            staffOnDuty.Add(_staffMember);
        }

        //adds multiple staff members to the store
        public void AssignMultipleStaff(List<Staff> _staffMembers)
        {
            foreach(Staff staffMember in _staffMembers)
            {
                staffOnDuty.Add(staffMember);
            }
        }

        //assigns manager to store
        public void AssignManager(Staff _staffMember)
        {
            manager = _staffMember;
        }
    }
}
