using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SieveOfEratosthenes
{
    [TestClass]
    public class PrimeNumberTesting
    {
        private readonly PrimeNumber _primeNumber = new PrimeNumber(120);

        [TestMethod]
        public void InitWithNumAndShouldGetRangeOfNumbers()
        {
            CollectionAssert.AreEqual(
                Enumerable.Range(1, 120).ToList(),
                _primeNumber.InitRange.ToList());
        }

        [TestMethod]
        public void GivenNumberFindTheMultipleOfNumber()
        {
            CollectionAssert.AreEqual(
                Enumerable.Range(1, 120).Select(x =>x*2).ToList(), 
                _primeNumber.GetMultipleOf(2).ToList());
        }
    }
}
