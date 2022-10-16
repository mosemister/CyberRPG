using System.Collections.Generic;
using CyberRPG.User.Mission.Objective;

namespace CyberRPG.User.Mission
{

    public interface IMission
    {

        public ICollection<IObjective> Objectives { get; }

    }
}