using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberRPG.Vehicle.Gear;

namespace CyberRPG.Vehicle.Gear
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
