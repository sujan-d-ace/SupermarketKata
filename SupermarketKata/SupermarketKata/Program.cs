using SupermarketKata.Services;
using System;

namespace SupermarketKata
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string items;
            //Console.WriteLine("Scan items");
            //items = Console.ReadLine();

            //var checkout = new Checkout();
            //checkout.Scan(items);

            int isContinue = 1;
            var checkout = new Checkout();
            while (isContinue != 0)
            {
                string item;
                Console.WriteLine("Scan item");
                item = Console.ReadLine();
                Console.WriteLine();

                checkout.Scan(item);

                Console.WriteLine("Do you want to continue Scanning items?");
                isContinue = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            var totalPrice = checkout.GetTotalPrice();
            Console.WriteLine("Total Price for Scanned items = " + totalPrice);
        }
    }
}
