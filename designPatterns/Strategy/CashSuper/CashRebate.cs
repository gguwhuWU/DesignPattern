namespace designPatterns.Strategy.CashSuper
{
    /// <summary>
    /// 打折收費
    /// </summary>
    public class CashRebate : ICashSuper
    {
        private decimal moneyRebate;
        public CashRebate(decimal moneyRebate)
        {
            this.moneyRebate = moneyRebate;
        }

        public decimal acceptCash(decimal money)
        {
            return money * this.moneyRebate;
        }
    }
}
