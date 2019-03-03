using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SieveOfEratosthenes
{
    [TestClass]
    public class PrimeNumberTesting
    {
        [TestMethod]
        public void InitWithNumAndShouldGetRangeOfNumbers()
        {
            var primeNumber = new PrimeNumber(120);

            var initNumbers = primeNumber.InitNumbers;

            CollectionAssert.AreEqual(Enumerable.Range(1, 120).ToList(), initNumbers.ToList());
        }
    }
}
