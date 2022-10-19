using CyberRPG.Code.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberRPG.Vehicle
{
    public interface IDoor
    {
        void OpenDoor(bool animate);
        void CloseDoor(bool animate);
        DoorState GetCurrentState();
    }

    public interface IInteractableDoor : IDoor, IInteractable
    {
    }
}
