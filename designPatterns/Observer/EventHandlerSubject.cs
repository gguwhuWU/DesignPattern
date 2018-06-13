using System;

namespace designPatterns.Observer
{
    public delegate void MyEventHandler(string message);

    public class EventHandlerSubject : ISubject
    {
        //public event MyEventHandler Update;
        public MyEventHandler Update;

        public void notifyObservers(string pContent)
        {
            Update(pContent);
        }

        public void RegisterObserver(IObserver pObserver)
        {
            throw new NotImplementedException();
        }

        public void RemoveObserver(IObserver pObserver)
        {
            throw new NotImplementedException();
        }
    }
}
