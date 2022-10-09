using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using World.Vehicles.Interfaces.Gear;

namespace CyberRPG.World.Vehicles.Interfaces.Gear
{
    public class ReverseGear : IGear
    {
        public int GetGearNumber()
        {
            return -1;
        }

        public float GetMaximumSpeed()
        {
            return -10;
        }

        public float GetMinimumRevingSpeed()
        {
            return 0;
        }
    }
}
