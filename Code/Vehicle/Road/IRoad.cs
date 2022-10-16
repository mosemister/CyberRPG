using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberRPG.Vehicle.Road
{
    public interface IRoad
    {
        Lane[] Lanes { get; }
    }
}
