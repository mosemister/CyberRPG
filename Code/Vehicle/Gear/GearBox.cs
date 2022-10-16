using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using World.Vehicles.Interfaces.Gear;

namespace CyberRPG.Vehicle.Gear
{
    public class GearBox
    {
        private readonly GearSet gearSet;
        private int currentGear;

        public GearBox(GearSet gearSet)
        {
            this.gearSet = gearSet;
        }

        public int GetCurrentGear()
        {
            return this.currentGear;
        }

        public void SetCurrentGear(int gear)
        {
            if (this.gearSet.GetMaximumGear().GetGearNumber() < gear)
            {
                throw new SystemException("Gearbox does not have a gear " + gear);
            }
            if (this.gearSet.GetMinimumGear().GetGearNumber() > gear)
            {
                throw new SystemException("Gearbox does not have a gear " + gear);
            }
            this.currentGear = gear;
        }

    }
}
