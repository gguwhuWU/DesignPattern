using System;

namespace designPatterns.Factory.Servant
{
    public class Lancer : IServant
    {
        public string CareerName
        {
            get
            {
                return "槍兵";
            }
        }

        public void Attack()
        {
            Console.WriteLine("拿起槍直刺");
        }
    }
}
