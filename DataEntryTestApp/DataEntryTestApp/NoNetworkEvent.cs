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
            List<Item> itemList = new List<Item>() { new Item("Banana", 0.90f, 2.50f), new Item("Apple", 0.2f, 0.3f),
                                                     new Item("Pumpkin", 1f, 5.40f), new Item("Orange", 0.3f, 0.4f),
                                                     new Item("Carrot", 0.2f, 0.8f), new Item("Tomato", 0.8f, 0.85f),
                                                     new Item("Avacado", 0.6f, 1.4f), new Item("Hemp", 3.2f, 5.4f),
                                                     new Item("Tofu", 0.3f, 3.2f), new Item("Potato", 0.1f, 0.3f),
                                                     new Item("Leek", 0.5f, 0.9f), new Item("Corriander", 0.3f, 2.01f)};

            List<Staff> staffList = new List<Staff>() { new Staff("Chuck Norland", 8.50f), new Staff("Ryan Heyes", 13.23f),
                                                        new Staff("Arnold Grey", 12.50f), new Staff("David Hoppers", 8.50f),
                                                        new Staff("Jim Davies", 8.50f), new Staff("Timmothy Hollands", 8.50f)};

            List<Store> storeList = new List<Store>()
            {
                new Store("Pie Filling Store",
                    new List<StoreItem>(){new StoreItem(itemList[1], 15, 8),
                                            new StoreItem(itemList[9], 46, 45),
                                            new StoreItem(itemList[10], 34, 24)},
                    new List<Staff>() { staffList[0] },
                    staffList[1]),

                new Store("Salads R' Us",
                    new List<StoreItem>(){new StoreItem(itemList[4], 120, 95),
                                            new StoreItem(itemList[5], 30, 15),
                                            new StoreItem(itemList[6], 43, 10),
                                            new StoreItem(itemList[8], 130, 56),
                                            new StoreItem(itemList[10], 56, 32),
                                            new StoreItem(itemList[11], 94, 30)},
                    new List<Staff>() { staffList[3], staffList[4], staffList[5] },
                    staffList[2])
            };

            tempEvent.stores = storeList;
            tempEvent.eventItems = itemList;
            tempEvent.staffMembers = staffList;
        }
    }
}
