using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntryTestApp
{
    public class Item
    {
        public string name; // the name of the item
        public float buyPrice; // wholesale price of item
        public float salePrice;// price the item is sold for
        public float proffitPerUnit;

        //copy constructor
        public Item(string _name, float _buyPrice, float _salePrice)
        {
            name = _name;
            buyPrice = _buyPrice;
            salePrice = _salePrice;
            proffitPerUnit = salePrice - buyPrice;
        }
    }
}
