using Cosmos.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sys = Cosmos.System;

namespace AVOS.System64.Drivers.Keyboard
{
    class KeyboardDriver
    {
        public static string KeyboardDriverVersion = "1.12.4";

        public static void KeyBoardUS()
        {
            KeyboardManager.SetKeyLayout(new Sys.ScanMaps.USStandardLayout());
        }

        public static void KeyboardFR()
        {
            KeyboardManager.SetKeyLayout(new Sys.ScanMaps.FRStandardLayout());
        }

        public static void KeyboardES()
        {
            KeyboardManager.SetKeyLayout(new Sys.ScanMaps.ESStandardLayout());
        }

        public static void KeyboardTR()
        {
            KeyboardManager.SetKeyLayout(new Sys.ScanMaps.TRStandardLayout());
        }

        public static void KeyboardDE() 
        {
            KeyboardManager.SetKeyLayout(new Sys.ScanMaps.DEStandardLayout());
        }

        public static void KeyboardGB()
        {
            KeyboardManager.SetKeyLayout(new Sys.ScanMaps.GBStandardLayout());
        }
        public static void KeyboardUSDvorak()
        {
            KeyboardManager.SetKeyLayout(new Sys.ScanMaps.US_Dvorak());
        }
    }
}
