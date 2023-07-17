using System.Collections.Generic;
using System;

namespace Bakery.Models
{
    public class Pastry
    {
        public int PastryCount { get; }
        public Pastry(int count)
        {
            PastryCount = count;
        }
        public int PastryCost()
        {
            int price = 2 * PastryCount;
            return price;
        }
        public int PastryDiscount(int price)
        {
            int discountPastry = (int)Math.Floor((double)PastryCount / 4);
            int discountedPastryPrice = discountPastry * 2;
            int discountedTotal = price - discountedPastryPrice;
            return discountedTotal;
        }
    }
}