using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    public class Ram : IRefuelable
    {
        public double FuelCapacity { get; set; }
        public string MainColor { get; set; }

        public int MaximumOccupancy { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine("Refueling tank");
        }
    }
}
