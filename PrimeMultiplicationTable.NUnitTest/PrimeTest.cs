using NUnit.Framework;
using PrimeMultiplicationTableTDD;
using System;
using System.Collections.Generic;

namespace PrimeMultiplicationTableTest.NUnit
{
    [TestFixture]
    public class PrimeTest
    {
        Prime sutPrimes;  // system under test primes
        List<int> expectedPrimes;  
        List<List<int>> expectedPMTable;
        PrimeMultiplicationTable sutPMTable;  // system under test prime multiplication table

        [OneTimeSetUp]
        public void TestSetUp()
        {
            //arrange
            sutPrimes = new Prime();
            sutPMTable = new PrimeMultiplicationTable();
        }
        
        [Test]
        public void ShouldCheckGreaterThanOneReturnTrueForTwo()
        {
            //act
            bool result = sutPrimes.IsGreaterThanZero(2);
            //assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void ShouldCheckGreaterThanOneReturnFalseForZero()
        {
            //act
            bool result = sutPrimes.IsGreaterThanZero(0);
            //assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void ShouldReturnSevenWhenInputFour()
        {
            
            //act
            Int64 result = sutPrimes.GenerateNthPrime(4);
            //assert
            Assert.AreEqual(result, 7);
        }

        [Test]
        public void ShouldReturnListTwoThreeFiveWhenInputThree()
        {
            expectedPrimes = new List<int>();
            expectedPrimes.Add(2);
            expectedPrimes.Add(3);
            expectedPrimes.Add(5);
            //act
            List<int> res = sutPrimes.GeneratePrimes(7);
            //assert
            CollectionAssert.AreEqual(res, expectedPrimes);
        }

        [Test]
        public void PrimeMultiplicationTest()
        {                                  
            expectedPMTable = new List<List<int>>();
            expectedPMTable.Add(new List<int> { (int)4, (int)6, (int)10, (int)14 });
            expectedPMTable.Add(new List<int> { (int)6, (int)9, (int)15, (int)21 });
            expectedPMTable.Add(new List<int> { (int)10, (int)15, (int)25, (int)35 });
            expectedPMTable.Add(new List<int> { (int)14, (int)21, (int)35, (int)49 });
            // act
            List<int> providedPrimes = new List<int>() { (int)2, (int)3, (int)5, (int)7 };
            List<List<int>> result = sutPMTable.GeneratePrimeMultiplicationTable(providedPrimes);
            //assert
            CollectionAssert.AreEqual(expectedPMTable[0], result[0]);
            CollectionAssert.AreEqual(expectedPMTable[1], result[1]);
            CollectionAssert.AreEqual(expectedPMTable[2], result[2]);
        }

        [OneTimeTearDown]
        public void TestTearDown()
        {
            //dispose
            sutPrimes =null;
            sutPMTable = null;
             
        }

    }
}
