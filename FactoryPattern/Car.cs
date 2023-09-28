using System;
namespace FactoryPattern
{
	public class Car : IVehicle
	{
		public Car()
		{
		}

		public void Drive()
		{
			ConsoleLogger.VehiclesStartupDialouge();
			Console.WriteLine("The Car is driving");
		}
	}
}

