public namespace World.Vehicles.Interfaces.Gear
{
    public class GearSet
    {

        private Gear[] gears { get; }

        public int GetMaximumGear()
        {
            Gear maximum;
            foreach (Gear gear in this.gears)
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
                throw new RuntimeException("Cannot find maximum gear number");
            }
            return maximum;
        }

        public int GetMinimumGear()
        {
            Gear minimum;
            foreach (Gear gear in this.gears)
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
                throw new RuntimeException("Cannot find minimum gear number");
            }
            return minimum;
        }

        public Gear GetGear(int index)
        {
            foreach (Gear gear in this.gears)
            {
                if (gear.GetGearNumber() == index)
                {
                    return gear;
                }
            }
            throw new IndexOutOfBoundsException("No gear with " + index + "");
        }
    }
}