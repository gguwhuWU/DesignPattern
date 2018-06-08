using System;

namespace designPatterns.Strategy.CashSuper
{
    /// <summary>
    /// 紅利收費
    /// </summary>
    public class CashReturn : ICashSuper
    {
        private decimal moneyCondition;
        private decimal moneyReturn;
        public CashReturn(decimal moneyCondition, decimal moneyReturn)
        {
            this.moneyCondition = moneyCondition;
            this.moneyReturn = moneyReturn;
        }

        public decimal acceptCash(decimal money)
        {
            decimal result = money;
            if (money >= this.moneyCondition)
            {
                result = money - (Math.Floor((money / this.moneyCondition)) * this.moneyReturn);
            }

            return result;
        }
    }
}
