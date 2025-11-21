using Cosmos.HAL.BlockDevice.Registers;
using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using AVOS;
using System.IO;
using Cosmos.Common.Extensions;
using Cosmos.System.Graphics;
using Cosmos.HAL.Audio;
using Cosmos.HAL.Network;
using Cosmos.Core.IOGroup;
using Cosmos.System.ExtendedASCII;


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
using AVOS.System64.Colors;
using AVOS.System64.Applications;
using IL2CPU.API.Attribs;
using Cosmos.Core;

namespace AVOS.System64
{
    class SyntaxsAll
    {
        public static void SyntaxsAl()
        {
            TextColors.TextColorDarkGray();
            Console.WriteLine("===============================================================================");
            TextColors.TextColorGreen();
            Console.Write("@");
            TextColors.TextColorWhite();
            Console.Write(" - This is an important syntax for the system to understand what is being used.\n");
            TextColors.TextColorGray();
            Console.Write("!");
            TextColors.TextColorWhite();
            Console.Write(" - Optional syntax but important, but it handles the information.\n");
            TextColors.TextColorDarkCyan();
            Console.WriteLine("");
            Console.Write(">");
            TextColors.TextColorWhite();
            Console.Write(" - This syntax means that you are writing in the text input field.\n");
            Console.WriteLine("");
            TextColors.TextColorDarkRed();
            Console.Write(";");
            TextColors.TextColorWhite();
            Console.Write(" - It's probably not syntax,\nbut it's the most important thing in the system code.");
            Console.WriteLine("");
            TextColors.TextColorDarkGray();
            Console.WriteLine("===============================================================================");
        }
    }
}
