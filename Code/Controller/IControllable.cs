using Godot;

namespace CyberRPG.Controller
{
    public interface IControllable
    {
        IController GetController();

        void Move(Vector3 direction);

        void Rotate(float yaw, float pitch);
    }
}