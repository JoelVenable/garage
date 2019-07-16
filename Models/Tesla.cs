using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    public class Tesla : IChargeable
    {
        public double BatteryKWh { get; set; }

        public string MainColor { get; set; }

        public int MaximumOccupancy { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine("Charging the battery...");
        }
    }
}
