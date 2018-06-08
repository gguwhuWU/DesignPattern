namespace designPatterns.SimpleFactory.Operations
{
    public class OperationAdd : IOperation
    {
        public decimal GetResult(decimal _numberA, decimal _numberB)
        {
            return _numberA +_numberB;
        }
    }
}
