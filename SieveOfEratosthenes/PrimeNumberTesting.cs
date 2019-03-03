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
        private int _end = _baseNum-1;
        private int _start = 2;

        [TestMethod]
        public void InitWithNumAndShouldGetRangeOfNumbers()
        {
            CollectionAssert.AreEqual(
                Enumerable.Range(_start, _end).ToList(),
                _primeNumber.RangeNumbers.ToList());
        }

        [TestMethod]
        public void GivenNumberFindTheMultipleOfNumber()
        {
            var baseNum = 2;
            CollectionAssert.AreEqual(
                Enumerable.Range(_start, _end).Where(x => x % baseNum == 0).ToList(), 
                _primeNumber.GetMultipleOf(baseNum).ToList());
        }

        [TestMethod]
        public void RemoveListNumberWithGivenBaseNumber()
        {
            var baseNum = 2;
            _primeNumber.RemoveMultipleNumber(baseNum);
            CollectionAssert.AreEqual(
                Enumerable.Range(_start, _end).Where(x => x % baseNum != 0 || x == baseNum).ToList(),
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

        [TestMethod]
        public void AutoFindPrimeNumber()
        {
            var actual = _primeNumber.AutoFindPrimes();
            CollectionAssert.AreEqual(new List<int>{2,3,5,7,11,13,17,19,23,29,31,37,41,43,47,53,59,61,67,71,73,79,83,89,97,101,103,107,109,113}, actual);
        }

    }
}
