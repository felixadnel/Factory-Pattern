using System;
namespace FactoryPattern
{
	public class Motorcycle : IVehicle
	{
		public Motorcycle()
		{
		}

		public void Drive()
		{
            ConsoleLogger.VehiclesStartupDialouge();
            Console.WriteLine("The motorcylce is Driving");
            Console.WriteLine("swooosh");

        }
	}
}

