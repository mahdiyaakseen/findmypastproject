using NUnit.Framework;
using PrimeMultiplicationTableTDD;


namespace PrimeMultiplicationTableTest.NUnit
{
    [TestFixture]
    public class PrimeTest
    {
        Prime sut;
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
            bool result = sut.IsGreaterThan1(2);
            //assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void ShouldCheckGreaterThanOneReturnFalseForZero()
        {
            //act
            bool result = sut.IsGreaterThan1(0);
            //assert
            Assert.That(result, Is.False);
        }

        [OneTimeTearDown]
        public void TestTearDown()
        {
            //dispose
            sut =null;
        }

    }
}
