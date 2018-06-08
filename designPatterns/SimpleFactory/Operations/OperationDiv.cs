namespace designPatterns.SimpleFactory.Operations
{
    public class OperationDiv : IOperation
    {
        public decimal GetResult(decimal _numberA, decimal _numberB)
        {
            return _numberA / _numberB;
        }
    }
}
