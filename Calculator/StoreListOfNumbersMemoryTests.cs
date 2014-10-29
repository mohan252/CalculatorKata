using CalculatorLib;
using NUnit.Framework;

namespace CalculatorTest
{
    [TestFixture]
    public class StoreListOfNumbersMemoryTests
    {
         [Test]
         public void StoreListOfNumbers_MemPlus_StoresTheList()
         {
             var expectedNumber = 10;
             var memory = new StoreMulitpleNumbersMemory();
             memory.MemPlus(expectedNumber);

             var result = memory.MemRetrieve();

             Assert.That(result, Is.EqualTo(expectedNumber));
         }

         [Test]
         public void StoreListOfNumbers_MemRetrieve_RetrievesTheList_InReverseOrder()
         {
             var firstNumber = 10;
             var secondNumber = 20;
             var memory = new StoreMulitpleNumbersMemory();
             memory.MemPlus(firstNumber);
             memory.MemPlus(secondNumber);

             var result = memory.MemRetrieve();

             Assert.That(result, Is.EqualTo(secondNumber));

             result = memory.MemRetrieve();
             Assert.That(result, Is.EqualTo(firstNumber));
         }
    }
}