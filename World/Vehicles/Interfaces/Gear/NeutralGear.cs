using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using World.Vehicles.Interfaces.Gear;

namespace CyberRPG.World.Vehicles.Interfaces.Gear
{
    public class NeutralGear : IGear
    {
        public int GetGearNumber()
        {
            return 0;
        }

        public float GetMaximumSpeed()
        {
            return 0;
        }

        public float GetMinimumRevingSpeed()
        {
            return 0;
        }
    }
}
