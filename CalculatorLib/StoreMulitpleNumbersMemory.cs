using System.Collections.Generic;
using CalculatorTest;

namespace CalculatorLib
{
    public class StoreMulitpleNumbersMemory : ICalculatorMemory
    {
        Stack<int> _memory = new Stack<int>();
        public void MemPlus(int number)
        {
            _memory.Push(number);
        }

        public int MemRetrieve()
        {
            return _memory.Pop();
        }
    }
}