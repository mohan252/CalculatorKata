using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CalculatorTest
{
    [TestFixture]
    public class CalculatorTest
    {
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
    }

    public class Calculator
    {
        List<string> input = new List<string>();
        public void EnterNumber(int number)
        {
            input.Add(number.ToString());
        }

        public void Add()
        {
            input.Add("+");
        }

        internal int Equals()
        {
            var operand1 = int.Parse(input[0]);
            var oper = input[1];
            var operand2 = int.Parse(input[2]);

            int result = 0;
            if (oper == "+")
                return operand1 + operand2;

            return result;
        }
    }
}
