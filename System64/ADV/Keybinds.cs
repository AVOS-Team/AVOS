using IL2CPU.API.Attribs;
using Cosmos.HAL;
using System;
using APIAVOS.API.ConsoleEngine;
using AVOS.System64.Drivers.Keyboard;

namespace AVOS.System64.ADV
{
    [Plug(Target = typeof(Cosmos.System.Global))]
    public static class Keybinds
    {
        public static bool numlock = Cosmos.System.Global.NumLock;
        public static bool capslock = Cosmos.System.Global.CapsLock;
        public static bool scrolllock = Cosmos.System.Global.ScrollLock;
        public static void Init(bool initScrollWheel = true, bool initPS2 = true, bool initNetwork = true, bool ideInit = true, bool initNumLook = true)
        {
            Cosmos.System.Global.NumLock = false;
            Cosmos.System.Global.CapsLock = false;
            Cosmos.System.Global.ScrollLock = false;
        }
    }
}