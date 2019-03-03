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

        public void RemoveMultipleNumber(int num)
        {
            RangeNumbers = RangeNumbers.Where(x => x % num != 0 && x != num).ToList();
        }

        public int GetLastNumber()
        {
            return RangeNumbers.Last();
        }

        public bool LeftoverIsPrimes(int baseNum)
        {
            return Math.Pow(baseNum, 2) >= GetLastNumber();
        }
    }
}