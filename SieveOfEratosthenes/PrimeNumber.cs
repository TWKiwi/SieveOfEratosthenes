using System;
using System.Collections.Generic;
using System.Linq;

namespace SieveOfEratosthenes
{
    public class PrimeNumber
    {
        public List<int> InitNumbers { get; set; }

        public PrimeNumber(int num)
        {
            InitNumbers = Enumerable.Range(1,num).ToList();
        }
    }
}