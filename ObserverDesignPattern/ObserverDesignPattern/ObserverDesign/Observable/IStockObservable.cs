using ObserverDesignPattern.ObserverDesign.Observer;
using System;
using System.Text;

namespace ObserverDesignPattern.ObserverDesign.Observable
{
    internal interface IStockObservable
    {
        void Add(INotificationAlertObserver observer);
        void Remove(INotificationAlertObserver observer);
        void NotifySubscribers();
        void SetStockCount(int newStockAdded);
        int GetStockCount();
    }
}
