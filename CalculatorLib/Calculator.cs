using System;
using System.Collections.Generic;
using System.Linq;
using CalculatorTest;

namespace CalculatorLib
{
    public class Calculator
    {
        List<string> input = new List<string>();

        private ICalculatorMemory _memory;

        public Calculator(ICalculatorMemory memory)
        {
            _memory = memory;
        }
        
        public void EnterNumber(int number)
        {
            input.Add(number.ToString());
        }

        public void Add()
        {
            input.Add("+");
        }

        public int Equals()
        {
            input.Reverse();
            input = input.Take(3).ToList();
            var operand1 = int.Parse(input[0]);
            var oper = input[1];
            var operand2 = int.Parse(input[2]);

            int result = 0;
            if (oper == "+")
                result = operand1 + operand2;
            else if (oper == "*")
                result = operand1 * operand2;

            input.Clear();
            input.Add(Convert.ToString(result));
            return result;
        }

        public void MemPlus()
        {
            _memory.MemPlus(int.Parse(input.Last()));
        }

        public int MemRetrieve()
        {
            int lastValue = _memory.MemRetrieve();
            input.Add(Convert.ToString(lastValue));
            return lastValue;
        }

        public void Multiply()
        {
            input.Add("*");
        }
    }    
}