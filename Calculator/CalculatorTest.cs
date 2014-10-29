using System;
using System.Text;
using System.Threading.Tasks;
using CalculatorLib;
using NUnit.Framework;

namespace CalculatorTest
{
    public class FakeMemory : ICalculatorMemory
    {
        public int FakeValueToReturn { get; set; }
        public void MemPlus(int number)
        {
            FakeValueToReturn = number;
        }

        public int MemRetrieve()
        {
            return FakeValueToReturn;
        }
    }
    [TestFixture]
    public class CalculatorTest
    {
        
        [Test]
        public void MultiplyTwoNumbers()
        {
            var _memory = new StoreSingleNumber();
            var calculator = new Calculator(_memory);
            var firstNumber = 3;
            var secondNumber = 4;
            calculator.EnterNumber(firstNumber);
            calculator.Multiply();
            calculator.EnterNumber(secondNumber);

            var result = calculator.Equals();
            
            Assert.That(result,Is.EqualTo(12));
        }
        
        [Test]
        public void AddTwo_Numbers()
        {
            var _memory = new StoreSingleNumber();
            var calculator = new Calculator(_memory);
            var firstNumber = 3;
            var secondNumber = 4;
            calculator.EnterNumber(firstNumber);
            calculator.Add();
            calculator.EnterNumber(secondNumber);
            var result = calculator.Equals();
            Assert.That(result, Is.EqualTo(7));
        }

        [Test]
        public void Store_Retrieve_FromMemory()
        {
            var _memory = new FakeMemory();
            
            var calculator = new Calculator(_memory);
            
            var expectedNumber = 10;

            calculator.EnterNumber(expectedNumber);
            calculator.MemPlus();

            _memory.FakeValueToReturn = 99;

            var result = calculator.MemRetrieve();

            Assert.That(result,Is.EqualTo(99));
        }      
  
        [Test]
        public void Add_AddsNumberFromMemory()
        {
            var _memory = new StoreSingleNumber();
            var calculator = new Calculator(_memory);
            var firstNumber = 3;
            var secondNumber = 4;
            
            calculator.EnterNumber(firstNumber);
            calculator.MemPlus();
            calculator.EnterNumber(secondNumber);
            calculator.Add();
            calculator.MemRetrieve();
            var result = calculator.Equals();
            Assert.That(result, Is.EqualTo(7));
        }

        [Test]
        public void Add_Multiply_From_Memory()
        {
            var _memory = new StoreSingleNumber();
            var calculator = new Calculator(_memory);
            var firstNumber = 3;
            var secondNumber = 4;
            var numberForMultiply = 2;
            calculator.EnterNumber(firstNumber);
            calculator.Add();
            calculator.EnterNumber(secondNumber);
            calculator.Equals();

            calculator.MemPlus();
            calculator.EnterNumber(numberForMultiply);
            calculator.Multiply();
            calculator.MemRetrieve();

            var result = calculator.Equals();

            Assert.That(result,Is.EqualTo(14));
        }
    }
}
