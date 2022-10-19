using CyberRPG.Character;
using CyberRPG.Controller;
using Godot;
using System;

namespace CyberRPG.User
{
	public class Player : IController
	{
		public void Move(Vector3 direction)
		{
			CyberRPG.GetActiveCamera().Move(direction);
		}

		public void RotateCamera(float yaw, float pitch)
		{
			CyberRPG.GetActiveCamera().RotateCamera(yaw, pitch);
		}
	}
}
