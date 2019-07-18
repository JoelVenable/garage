using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();


            List<IChargeable> electricVehicles = new List<IChargeable>() { fx, fxs, modelS };

            electricVehicles.ForEach(vehicle =>
            {
                vehicle.ChargeBattery();
                if (vehicle is Tesla tesla)
                {
                    // Something specific to Teslas
                }
            });

            List<IRefuelable> gasVehicles = new List<IRefuelable>()
            {
                new Cessna() { FuelCapacity = 22.4, MaximumOccupancy = 4},
                new Ram() { FuelCapacity = 19.1, MaximumOccupancy = 5},

            };

            
        }
    }
}
