using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntryTestApp
{
    class StoreItem
    {
        private Item item { get; set; } 
        private int stock { get; set; } // the number at the beginning of the event
        private int sold { get; set; } 

        //copy constructor
        public StoreItem( Item _item, int _stock)
        {
            item = _item;
            stock = _stock;
        }

        //returns the number of the item remaining after sales
        public float ItemsRemaining()
        {
            return (float)(stock - sold);
        }
    }
}
