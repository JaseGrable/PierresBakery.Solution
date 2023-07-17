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
    }
}