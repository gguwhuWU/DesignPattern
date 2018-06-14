using designPatterns.Factory.Summon;
using System;

namespace designPatterns.Factory
{
    /// <summary>
    /// 工廠
    /// 範例參考來源:https://skyyen999.gitbooks.io/-study-design-pattern-in-java/content/factory.html
    /// </summary>
    public class FactoryExample : IPatternExample
    {
        public void DoWork()
        {
            IServant servant1 = new SaberSummon().CallServant();
            Console.WriteLine(servant1.CareerName);
            servant1.Attack();

            IServant servant2 = new ArcherSummon().CallServant();
            Console.WriteLine(servant2.CareerName);
            servant2.Attack();
        }
    }
}
