public namespace World.Vehicles.Interfaces.Gear
{
    public class Gear 
    {

        private float maxSpeed {get;}
        private float revSpeedStart {get;}
        private int gearNumber {get;}

        public float GetMaximumSpeed(){
            return this.getMaximumSpeed;
        }

        public float GetMinimumRevingSpeed(){
            return this.GetMinimumRevingSpeed;
        }

        public int GetGearNumber(){
            return this.gearNumber;
        }
    }
    
}