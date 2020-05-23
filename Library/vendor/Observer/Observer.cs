using System.Collections.Generic;

namespace Library.vendor.Observer
{
    public abstract class Observer : IPublisher, ISubject
    {
        private readonly List<IObserver> _subscribers;

        protected Observer()
        {
            _subscribers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            _subscribers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            _subscribers.Remove(observer);
        }

        public void NotifyObservers()
        {
            _subscribers.ForEach(subscriber => subscriber.Update());
        }

        public IList<IObserver> GetSubscribers()
        {
            return _subscribers;
        }

        public abstract void Publish();
    }
}