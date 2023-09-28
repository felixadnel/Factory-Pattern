using System;
namespace FactoryPattern
{
	public class ConsoleLogger
	{
		public static void VehiclesStartupDialouge()
		{
			Console.WriteLine("Place finger on start button");
			Thread.Sleep(1000);
			Console.WriteLine("Push to START");
			Thread.Sleep(1000);
		}
	}
}

