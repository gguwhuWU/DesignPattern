using System;

namespace designPatterns.Singleton
{
    /// <summary>
    /// 獨體
    /// 範例參考來源:
    /// 大話設計模式
    /// </summary>
    public class SingletonExample : IPatternExample
    {
        public void DoWork()
        {
            LazyObject lo1 = LazyObject.GetInstanceBySync();
            LazyObject lo2 = LazyObject.GetInstanceBySync();

            if (lo1 == lo2)
            {
                Console.WriteLine("一樣物件");
            }

            StartObject so1 = StartObject.GetInstance();
            StartObject so2 = StartObject.GetInstance();

            if (so1 == so2)
            {
                Console.WriteLine("一樣物件");
            }
        }
    }
}
