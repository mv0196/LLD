using System;

namespace StrategyDesignPattern
{
    internal class Program
    {
        //https://docs.google.com/document/d/1O2MSNIC_egBLhLJsiRng2XfBvKpyk0Mp_fd-qk0e47A/edit
        //https://www.youtube.com/watch?v=u8DttUrXtEw&list=PL6W8uoQQ2c61X_9e6Net0WdYZidm7zooW&index=2&t=619s
        static void Main(string[] args)
        {
            Vehicle vh = new PassengerVehicle();
            vh.Drive();

            vh = new LuxuryVehicle();
            vh.Drive();

            vh = new HotelServiceVehicle();
            vh.Drive();
        }
    }
}
