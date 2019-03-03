using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SieveOfEratosthenes
{
    [TestClass]
    public class PrimeNumberTesting
    {
        private readonly PrimeNumber _primeNumber = new PrimeNumber(_baseNum);
        private static int _baseNum = 120;

        [TestMethod]
        public void InitWithNumAndShouldGetRangeOfNumbers()
        {
            CollectionAssert.AreEqual(
                Enumerable.Range(1, _baseNum).ToList(),
                _primeNumber.RangeNumbers.ToList());
        }

        [TestMethod]
        public void GivenNumberFindTheMultipleOfNumber()
        {
            var baseNum = 2;
            CollectionAssert.AreEqual(
                Enumerable.Range(1, _baseNum).Where(x => x % baseNum == 0).ToList(), 
                _primeNumber.GetMultipleOf(baseNum).ToList());
        }

        [TestMethod]
        public void RemoveListNumberWithGivenBaseNumber()
        {
            var baseNum = 2;
            _primeNumber.RemoveMultipleNumber(baseNum);
            CollectionAssert.AreEqual(
                Enumerable.Range(1, _baseNum).Where(x => x % baseNum != 0 && x != baseNum).ToList(),
                _primeNumber.RangeNumbers);
        }


        [TestMethod]
        public void GetTheLastNumber()
        {
            var lastNumber = _primeNumber.GetLastNumber();
            Assert.AreEqual(
                _baseNum,
                lastNumber);
        }

        [TestMethod]
        public void DetermineLeftoverIsPrimes()
        {
            var baseNum = 2;
            _primeNumber.RemoveMultipleNumber(baseNum);
            Assert.AreEqual(false, _primeNumber.LeftoverIsPrimes(baseNum));
        }

        [TestMethod]
        public void DetermineLeftoverIsPrimes_Ver2()
        {
            var baseNum = 2;
            _primeNumber.RemoveMultipleNumber(baseNum);
            baseNum = 3;
            _primeNumber.RemoveMultipleNumber(baseNum);
            baseNum = 5;
            _primeNumber.RemoveMultipleNumber(baseNum);
            baseNum = 7;
            _primeNumber.RemoveMultipleNumber(baseNum);
            baseNum = 11;
            _primeNumber.RemoveMultipleNumber(baseNum);
            Assert.AreEqual(true, _primeNumber.LeftoverIsPrimes(baseNum));
        }


    }
}
