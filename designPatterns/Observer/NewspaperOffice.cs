using System;

namespace designPatterns.Observer
{
    public class NewspaperOffice : Subject
    {
        // 訂閱報紙
        public void SubscribeNewspaper(IObserver pCustomer)
        {
            RegisterObserver(pCustomer);
        }

        // 取消訂閱報紙
        public void UnsubscribeNewspaper(IObserver pCustomer)
        {
            RemoveObserver(pCustomer);
        }

        // 發送新消息
        public void SendNewspaper(string pContent)
        {
            Console.WriteLine("Send News..");
            notifyObservers(pContent);
        }
    }
}
