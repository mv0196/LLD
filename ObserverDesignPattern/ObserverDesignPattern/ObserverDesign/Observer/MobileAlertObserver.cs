using ObserverDesignPattern.ObserverDesign.Observable;
using System;

namespace ObserverDesignPattern.ObserverDesign.Observer
{
    internal class MobileAlertObserver : INotificationAlertObserver
    {
        IStockObservable observable;
        public MobileAlertObserver(IStockObservable observable)
        {
            this.observable = observable;
        }

        public void Update()
        {
            Console.WriteLine($"Yeyyy, Quantity restocked: {observable.GetStockCount()}. Mobile notification sent!!");
        }
    }
}
