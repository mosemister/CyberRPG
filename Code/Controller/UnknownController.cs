using Godot;

namespace CyberRPG.Controller
{
    public class UnknownController : IController
    {

        private readonly IControllable controlling;

        public UnknownController(IControllable controllable)
        {
            this.controlling = controllable;
        }


        public void Move(Vector3 direction)
        {
            this.controlling.Move(direction);
        }

        public void RotateCamera(float yaw, float pitch)
        {
            this.controlling.RotateCamera(yaw, pitch);
        }
    }
}