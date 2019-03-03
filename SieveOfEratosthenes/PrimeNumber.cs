using System;
using System.Collections.Generic;
using System.Linq;

namespace SieveOfEratosthenes
{
    public class PrimeNumber
    {
        public List<int> RangeNumbers { get; set; }

        public PrimeNumber(int num)
        {
            RangeNumbers = Enumerable.Range(1,num).ToList();
        }

        public IEnumerable<int> GetMultipleOf(int num)
        {
            var enumerator = RangeNumbers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                if (enumerator.Current % num == 0)
                {
                    yield return enumerator.Current;
                }
            }
        }

        public void RemoveNumber(int num)
        {
            RangeNumbers = RangeNumbers.Where(x => x % num != 0).ToList();
        }

        public int GetLastNumber()
        {
            return RangeNumbers.Last();
        }
    }
}