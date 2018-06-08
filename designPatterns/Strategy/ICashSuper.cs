using System;

namespace designPatterns.Strategy
{
    /// <summary>
    /// 現金收費
    /// </summary>
    public interface ICashSuper
    {
        Decimal acceptCash(Decimal money);
    }
}
