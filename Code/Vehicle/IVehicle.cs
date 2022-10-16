using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberRPG.Vehicle;
using CyberRPG.Vehicle.Gear;

namespace CyberRPG.Vehicle
{
    public interface IVehicle
    {
        GearBox GearBox { get; }

        IDoor[] getDoors();
    }
}
