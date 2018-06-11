using designPatterns.Decorator;
using designPatterns.Decorator.Breakfast;
using designPatterns.Decorator.CondimentDecorator;
using designPatterns.Factory;
using designPatterns.Factory.Summon;
using designPatterns.Prototype;
using designPatterns.Proxy;
using designPatterns.SimpleFactory;
using designPatterns.Strategy;
using designPatterns.Strategy.CashSuper;
using designPatterns.Template;
using designPatterns.Facade;
using System;
using designPatterns.Builder.BuilderComputer;
using designPatterns.Builder;

namespace designPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            UseObserver();

            Console.ReadLine();
        }

        /// <summary>
        /// 觀察者
        /// </summary>
        public static void UseObserver()
        {

        }

        /// <summary>
        /// 建造者
        /// 範例參考來源:
        /// http://www.cnblogs.com/zhili/p/BuilderPattern.html
        /// https://blog.csdn.net/carson_ho/article/details/54910597
        /// </summary>
        public static void UseBuilder()
        {
            ConcreteHighEndBuilder highEndBuilder = new ConcreteHighEndBuilder();
            ConcreteMiddleEndBuilder middleEndBuilder = new ConcreteMiddleEndBuilder();
            ConcreteLowEndBuilder lowEndBuilder = new ConcreteLowEndBuilder();

            Director director = new Director();
            director.Construct(highEndBuilder);
            director.Construct(middleEndBuilder);
            director.Construct(lowEndBuilder);

            highEndBuilder.GetComputer();
            middleEndBuilder.GetComputer();
            lowEndBuilder.GetComputer();
        }

        /// <summary>
        /// 外觀
        /// 範例來源:大話設計模式
        /// </summary>
        public static void UseFacade()
        {
            FacadeSystem fa = new FacadeSystem();
            fa.MethodA();
            fa.MethodB();
        }

        /// <summary>
        /// 範本
        /// 範例來源:大話設計模式
        /// </summary>
        public static void UseTemplate()
        {
            TestPaperA ta = new TestPaperA();
            ta.DisplayName();
            ta.TestQuestion1();
            ta.TestQuestion2();
            ta.TestQuestion3();

            TestPaperB tb = new TestPaperB();
            tb.DisplayName();
            tb.TestQuestion1();
            tb.TestQuestion2();
            tb.TestQuestion3();
        }

        /// <summary>
        /// 原型(複製)
        /// 範例來源:大話設計模式
        /// </summary>
        public static void UsePortotype()
        {
            Resume r1 = new Resume("小吳");
            r1.SetPersonalInfo("m", 25);
            r1.SetWorkExperience(new DateTime(1999, 1, 1), "x公司");

            Resume r2 = (Resume)r1.Clone();
            r2.SetPersonalInfo("f", 20);
            r2.SetWorkExperience(new DateTime(1994, 5, 5), "y公司");

            Resume r3 = (Resume)r1.Clone();
            r3.SetPersonalInfo("f", 22);
            r3.SetWorkExperience(new DateTime(1996, 11, 11), "z公司");

            r1.Display();
            r2.Display();
            r3.Display();
        }

        /// <summary>
        /// 工廠
        /// 範例參考來源:https://skyyen999.gitbooks.io/-study-design-pattern-in-java/content/factory.html
        /// </summary>
        public static void UseFactory()
        {
            IServant servant1 = new SaberSummon().CallServant();
            Console.WriteLine(servant1.CareerName);
            servant1.Attack();

            IServant servant2 = new ArcherSummon().CallServant();
            Console.WriteLine(servant2.CareerName);
            servant2.Attack();
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
        /// 範例參考來源:https://dotblogs.com.tw/pin0513/archive/2010/01/04/12779.aspx
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
        /// 範例參考來源:大話設計模式
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
        /// 範例參考來源:大話設計模式
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
