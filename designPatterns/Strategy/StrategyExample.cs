using designPatterns.Strategy.CashSuper;
using System;

namespace designPatterns.Strategy
{
    /// <summary>
    /// 策略
    /// 範例參考來源:大話設計模式
    /// </summary>
    public class StrategyExample : IPatternExample
    {
        public void DoWork()
        {
            var cc = new CashContext(new CashRebate((decimal)0.8));
            Console.WriteLine($"100-打八折: {cc.GetResult(100)}");

            cc = new CashContext(new CashReturn(300, 100));
            Console.WriteLine($"450-滿300送100: {cc.GetResult(450)}");
        }
    }
}
