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
            
        }
        
        [Test]
        public void AddTwo_Numbers()
        {
            var calculator = new Calculator();
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
            var calculator = new Calculator();
            var expectedNumber = 10;
            calculator.EnterNumber(expectedNumber);
            calculator.MemPlus();
            var result = calculator.MemRetrieve();

            Assert.That(result,Is.EqualTo(expectedNumber));
        }
    }
}
