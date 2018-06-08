using System;

namespace designPatterns.Factory.Servant
{
    public class Saber : IServant
    {
        public string CareerName
        {
            get
            {
                return "劍士";
            }
        }

        public void Attack()
        {
            Console.WriteLine("揮劍直劈");
        }
    }
}
