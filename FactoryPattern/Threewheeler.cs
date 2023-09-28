using System;
namespace FactoryPattern
{
	public class Threewheeler : IVehicle
	{
		public Threewheeler()
		{
		}

		public void Drive()
		{
			Console.WriteLine("Lets get it!");
		}
	}
}

