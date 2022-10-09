using System;

namespace World.Vehicles.Interfaces.Gear
{
    public class GearSet
    {

        private IGear[] Gears { get; }

        public IGear GetMaximumGear()
        {
            IGear maximum = null;
            foreach (IGear gear in this.Gears)
            {
                if (maximum == null)
                {
                    maximum = gear;
                    continue;
                }
                if (maximum.GetGearNumber() < gear.GetGearNumber())
                {
                    maximum = gear;
                }
            }
            if (maximum == null)
            {
                throw new SystemException("Cannot find maximum gear number");
            }
            return maximum;
        }

        public IGear GetMinimumGear()
        {
            IGear minimum = null;
            foreach (IGear gear in this.Gears)
            {
                if (minimum == null)
                {
                    minimum = gear;
                    continue;
                }
                if (minimum.GetGearNumber() < gear.GetGearNumber())
                {
                    minimum = gear;
                }
            }
            if (minimum == null)
            {
                throw new SystemException("Cannot find minimum gear number");
            }
            return minimum;
        }

        public IGear GetGear(int index)
        {
            foreach (IGear gear in this.Gears)
            {
                if (gear.GetGearNumber() == index)
                {
                    return gear;
                }
            }
            throw new IndexOutOfRangeException("No gear with " + index + "");
        }
    }
}