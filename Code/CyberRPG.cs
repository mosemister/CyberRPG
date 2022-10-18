using System;
using CyberRPG.Camera;
using CyberRPG.User;
using CyberRPG.User.Settings;

namespace CyberRPG
{
    public class CyberRPG
    {

        private static CyberRPG instance;

        private Player player;
        private ICamera activeCamera;
        private GlobalSettings globalSettings;
        private GraphicsSettings graphicsSettings;

        private static CyberRPG GetInstance()
        {
            if (instance == null)
            {
                instance = new CyberRPG();
            }
            return instance;
        }

        public static ICamera GetActiveCamera()
        {
            ICamera camera = GetInstance().activeCamera;
            if (camera == null)
            {
                throw new SystemException("No active cameras");
            }
            return camera;
        }

        public static bool IsActiveCameraReady()
        {
            return GetInstance().activeCamera != null;
        }

        public static void SetActiveCamera(ICamera camera)
        {
            GetInstance().activeCamera = camera;
        }

        public static Player GetPlayer()
        {
            Player player = GetInstance().player;
            if (player == null)
            {
                throw new SystemException("Player has not been defined yet");
            }
            return player;
        }

        public static bool IsPlayerReady()
        {
            Player player = GetInstance().player;
            return player != null;
        }

        public static void SetPlayer(Player player)
        {
            if (player == null)
            {
                throw new ArgumentException("Player cannot be null");
            }
            if (GetInstance().player != null)
            {
                throw new SystemException("Player has already been set. Cannot set the player again");
            }
            GetInstance().player = player;
        }

        public static GlobalSettings GetGlobalSettings()
        {
            GlobalSettings settings = GetInstance().globalSettings;
            if (settings == null)
            {
                GetInstance().globalSettings = new GlobalSettings();
            }
            return GetInstance().globalSettings;
        }

        public static GraphicsSettings GetGraphicsSettings()
        {
            GraphicsSettings settings = GetInstance().graphicsSettings;
            if (settings == null)
            {
                GetInstance().graphicsSettings = new GraphicsSettings();
            }
            return GetInstance().graphicsSettings;
        }
    }
}
