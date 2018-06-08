using System;

namespace designPatterns.Factory.Servant
{
    public class Berserker : IServant
    {
        public string CareerName
        {
            get
            {
                return "狂戰士";
            }
        }

        public void Attack()
        {
            Console.WriteLine("拿著鐵狼棒亂砸");
        }
    }
}
