using System;
using System.Collections.Generic;
using System.Linq;

namespace SieveOfEratosthenes
{
    public class PrimeNumber
    {
        public List<int> InitRange { get; set; }

        public PrimeNumber(int num)
        {
            InitRange = Enumerable.Range(1,num).ToList();
        }

        public int[] GetMultipleOf(int num)
        {
            throw new NotImplementedException();
        }
    }
}