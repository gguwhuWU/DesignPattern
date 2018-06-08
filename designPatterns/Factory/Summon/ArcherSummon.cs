using designPatterns.Factory.Servant;
using System;

namespace designPatterns.Factory.Summon
{
    public class ArcherSummon : ISummon
    {
        public IServant CallServant()
        {
            Console.WriteLine("開始召喚符合條件的Archer");
            return new Archer();
        }
    }
}
