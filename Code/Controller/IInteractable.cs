using CyberRPG.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberRPG.Code.Controller
{
    public interface IInteractable
    {

        void OnInteract(IController controller);
        bool CanInteract(IController controller);
    }
}
