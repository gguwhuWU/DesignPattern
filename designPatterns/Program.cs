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
using designPatterns.Observer;
using designPatterns.AbstractFactory;
using designPatterns.State;

namespace designPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            UseState();

            Console.ReadLine();
        }

        /// <summary>
        /// 狀態
        /// 範例參考來源:
        /// 大話設計模式
        /// https://xyz.cinc.biz/2013/07/state-pattern.html
        /// https://dotblogs.com.tw/pin0513/2011/01/16/20842
        /// </summary>
        public static void UseState()
        {
            Person person = new Person(200, 20, 30);
            person.Attack();
            person.Move();
            person.SupplyBlood();

            person.blood = 60;
            person.Attack();
            person.Move();
            person.SupplyBlood();

            person.blood = 2;
            person.Attack();
            person.Move();
            person.SupplyBlood();

            person.blood = 150;
            person.Attack();
            person.Move();
            person.SupplyBlood();
        }

        /// <summary>
        /// 抽象工廠
        /// 範例參考來源:
        /// 大話設計模式
        /// https://blog.techbridge.cc/2017/05/22/factory-method-and-abstract-factory/
        /// https://skyyen999.gitbooks.io/-study-design-pattern-in-java/content/abstractFactory1.html
        /// </summary>
        public static void UseAbstractFactory()
        {
            IPizzaFactory pizzaFactory = new PizzaHutPizzaFactory();
            //IPizzaFactory pizzaFactory = new DominosPizzaFactory();

            pizzaFactory.CreateHawaiiPizza();
            pizzaFactory.CreateSpecialTakoyakiPizza();

            // 使用 基本反射
            pizzaFactory.CreateBeefPizza();

            // 使用 反射的工廠
            IPizzaFactory pizzaFactoryOfReflection = new ReflectionPizzaFactory();
            pizzaFactoryOfReflection.CreateSpecialBeefPizza();
        }

        /// <summary>
        /// 觀察者
        /// 範例參考來源:
        /// https://dotblogs.com.tw/joysdw12/2013/03/13/96531
        /// </summary>
        public static void UseObserver()
        {
            // 產生一間報社
            NewspaperOffice office = new NewspaperOffice();

            // Arvin 想要訂閱報紙
            Customer arvin = new Customer("Arvin");
            office.SubscribeNewspaper(arvin);

            // Jack 想要訂閱報紙
            Customer jack = new Customer("Jack");
            office.SubscribeNewspaper(jack);

            // 報社發送了第一則新聞
            office.SendNewspaper("News One.......");

            // Arvin 不想看報紙了，要退訂
            office.UnsubscribeNewspaper(arvin);

            // 報社發送了第二則新聞
            office.SendNewspaper("News Two.......");

            /******用在其他地方的觀察者*****/
            Subject office2 = new Subject();
            OtherObserver oth1 = new OtherObserver("test1");
            OtherObserver oth2 = new OtherObserver("test2");
            office2.RegisterObserver(oth1);
            office2.RegisterObserver(oth2);

            Console.WriteLine("");

            office2.notifyObservers(" jojo good");

            Console.WriteLine("");

            EventHandlerSubject office3 = new EventHandlerSubject();
            office3.Update += new MyEventHandler(oth1.Update);
            office3.Update += new MyEventHandler(oth2.Update);
            //office3.Update -= new EventHandler(oth2.Update);
            office3.notifyObservers(" dio die");
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
