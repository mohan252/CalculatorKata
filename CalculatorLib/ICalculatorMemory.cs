namespace CalculatorTest
{
    public interface ICalculatorMemory
    {
        void MemPlus(int number);
        int MemRetrieve();
    }

    public class StoreSingleNumber : ICalculatorMemory
    {
        private int _lastNumber = 0;
        public void MemPlus(int number)
        {
            _lastNumber = number;
        }

        public int MemRetrieve()
        {
            return _lastNumber;
        }
    }
}