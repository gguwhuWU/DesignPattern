namespace designPatterns.Strategy.CashSuper
{
    /// <summary>
    /// 正常收費
    /// </summary>
    public class CashNormal : ICashSuper
    {
        public decimal acceptCash(decimal money)
        {
            return money;
        }
    }
}
