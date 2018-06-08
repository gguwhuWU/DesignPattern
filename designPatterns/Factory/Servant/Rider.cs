using System;

namespace designPatterns.Factory.Servant
{
    public class Rider : IServant
    {
        public string CareerName
        {
            get
            {
                return "騎士";
            }
        }

        public void Attack()
        {
            Console.WriteLine("騎上坐騎衝鋒");
        }
    }
}
