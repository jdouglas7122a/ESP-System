using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntryTestApp
{

    //This class is used for testing when lacking a connection, only for viewing.
    class NoNetworkEvent
    {
        public Event tempEvent = new Event("Veggie Traders Ltd, Big Broccoli Blow out");

        //creates a local event that doesnt use the network for demonstration purposes
        public NoNetworkEvent()
        {
            List<Item> itemList = new List<Item>() { new Item("banana", 0.90f, 2.50f),
                                                     new Item("pumpkin", 1f, 5.40f),
                                                     new Item("carrot", 0.2f, 0.8f)};
            List<Staff> staffList = new List<Staff>() { new Staff("Chuck", 8.50f),
                                                        new Staff("Arnold", 12.50f) };
            List<Store> storeList = new List<Store>()
            {
                new Store("Pie Filling Store",
                    new List<StoreItem>(){new StoreItem(itemList[0], 2, 1),
                                            new StoreItem(itemList[1], 15, 10),
                                            new StoreItem(itemList[2], 34, 12)},
                    new List<Staff>() { staffList[0] },
                    staffList[1]),
                new Store("Salads R' Us",
                    new List<StoreItem>(){new StoreItem(itemList[0], 15, 10),
                                            new StoreItem(itemList[1], 50, 35),
                                            new StoreItem(itemList[2], 200, 167)},
                    new List<Staff>() { staffList[0] },
                    staffList[1])
            };

            tempEvent.stores = storeList;
            tempEvent.eventItems = itemList;
            tempEvent.staffMembers = staffList;
        }
    }
}
