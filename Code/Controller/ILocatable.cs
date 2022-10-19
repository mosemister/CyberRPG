using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberRPG.Code.Controller
{
    public interface ILocatable
    {
        Vector3 GetLocationInWorld();

        Vector3 Distance()
        {

        }
    }
}
