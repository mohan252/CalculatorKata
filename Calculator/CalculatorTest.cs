using System;
using System.Text;
using System.Threading.Tasks;
using CalculatorLib;
using NUnit.Framework;

namespace CalculatorTest
{
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
            var _memory = new StoreSingleNumber();
            var calculator = new Calculator(_memory);
            var expectedNumber = 10;
            calculator.EnterNumber(expectedNumber);
            calculator.MemPlus();
            var result = calculator.MemRetrieve();

            Assert.That(result,Is.EqualTo(expectedNumber));
        }        
    }
}
