using System;

namespace designPatterns.Factory.Servant
{
    public class Assassin : IServant
    {
        public string CareerName
        {
            get
            {
                return "暗殺者";
            }
        }

        public void Attack()
        {
            Console.WriteLine("拿著小刀從後面背刺");
        }
    }
}
