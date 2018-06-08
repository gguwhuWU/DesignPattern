using System;

namespace designPatterns.Proxy
{
    public class RemoteService : IService
    {
        public void DoWork()
        {
            Console.WriteLine("做一大堆很難的事情");
        }
    }
}
