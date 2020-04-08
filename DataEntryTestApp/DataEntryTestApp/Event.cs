using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntryTestApp
{
    class Event
    {
        public string eventID;
        public List<Store> stores;
        public List<Manager> managers;
        public List<Staff> staffMembers;
        public List<Item> eventItems; // base items without stock values assigned
    }
}
