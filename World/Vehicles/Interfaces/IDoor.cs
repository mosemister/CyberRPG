using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberRPG.World.Vehicles.Interfaces
{
    internal interface IDoor
    {
        void OpenDoor(bool animate);
        void CloseDoor(bool animate);
        DoorState GetCurrentState();
    }
}
