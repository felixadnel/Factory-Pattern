using System;
namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int wheelCount)
        {
            switch (wheelCount)
            {
                case 2:
                    return new Motorcycle();
                case 3:
                    return new Threewheeler();
                case 4:
                    return new Car();
                default:
                    Console.WriteLine("Unrecognized number of wheels! Defaulting to Car.");
                    return new Car();
            }
        }
    }

}

