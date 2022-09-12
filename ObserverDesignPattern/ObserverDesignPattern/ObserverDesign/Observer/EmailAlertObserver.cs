using ObserverDesignPattern.ObserverDesign.Observable;
using System;

namespace ObserverDesignPattern.ObserverDesign.Observer
{
    internal class EmailAlertObserver : INotificationAlertObserver
    {
        IStockObservable observable;
        public EmailAlertObserver(IStockObservable observable)
        {
            this.observable = observable;
        }

        public void Update()
        {
            Console.WriteLine($"Yeyyy, Quantity restocked: {observable.GetStockCount()}. Email sent!!");
        }
    }
}
