using System.Runtime.Serialization;
using CyberRPG.User.Mission.Objective.Result;

namespace CyberRPG.User.Mission.Objective.Result
{

    public class Basic : ObjectiveResult
    {

    }

    public class ValueSuccess<V> : ObjectiveResult
    {

        public V Result { get; }

    }
}