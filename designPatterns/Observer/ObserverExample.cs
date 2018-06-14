using System;

namespace designPatterns.Observer
{
    /// <summary>
    /// 觀察者
    /// 範例參考來源:
    /// https://dotblogs.com.tw/joysdw12/2013/03/13/96531
    /// </summary>
    public class ObserverExample : IPatternExample
    {
        public void DoWork()
        {
            // 產生一間報社
            NewspaperOffice office = new NewspaperOffice();

            // Arvin 想要訂閱報紙
            Customer arvin = new Customer("Arvin");
            office.SubscribeNewspaper(arvin);

            // Jack 想要訂閱報紙
            Customer jack = new Customer("Jack");
            office.SubscribeNewspaper(jack);

            // 報社發送了第一則新聞
            office.SendNewspaper("News One.......");

            // Arvin 不想看報紙了，要退訂
            office.UnsubscribeNewspaper(arvin);

            // 報社發送了第二則新聞
            office.SendNewspaper("News Two.......");

            /******用在其他地方的觀察者*****/
            Subject office2 = new Subject();
            OtherObserver oth1 = new OtherObserver("test1");
            OtherObserver oth2 = new OtherObserver("test2");
            office2.RegisterObserver(oth1);
            office2.RegisterObserver(oth2);

            Console.WriteLine("");

            office2.notifyObservers(" jojo good");

            Console.WriteLine("");

            EventHandlerSubject office3 = new EventHandlerSubject();
            office3.Update += new MyEventHandler(oth1.Update);
            office3.Update += new MyEventHandler(oth2.Update);
            //office3.Update -= new EventHandler(oth2.Update);
            office3.notifyObservers(" dio die");
        }
    }
}
