using ObserverDesignPattern.ObserverDesign.Observer;
using System.Collections.Generic;

namespace ObserverDesignPattern.ObserverDesign.Observable
{
    internal class PhoneStockObservable : IStockObservable
    {
        List<INotificationAlertObserver> observers = new List<INotificationAlertObserver>();
        int stockCount = 0;
        public void Add(INotificationAlertObserver observer)
        {
            observers.Add(observer);
        }

        public int GetStockCount()
        {
            return stockCount;
        }

        public void NotifySubscribers()
        {
            foreach (INotificationAlertObserver observer in observers)
            {
                observer.Update();
            }
        }

        public void Remove(INotificationAlertObserver observer)
        {
            observers.Remove(observer);
        }

        public void SetStockCount(int newStockAdded)
        {
            if (stockCount == 0 && newStockAdded > 0)
            {
                stockCount = newStockAdded;
                NotifySubscribers();
            }
            stockCount = newStockAdded;
        }
    }
}
