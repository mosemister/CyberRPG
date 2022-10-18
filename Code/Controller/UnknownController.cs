using Godot;

namespace CyberRPG.Controller
{
    public class UnknownController : IController
    {

        private IControllable controlling;

        public UnknownController(IControllable controllable)
        {
            this.controlling = controllable;
        }


        public void Move(Vector3 direction)
        {
            this.controlling.Move(direction);
        }

        public void Rotate(float yaw, float pitch)
        {
            this.controlling.Rotate(yaw, pitch);
        }
    }
}