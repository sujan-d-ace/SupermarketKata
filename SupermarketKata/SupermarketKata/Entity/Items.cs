using System;
using System.Collections.Generic;
using System.Text;

namespace SupermarketKata.Entity
{
    public class Items
    {
        public string SKU { get; set; } // from which items are identified
        
        public int UnitPrice { get; set; } // individual product price

        public string SpecialPrice { get; set; } // special offers : for N no of same items , will cost you Y amount

        public Items()
        {

        }
        public Items(string sku, int unitPrice, string specialPrice)
        {
            SKU = sku;
            UnitPrice = unitPrice;
            SpecialPrice = specialPrice;
        }

        public List<Items> PopulateItems()
        {
            var items = new List<Items>();

            items.Add(new Items("A", 50, "3 for 130"));
            items.Add(new Items("B", 30, "2 for 45"));
            items.Add(new Items("C", 20, ""));
            items.Add(new Items("D", 15, ""));

            return items;
        }
    }
}
