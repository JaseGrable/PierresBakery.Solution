using System;
using System.Collections.Generic;
using Bakery.Models;


namespace Bakery
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
            Console.WriteLine("Welcome to Pierre's Bakery!");
            Console.WriteLine("Please tell us how many loaves of bread you would like and we'll get your order to your shortly.");
            Console.WriteLine("Bread loaves cost $5 each");
            Console.WriteLine("Pastries are $2 each");
            Console.WriteLine("Remember! Buy 2 loaves of bread, get 1 free & Buy 3 pastries get 1 free");
            int discountBreadPrice = Bread();
        }
        static int Bread()
        {
            Console.WriteLine("Bread Loaves $5 each, please enter how many loaves you would like");
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out int BreadCount))
            {
                Bread breadOrder = new Bread(BreadCount);
                int breadPrice = breadOrder.BreadCost();
                int discountBreadPrice = breadOrder.BreadDiscount(breadPrice);
                Console.WriteLine("$" + discountBreadPrice);
                return discountBreadPrice;
            }
            else
            {
                Console.WriteLine("Please enter a number");
                return Bread();
            }
        }
    }
}