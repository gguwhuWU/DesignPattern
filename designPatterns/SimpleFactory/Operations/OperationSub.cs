namespace designPatterns.SimpleFactory.Operations
{
    public class OperationSub : IOperation
    {
        public decimal GetResult(decimal _numberA, decimal _numberB)
        {
            return _numberA - _numberB;
        }
    }
}
