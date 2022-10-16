using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Godot;

namespace CyberRPG.Vehicle.Road.Flat.BiDirection
{

    public class StandardSingleLaneBiDirection : Spatial, IRoad
    {
        public Lane[] Lanes => new Lane[0];
    }
}
