using NUnit.Framework;

namespace CalculatorTest
{
    [TestFixture]
    public class MemoryTests
    {
         [Test]
         public void StoreSingleNumber_MemPlus_StoresLastEnteredNumber()
         {
             var expectedNumber = 10;
             var memory = new StoreSingleNumber();
             memory.MemPlus(expectedNumber);

             var result = memory.MemRetrieve();

             Assert.That(result,Is.EqualTo(expectedNumber));
         }

        [Test]
        public void StoreSingleNumber_ReturnsLastStoredNumberOnly()
        {
            var expectedlastNumber = 1;
            var expectedlastNumber1 = 2;
            var memory = new StoreSingleNumber();
            memory.MemPlus(expectedlastNumber);
            memory.MemPlus(expectedlastNumber1);
            
            var firstResult = memory.MemRetrieve();

            var secondResult = memory.MemRetrieve();
            
            Assert.That(firstResult,Is.EqualTo(expectedlastNumber1));
            Assert.That(secondResult, Is.EqualTo(expectedlastNumber1));
        }
    }
}