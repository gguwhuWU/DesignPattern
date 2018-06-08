using designPatterns.Factory.Servant;
using System;

namespace designPatterns.Factory.Summon
{
    public class SaberSummon : ISummon
    {
        public IServant CallServant()
        {
            Console.WriteLine("開始召喚符合條件的Saber");
            return new Saber();
        }
    }
}
