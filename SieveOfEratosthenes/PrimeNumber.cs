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
            RangeNumbers = Enumerable.Range(2,num-1).ToList();
        }

        public List<int> AutoFindPrimes()
        {
            var enumerator = RangeNumbers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                if (!LeftoverIsPrimes(enumerator.Current))
                {
                    RemoveMultipleNumber(enumerator.Current);
                }
            }
            return RangeNumbers;
        }

        public void RemoveMultipleNumber(int num)
        {
            RangeNumbers = RangeNumbers.Where(x => ExceptFirstTime(num, x)).ToList();
        }

        private static bool ExceptFirstTime(int num, int x)
        {
            return x % num != 0 || x == num;
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