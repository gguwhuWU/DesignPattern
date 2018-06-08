using System;

namespace designPatterns.SimpleFactory
{
    public interface IOperation
    {
        Decimal GetResult(Decimal _numberA, Decimal _numberB);
    }
}
