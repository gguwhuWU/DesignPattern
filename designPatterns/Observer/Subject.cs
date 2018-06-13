using System.Collections.Generic;

namespace designPatterns.Observer
{
    public class Subject : ISubject
    {
        IList<IObserver> lstObservers; // 使用List來存放觀察者名單

        public Subject()
        {
            lstObservers = new List<IObserver>();
        }

        // 加入觀察者
        public void RegisterObserver(IObserver pObserver)
        {
            lstObservers.Add(pObserver);
        }

        // 移除觀察者
        public void RemoveObserver(IObserver pObserver)
        {
            if (lstObservers.IndexOf(pObserver) >= 0)
                lstObservers.Remove(pObserver);
        }

        // 發送通知給在監聽名單中的觀察者
        public void notifyObservers(string pContent)
        {
            foreach (IObserver observer in lstObservers)
            {
                observer.Update(pContent);
            }
        }
    }
}
