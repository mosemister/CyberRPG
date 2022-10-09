using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberRPG.World.Roads
{
    public interface IRoad
    {
        Lane[] Lanes { get; }
    }
}
