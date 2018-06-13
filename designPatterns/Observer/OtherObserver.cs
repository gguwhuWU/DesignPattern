using System;

namespace designPatterns.Observer
{
    public class OtherObserver : IObserver
    {
        public string MyName { private get; set; }

        public OtherObserver(string pName)
        {
            MyName = pName;
        }

        // 更新最新消息
        public void Update(string pMessage)
        {
            Console.WriteLine("   {0} receive new message:{1}", MyName, pMessage);
        }
    }
}
