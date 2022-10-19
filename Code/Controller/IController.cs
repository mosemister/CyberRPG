using Godot;

namespace CyberRPG.Controller
{
    public interface IController
    {

        void Move(Vector3 direction);
        void RotateCamera(float yaw, float pitch);

    }
}