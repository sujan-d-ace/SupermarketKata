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
            string item;
            var checkout = new Checkout();
            while (isContinue != 0)
            {                
                Console.WriteLine("Scan item");
                item = Console.ReadLine();
                Console.WriteLine();

                checkout.Scan(item.ToUpper());
                
                begin:
                Console.WriteLine("Press Any number ---> continue scan item");
                Console.WriteLine("0 ---> end scan item");
                Console.WriteLine("Do you want to continue Scanning items?");
                try
                {
                    isContinue = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Wrong Input!!! Try Again!");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine();
                    goto begin;
                }                                       
                
                Console.WriteLine();
            }

            var totalPrice = checkout.GetTotalPrice();
            Console.WriteLine("Total Price for Scanned items = " + totalPrice);
        }
    }
}
