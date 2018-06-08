namespace designPatterns.Strategy
{
    public class CashContext
    {
        ICashSuper cs;
        public CashContext(ICashSuper cs)
        {
            this.cs = cs;
        }

        public decimal GetResult(decimal money)
        {
            return this.cs.acceptCash(money);
        }
    }
}
