using System;

namespace designPatterns.Factory.Servant
{
    public class Archer : IServant
    {
        public string CareerName
        {
            get
            {
                return "弓箭手";
            }
        }
        
        public void Attack()
        {
            Console.WriteLine("拿起弓射箭");
        }
    }
}
