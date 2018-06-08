using System;

namespace designPatterns.Proxy
{
    public class ProxyService : IService
    {
        private RemoteService _rs;
        public ProxyService()
        {
            _rs = new RemoteService();
        }
        public void DoWork()
        {
            Console.WriteLine("登入代理");
            _rs.DoWork();
        }
    }
}
