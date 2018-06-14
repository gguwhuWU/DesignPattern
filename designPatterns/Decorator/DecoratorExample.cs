using designPatterns.Decorator.Breakfast;
using designPatterns.Decorator.CondimentDecorator;
using System;

namespace designPatterns.Decorator
{
    /// <summary>
    /// 裝飾
    /// 範例參考來源:https://dotblogs.com.tw/pin0513/archive/2010/01/04/12779.aspx
    /// </summary>
    public class DecoratorExample : IPatternExample
    {
        public void DoWork()
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
    }
}
