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

        public IEnumerable<int> GetMultipleOf(int num)
        {
            var enumerator = InitRange.GetEnumerator();
            while (enumerator.MoveNext())
            {
                if (enumerator.Current % num == 0)
                {
                    yield return enumerator.Current;
                }
            }
        }
    }
}