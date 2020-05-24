using Library.vendor.Observer;
using NUnit.Framework;

namespace LibraryTest.Unit.vendor.Observer
{
    public class ObserverTest
    {
        private Library.vendor.Observer.Observer _observer;
        
        [SetUp]
        public void Setup()
        {
            _observer = new ObserverAbstractMock();
        }

        [Test]
        public void it_can_register_observers()
        {
            _observer.RegisterObserver(new SubscriberMock());
            _observer.RegisterObserver(new SubscriberMock());
            Assert.True(2 == _observer.GetSubscribers().Count);
        }
        
        [Test]
        public void it_can_register_and_unregister_observers()
        {
            var subscriber1 = new SubscriberMock();
            var subscriber2 = new SubscriberMock();
            
            _observer.RegisterObserver(subscriber1);
            _observer.RegisterObserver(subscriber2);
            Assert.AreEqual(2, _observer.GetSubscribers().Count);
            
            _observer.UnregisterObserver(subscriber1);
            Assert.AreEqual(1, _observer.GetSubscribers().Count);
            
            _observer.UnregisterObserver(subscriber2);
            Assert.AreEqual(0, _observer.GetSubscribers().Count);
        }
    }

    public class ObserverAbstractMock : Library.vendor.Observer.Observer
    {
        public bool IsPublished { get; set; }

        public ObserverAbstractMock()
        {
            IsPublished = false;
        }
        
        public override void Publish()
        {
            IsPublished = true;
        }
    }
    
    public class SubscriberMock : IObserver
    {
        public bool IsUpdated { get; set; }

        public SubscriberMock()
        {
            IsUpdated = false;
        }
        
        public void Update()
        {
            IsUpdated = true;
        }
    }
}