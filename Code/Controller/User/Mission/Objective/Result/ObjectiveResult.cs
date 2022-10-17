using System.Runtime.Serialization;
using CyberRPG.User.Mission.Objective.Result;

namespace CyberRPG.User.Mission.Objective.Result
{

	public class Basic : IObjectiveResult
	{

		private readonly ObjectiveResultType type;

		public Basic(ObjectiveResultType type)
		{
			this.type = type;
		}

		public ObjectiveResultType GetObjectiveType()
		{
			return this.type;
		}
	}

	public class ValueSuccess<V> : Basic
	{

		private readonly V result;

		public ValueSuccess(ObjectiveResultType type, V result): base(type)
		{
			this.result = result;
		}

		public V GetResult()
		{
			return this.result;
		}

	}
}
