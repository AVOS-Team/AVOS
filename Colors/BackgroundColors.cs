using System;
using Cosmos.HAL.BlockDevice.Registers;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using AVOS;
using System.IO;
using Cosmos.Common.Extensions;
using IL2CPU.API.Attribs;
using Cosmos.System.Graphics;
using Cosmos.HAL.Audio;
using Cosmos.HAL.Network;
using Cosmos.Core.IOGroup;
using Cosmos.System.ExtendedASCII;
// ничего\
using Cosmos.System.Audio.IO;
using Cosmos.System.Audio;
using AVOS.BootCore;
using AVOS.System64;
using System.Media;
using AVOS.KernelLibs.native;
using AVOS.BootCore.Libraries.runtime;
using Cosmos.Common;
using System.Security.Cryptography.X509Certificates;
using AVOS.KernelLibs.native.IOsterams;
using AVOS.Core.Vendor;
using AVOS.Core;

namespace AVOS.System64.Colors
{
    class BackgroundColors
    {
        public static void BackgroundColorRed()
        {
            Console.BackgroundColor = ConsoleColor.Red;
        }

        public static void BackgroundColorYellow()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
        }

        public static void BackgroundColorGreen()
        {
            Console.BackgroundColor = ConsoleColor.Green;
        }

        public static void BackgroundColorWhite()
        {
            Console.BackgroundColor = ConsoleColor.White;
        }

        public static void BackgroundColorBlue()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
        }

        public static void BackgroundColorBlack()
        {
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public static void BackgroundColorCyan()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
        }

        public static void BackgroundColorDarkBlue()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
        }
        public static void BackgroundColorDarkCyan()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
        }
        public static void BackgroundColorDarkGray()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
        }

        public static void BackgroundColorDarkGreen()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
        }
        public static void BackgroundColorDarkMagenta()
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
        }
        public static void BackgroundColorDarkRed()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
        }
        public static void BackgroundColorDarkYellow()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
        }
        public static void BackgroundColorGray()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
        }
        public static void BackgroundColorMagenta()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
        }
    }
}
