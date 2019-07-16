using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    interface IRefuelable
    {
        double FuelCapacity { get; set; }
        void RefuelTank();
    }
}
