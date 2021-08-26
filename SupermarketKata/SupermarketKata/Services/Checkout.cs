using SupermarketKata.Entity;
using SupermarketKata.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;


namespace SupermarketKata.Services
{
    public class Checkout : ICheckout
    {
        public List<Items> Items { get; set; }

        public Checkout()
        {
            Items = new List<Items>();
        }

        public int GetTotalPrice()
        {
            int totalPrice = 0;

            var groupItem = Items.GroupBy(x => x.SKU).ToList();
            
            foreach (var item in groupItem)
            {
                var unitPrice = item.FirstOrDefault().UnitPrice;
                var specialOffer = item.FirstOrDefault().SpecialPrice.Split("for");

                if ( item.FirstOrDefault().SpecialPrice != "" && item.Count() == Convert.ToInt32(specialOffer[0]))
                {
                    totalPrice = totalPrice + Convert.ToInt32(specialOffer[1]);
                } else
                {
                    totalPrice = totalPrice + item.Count() * unitPrice;
                }
            }

            return totalPrice;
        }

        public void Scan(string scannedItems)
        {
            var scannedItemsList = new List<Items>();
            var scannedItemsArrays = scannedItems.Split(" ");

            var items = new Items();
            var itemsList = items.PopulateItems();

            foreach(var itm in scannedItemsArrays)
            {
                var item = itemsList.Where(x => x.SKU == itm).FirstOrDefault();
                scannedItemsList.Add(item);
            }

            Items.AddRange(scannedItemsList);
        }
    }
}
