using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberRPG.World.Roads.Flat.SingleLane.BiDirection
{

    public class StandardSingleLaneBiDirection : Spatial, IRoad
    {
        public Lane[] Lanes => new Lane[0];
    }
}
