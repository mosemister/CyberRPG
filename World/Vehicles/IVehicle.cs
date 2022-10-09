using CyberRPG.World.Vehicles.Interfaces;
using CyberRPG.World.Vehicles.Interfaces.Gear;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberRPG.World.Vehicles
{
    public interface IVehicle
    { 
        GearBox GearBox { get; }

        IDoor[] getDoors();
    }
}
