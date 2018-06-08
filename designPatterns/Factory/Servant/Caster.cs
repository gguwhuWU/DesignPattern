using System;

namespace designPatterns.Factory.Servant
{
    public class Caster : IServant
    {
        public string CareerName
        {
            get
            {
                return "魔術師";
            }
        }

        public void Attack()
        {
            Console.WriteLine("詠唱法術轟炸");
        }
    }
}
