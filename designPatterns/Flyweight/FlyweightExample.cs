using System;

namespace designPatterns.Flyweight
{
    /// <summary>
    /// 享元
    /// 範例參考來源:
    /// 大話設計模式
    /// https://openhome.cc/Gossip/DesignPattern/FlyweightPattern.htm
    /// https://ithelp.ithome.com.tw/articles/10195427
    /// http://corrupt003-design-pattern.blogspot.com/2017/01/flyweight-pattern.html
    /// </summary>
    public class FlyweightExample : IPatternExample
    {
        public void DoWork()
        {
            FontFactory fontFactory = new FontFactory();
            Font f1 = fontFactory.create("新細明體", Style.ITALIC, 15);
            Font f2 = fontFactory.create("標楷體", Style.PLAIN, 12);
            Font f3 = fontFactory.create("哈哈", Style.BOLD, 18);
            Font f4 = fontFactory.create("標楷體", Style.PLAIN, 12);
            Font f5 = fontFactory.create("新細明體", Style.ITALIC, 15);
            Font f6 = fontFactory.create("標楷體", Style.PLAIN, 12);

            Console.WriteLine($"{f1.hashCode()}");
            Console.WriteLine($"{f2.hashCode()}");
            Console.WriteLine($"{f3.hashCode()}");
            Console.WriteLine($"{f4.hashCode()}");
            Console.WriteLine($"{f5.hashCode()}");
            Console.WriteLine($"{f6.hashCode()}");

            Console.WriteLine($"判斷1:{f2.hashCode() == f6.hashCode()}");
            Console.WriteLine($"判斷2:{f2.hashCode() == f5.hashCode()}");

            Console.WriteLine($"判斷3:{f1.equals(f2)}");
            Console.WriteLine($"判斷4:{f1.equals(f5)}");

            Console.WriteLine($"判斷5:{f2 == f4}");
            Console.WriteLine($"判斷6:{f2 == f5}");

            Console.WriteLine($"產生物件數:{fontFactory.GetFactoryCount()}");
        }
    }
}
