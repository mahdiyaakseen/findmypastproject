using NUnit.Framework;
using PrimeMultiplicationTableTDD;
using System;
using System.Collections.Generic;

namespace PrimeMultiplicationTableTest.NUnit
{
    [TestFixture]
    public class PrimeTest
    {
        PrimeGenerator sutPrimes;  // system under test primes
        PrimeMultiplicationTableGenerator sutPMTable;  // system under test prime multiplication table
        List<int> expectedPrimes;
        List<List<int>> expectedPMTable;
  
        [OneTimeSetUp]
        public void TestSetUp()
        {
            //arrange
            sutPrimes = new PrimeGenerator();
            sutPMTable = new PrimeMultiplicationTableGenerator();
        }

        [Test]
        public void PrimeGeneratorTest1()
        {

            //act
            int result = sutPrimes.GenerateNthPrime(4);
            //assert
            Assert.AreEqual(result, 7);
        }

        [Test]
        public void PrimeGeneratorTest2()
        {
            expectedPrimes = new List<int>();
            expectedPrimes.Add(2);
            expectedPrimes.Add(3);
            expectedPrimes.Add(5);
            expectedPrimes.Add(7);
            //act
            List<int> res = sutPrimes.GeneratePrimes(4);
            //assert
            CollectionAssert.AreEqual(res, expectedPrimes);
        }

        [Test]
        public void PrimeMultiplicationTestWithnthPrime()
        {
            List<int> providedPrimes = new List<int>() { (int)2, (int)3, (int)5, (int)7 };
            expectedPMTable = new List<List<int>>();
            expectedPMTable.Add(new List<int> { (int)4, (int)6, (int)10, (int)14 });
            expectedPMTable.Add(new List<int> { (int)6, (int)9, (int)15, (int)21 });
            expectedPMTable.Add(new List<int> { (int)10, (int)15, (int)25, (int)35 });
            expectedPMTable.Add(new List<int> { (int)14, (int)21, (int)35, (int)49 });
            // act            
            List<List<int>> result = sutPMTable.GeneratePrimeMultiplicationTable(providedPrimes);
            //assert
            CollectionAssert.AreEqual(expectedPMTable[0], result[0]);
            CollectionAssert.AreEqual(expectedPMTable[1], result[1]);
            CollectionAssert.AreEqual(expectedPMTable[2], result[2]);
            CollectionAssert.AreEqual(expectedPMTable[3], result[3]);
        }

        [Test]
        public void PrimeMultiplicationTestWithPrimesRequested1()
        {
            
            expectedPMTable = new List<List<int>>();
            expectedPMTable.Add(new List<int> { (int)4, (int)6, (int)10 , (int)14 });
            expectedPMTable.Add(new List<int> { (int)6, (int)9, (int)15 , (int)21 });
            expectedPMTable.Add(new List<int> { (int)10, (int)15, (int)25, (int)35 });
            expectedPMTable.Add(new List<int> { (int)14, (int)21, (int)35, (int)49 });
            // act            
            List<List<int>> result = sutPMTable.GeneratePrimeMultiplicationTable(4);
            //assert
            CollectionAssert.AreEqual(expectedPMTable[0], result[0]);
            CollectionAssert.AreEqual(expectedPMTable[1], result[1]);
            CollectionAssert.AreEqual(expectedPMTable[2], result[2]);
            CollectionAssert.AreEqual(expectedPMTable[3], result[3]);
        }

        public void PrimeMultiplicationTestWithPrimesRequested2()
        {
            expectedPMTable = new List<List<int>>();
            expectedPMTable.Add(new List<int> { (int)4, (int)6, (int)10, (int)14, (int)22, (int)26, (int)34, (int)38 });
            expectedPMTable.Add(new List<int> { (int)6, (int)9, (int)15, (int)21, (int)33, (int)39, (int)51, (int)57 });
            expectedPMTable.Add(new List<int> { (int)10, (int)15, (int)25, (int)35, (int)55, (int)65, (int)85, (int)95 });
            expectedPMTable.Add(new List<int> { (int)14, (int)21, (int)35, (int)49, (int)77, (int)91, (int)119, (int)133 });
            expectedPMTable.Add(new List<int> { (int)22, (int)33, (int)55, (int)49, (int)121, (int)143, (int)187, (int)209 });
            expectedPMTable.Add(new List<int> { (int)26, (int)21, (int)65, (int)49, (int)143, (int)169, (int)221, (int)247 });
            expectedPMTable.Add(new List<int> { (int)34, (int)51, (int)85, (int)119, (int)187, (int)221, (int)289, (int)323 });
            expectedPMTable.Add(new List<int> { (int)38, (int)57, (int)95, (int)133, (int)209, (int)247, (int)323, (int)361 });
            // act            
            List<List<int>> result = sutPMTable.GeneratePrimeMultiplicationTable(8);
            //assert
            CollectionAssert.AreEqual(expectedPMTable[0], result[0]);
            CollectionAssert.AreEqual(expectedPMTable[1], result[1]);
            CollectionAssert.AreEqual(expectedPMTable[2], result[2]);
            CollectionAssert.AreEqual(expectedPMTable[3], result[3]);
            CollectionAssert.AreEqual(expectedPMTable[3], result[4]);
            CollectionAssert.AreEqual(expectedPMTable[3], result[5]);
            CollectionAssert.AreEqual(expectedPMTable[3], result[6]);
            CollectionAssert.AreEqual(expectedPMTable[3], result[7]);
        }
        [OneTimeTearDown]
        public void TestTearDown()
        {
            //dispose
            sutPrimes = null;
            sutPMTable = null;
        }

    }
}
