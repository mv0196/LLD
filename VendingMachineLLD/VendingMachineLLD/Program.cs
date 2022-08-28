using System;
using VendingMachineLLD.Service.Implementation.Machines;
using VendingMachineLLD.Service.Interface;

namespace VendingMachineLLD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVendingMachine machine = new VendingMachine();

            IState state = machine.State;
            state.Start(machine);

            
            state = machine.State;


            state.InsertCoin(machine, Enums.Coins.Dime);
            state.InsertCoin(machine, Enums.Coins.Peny);
            state.InsertCoin(machine, Enums.Coins.Peny);
            state.InsertCoin(machine, Enums.Coins.Peny);

            state.PressChooseProduct(machine);


            state = machine.State;


            state.ChoseProduct(machine);

            
            state = machine.State;


            state.DispenseProduct(machine);

            Console.ReadKey();
        }
    }
}
