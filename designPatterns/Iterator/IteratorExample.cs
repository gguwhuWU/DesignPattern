using System;
using System.Collections.Generic;
using System.Linq;

namespace designPatterns.Iterator
{
    /// <summary>
    /// 迭代器
    /// 範例參考來源:
    /// 大話設計模式
    /// </summary>
    public class IteratorExample : IPatternExample
    {
        public void DoWork()
        {
            IList<string> bus = new List<string>();
            bus.Add("小吳");
            bus.Add("小陳");
            bus.Add("小林");
            bus.Add("小張");
            bus.Add("小徐");

            foreach(var u in bus)
            {
                Console.WriteLine($"{u} 請買票");
            }

            Console.WriteLine("\n倒著數\n");

            foreach (var u in bus.Reverse())
            {
                Console.WriteLine($"{u} 請買票");
            }
        }
    }
}
