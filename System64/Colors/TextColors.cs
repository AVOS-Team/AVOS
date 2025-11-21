using Cosmos.HAL.BlockDevice.Registers;
using System;
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
    class TextColors
    {
        public static void TextColorRed()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public static void TextColorYellow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public static void TextColorGreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public static void TextColorWhite()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void TextColorBlue()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        public static void TextColorBlack()
        {
            Console.ForegroundColor = ConsoleColor.Black;
        }
        public static void TextColorCyan()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }

        public static void TextColorDarkBlue()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }
        public static void TextColorDarkCyan()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }
        public static void TextColorDarkGray()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }

        public static void TextColorDarkGreen()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        public static void TextColorDarkMagenta()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
        }
        public static void TextColorDarkRed()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }
        public static void TextColorDarkYellow()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }
        public static void TextColorGray()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static void TextColorMagenta()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
        }

    }
}
