using System;
using CyberRPG.World;
using Godot;

namespace CyberRPG.Camera
{
	public class DebugCamera : Spatial, ICamera
	{

		public static string FORWARD = "debug_move_forward";
		public static string BACKWARD = "debug_move_backward";
		public static string LEFT = "debug_move_left";
		public static string RIGHT = "debug_move_right";


		public static string ROTATE_UP = "debug_rotate_up";
		public static string ROTATE_DOWN = "debug_rotate_down";
		public static string ROTATE_LEFT = "debug_rotate_left";
		public static string ROTATE_RIGHT = "debug_rotate_right";

		public static float MOVE_SPEED = 0.1f;
		public static float ROTATION_SENSTIVITY = 0.01f;
		public static float CONTROLLER_SENSTIVITY = 0.1f;

		public override void _Ready()
		{
			Input.MouseMode = Input.MouseModeEnum.Captured;
		}

		public override void _Input(InputEvent @event)
		{
			if (@event is InputEventMouseMotion eventMotion)
			{
				Rotate(-(eventMotion.Relative.x * ROTATION_SENSTIVITY), -(eventMotion.Relative.y * ROTATION_SENSTIVITY));
			}
		}


		public override void _Process(float delta)
		{
			float sidewaysSpeed = Input.GetActionStrength(RIGHT) - Input.GetActionStrength(LEFT);
			float forwardSpeed = Input.GetActionStrength(BACKWARD) - Input.GetActionStrength(FORWARD);
			Move(new Vector3(forwardSpeed, 0, sidewaysSpeed));

			float rotationYaw = Input.GetActionStrength(ROTATE_LEFT) - Input.GetActionStrength(ROTATE_RIGHT);
			float rotationPitch = Input.GetActionStrength(ROTATE_DOWN) - Input.GetActionStrength(ROTATE_UP);
			Rotate((rotationYaw * CONTROLLER_SENSTIVITY), -(rotationPitch * CONTROLLER_SENSTIVITY));

		}

		private void Rotate(float yaw, float pitch)
		{
			this.Rotation += new Vector3(pitch, yaw, 0);
		}

		private void Move(Vector3 direction)
		{
			if (direction == Vector3.Zero)
			{
				return;
			}
			float cameraYaw = this.Rotation.y;

			Vector3 directionToUse = new Vector3(direction.z, direction.y, direction.x).Rotated(Vector3.Up, cameraYaw);
			Vector3 directionOfUse = new Vector3(directionToUse.x * MOVE_SPEED, directionToUse.y, directionToUse.z * MOVE_SPEED);

			Vector3 origin = this.Transform.origin;
			origin += directionOfUse;
			Transform transform = new Transform(this.Transform.basis, origin);
			this.Transform = transform;
		}
	}
}
