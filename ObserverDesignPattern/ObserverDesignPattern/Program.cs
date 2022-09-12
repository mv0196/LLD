using ObserverDesignPattern.ObserverDesign.Observable;
using ObserverDesignPattern.ObserverDesign.Observer;
using System;

namespace ObserverDesignPattern
{
    internal class Program
    {
        //https://docs.google.com/document/d/1O2MSNIC_egBLhLJsiRng2XfBvKpyk0Mp_fd-qk0e47A/edit
        //https://www.youtube.com/watch?v=Ep9_Zcgst3U&list=PL6W8uoQQ2c61X_9e6Net0WdYZidm7zooW&index=3
        //https://refactoring.guru/design-patterns/observer
        static void Main(string[] args)
        {
            IStockObservable phoneObservable = new PhoneStockObservable();

            INotificationAlertObserver observer1 = new MobileAlertObserver(phoneObservable);
            INotificationAlertObserver observer2 = new EmailAlertObserver(phoneObservable);
            INotificationAlertObserver observer3 = new EmailAlertObserver(phoneObservable);

            phoneObservable.Add(observer1);
            phoneObservable.Add(observer2);
            phoneObservable.Add(observer3);

            phoneObservable.SetStockCount(10);
            phoneObservable.SetStockCount(0);
            phoneObservable.SetStockCount(100);
        }
    }
}
