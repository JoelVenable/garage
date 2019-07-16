using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    interface IChargeable
    {
        double BatteryKWh { get; set; }
        void ChargeBattery();
    }
}
