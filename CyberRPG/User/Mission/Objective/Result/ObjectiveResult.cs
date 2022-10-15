using System.Runtime.Serialization;
namespace CyberRPG.User.Mission.Objective.Result;

public class Basic : ObjectiveResult
{

}

public class ValueSuccess<V> : ObjectiveResult
{

    public V Result { get; }

}