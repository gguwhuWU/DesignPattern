using System;

namespace designPatterns.AbstractFactory.PizzaHutPizza
{
    /// <summary>
    /// 實際上應該要用不同的實作跟結果 不然直接繼承已實作的方法 在代入固定值即可 
    /// </summary>
    public class PH_TakoyakiPizza : ITakoyakiPizza
    {
        private readonly string StoreName = "必勝客";
        private readonly string typeName = "章魚燒";

        public void CreateSpecialTakoyakiPizza(int seasoningNumber, int concentrationNumber)
        {
            Console.WriteLine($"{StoreName}-{typeName}披薩 使用 佐料{seasoningNumber}號 濃度{concentrationNumber}等級");
        }

        public void CreateTakoyakiPizza(int seasoningNumber, int concentrationNumber)
        {
            Console.WriteLine($"{StoreName}-特製{typeName}披薩 使用 佐料{seasoningNumber}號 濃度{concentrationNumber}等級");
        }
    }
}
