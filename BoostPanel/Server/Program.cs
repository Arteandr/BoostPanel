using System.IO;

namespace BoostPanel.Server
{
    public class Program
    {
        public static string cs_go_path = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Counter-Strike Global Offensive\\";
        public static string steam_path = "C:\\Program Files (x86)\\Steam\\";
        public static folder_path_checker CsGoPathSet;
        public static folder_path_checker SteamPathSet;
        private static bool _isCsGoPathRight = false;
        private static bool _isSteamPathRight = false;


        public static bool cs_go_path_right
        {
            get => _isCsGoPathRight;
            set
            {
                _isCsGoPathRight = value;
                folder_path_checker csGoPathSet = CsGoPathSet;
                if (csGoPathSet == null)
                    return;
                csGoPathSet(value);
            }
        }
        
        public static bool steam_path_right
        {
            get => _isSteamPathRight;
            set
            {
                _isSteamPathRight = value;
                folder_path_checker steamPathSet = SteamPathSet;
                if (steamPathSet == null)
                    return;
                steamPathSet(value);
            }
        }
        
        public static bool CheckSteamPath()
        {
            if (Directory.Exists(steam_path) && File.Exists(steam_path + "steam.exe"))
            {
                steam_path_right = true;
                return true;
            }
            steam_path_right = false;
            return false;
        }

        public delegate void folder_path_checker(bool status);
    }
}