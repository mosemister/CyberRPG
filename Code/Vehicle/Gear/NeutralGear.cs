using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberRPG.Vehicle.Gear;

namespace CyberRPG.Vehicle.Gear
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
