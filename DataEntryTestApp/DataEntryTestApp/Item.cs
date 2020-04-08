using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntryTestApp
{
    class Item
    {
        private string name { get; } // the name of the item
        private float buyPrice { get; } // wholesale price of item
        private float salePrice { get; } // price the item is sold for

        //constructor
        public Item(string _name, float _buyPrice, float _salePrice)
        {
            name = _name;
            buyPrice = _buyPrice;
            salePrice = _salePrice;
        }
    }
}
