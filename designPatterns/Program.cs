using designPatterns.Decorator;
using designPatterns.Decorator.Breakfast;
using designPatterns.Decorator.CondimentDecorator;
using designPatterns.Proxy;
using designPatterns.SimpleFactory;
using designPatterns.Strategy;
using designPatterns.Strategy.CashSuper;
using System;

namespace designPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            UseProxy();

            Console.ReadLine();
        }

        /// <summary>
        /// 工廠
        /// </summary>
        public static void UseFactory()
        {

        }

        /// <summary>
        /// 代理
        /// 範例來源:https://dotblogs.com.tw/alonstar/2011/05/13/25025
        /// </summary>
        public static void UseProxy()
        {
            new ProxyService().DoWork();
        }

        /// <summary>
        /// 裝飾
        /// 範例來源:https://dotblogs.com.tw/pin0513/archive/2010/01/04/12779.aspx
        /// </summary>
        public static void UseDecorator()
        {
            //客人訂了一份土司，不需要配料，列出他的價格與描述
            IBreakfast bf1 = new Toast();
            Console.WriteLine("餐點：{0} 價格：{1}", bf1.GetDescription(), bf1.GetCost());

            //客人訂了一份貝果，要加"雙倍"火腿，列出他的價格與描述
            IBreakfast bf2 = new Bego();
            bf2 = new Ham(bf2);
            bf2 = new Ham(bf2);
            Console.WriteLine("餐點：{0} 價格：{1}", bf2.GetDescription(), bf2.GetCost());

            //客人訂了一份漢堡，要加牛肉 生菜 起司，列出他的價格與描述
            IBreakfast bf3 = new Hamburger();
            bf3 = new Beef(bf3);
            bf3 = new Lettuce(bf3);
            bf3 = new Cheese(bf3);
            Console.WriteLine("餐點：{0} 價格：{1}", bf3.GetDescription(), bf3.GetCost());
        }

        /// <summary>
        /// 策略
        /// </summary>
        public static void UseStrategy()
        {
            var cc = new CashContext(new CashRebate((decimal)0.8));
            Console.WriteLine($"100-打八折: {cc.GetResult(100)}");

            cc = new CashContext(new CashReturn(300, 100));
            Console.WriteLine($"450-滿300送100: {cc.GetResult(450)}");
        }

        /// <summary>
        /// 簡單工廠
        /// </summary>
        public static void UseSimpleFactory()
        {
            var oper = new OperationFactory();
            var newOpernByAdd = oper.CreateOperate(OperationObject.add);
            var newOperByMul = oper.CreateOperate(OperationObject.Mul);
            Console.WriteLine(newOpernByAdd.GetResult((decimal)1.3, (decimal)8.2));
            Console.WriteLine(newOperByMul.GetResult((decimal)2.2, (decimal)1.1));
        }
    }
}
