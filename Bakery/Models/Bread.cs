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
            int breadPrice = 5 * BreadCount;
            return breadPrice;
        }
        public int BreadDiscount(int breadPrice)
        {
            int discountBread = int(Math.Floor)((double)BreadCost / 3);
            int discountBreadPrice = discountBread * 5;
            int discountedTotal = breadPrice - discountBreadPrice;
            return discountedTotal

        }
    }
}