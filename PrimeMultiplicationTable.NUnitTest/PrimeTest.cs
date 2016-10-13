﻿using NUnit.Framework;
using PrimeMultiplicationTableTDD;
using System.Collections.Generic;

namespace PrimeMultiplicationTableTest.NUnit
{
    [TestFixture]
    public class PrimeTest
    {
        Prime sut;
        List<int> expected;
        
        [OneTimeSetUp]
        public void TestSetUp()
        {
            //arrange
            sut = new Prime();

           
        }
        
        [Test]
        public void ShouldCheckGreaterThanOneReturnTrueForTwo()
        {
            //act
            bool result = sut.IsGreaterThanZero(2);
            //assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void ShouldCheckGreaterThanOneReturnFalseForZero()
        {
            //act
            bool result = sut.IsGreaterThanZero(0);
            //assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void ShouldReturnListOneTwoThreeFiveWhenInputFour()
        {
            expected = new List<int>();
            expected.Add(1);
            expected.Add(2);
            expected.Add(3);
            expected.Add(5);
            //act
            List<int> res = sut.GeneratePrimes(4);
            //assert
            CollectionAssert.AreEqual(res, expected);
        }
        [OneTimeTearDown]
        public void TestTearDown()
        {
            //dispose
            sut =null;
             
        }

    }
}