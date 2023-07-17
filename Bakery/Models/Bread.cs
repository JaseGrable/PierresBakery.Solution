using System.Collections.Generic;
using System;
namespace Bakery.Models

{
    public class Bread
    {
        public int BreadCount { get; }
        public Bread(int count)
        {
            BreadCount = count;
        }
        public int BreadCost()
        {
            int price = 5 * BreadCount;
            return price;
        }
        public int BreadDiscount(int price)
        {
            int discountBread = (int)Math.Floor((double)BreadCount / 3);
            int discountBreadPrice = discountBread * 5;
            int discountedTotal = price - discountBreadPrice;
            return discountedTotal;

        }
    }
}