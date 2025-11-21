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
    class Syntax
    {
        public static void Syntaxs()
        {
            string inp = ISteram.In("Enter the existing syntax to find out what it means. Here are all the available syntaxes (@, !, >, ;). ");

            if (inp == "@")
            {
                TextColors.TextColorDarkGray();
                Console.WriteLine("========================================================");
                TextColors.TextColorGreen();
                Console.Write("@");
                TextColors.TextColorWhite();
                Console.Write(" - This is an important syntax for the system to understand what is being used.");
                TextColors.TextColorDarkGray();
                Console.WriteLine("========================================================");
            }

            if (inp == "!")
            {
                TextColors.TextColorDarkGray();
                Console.WriteLine("========================================================");
                TextColors.TextColorGray();
                Console.Write("!");
                TextColors.TextColorWhite();
                Console.Write(" - Optional syntax but important, but it handles the information.");
                TextColors.TextColorDarkGray();
                Console.WriteLine("========================================================");
            }

            if (inp == ">")
            {
                TextColors.TextColorDarkGray();
                Console.WriteLine("========================================================");
                TextColors.TextColorDarkCyan();
                Console.Write(">");
                TextColors.TextColorWhite();
                Console.Write(" - This syntax means that you are writing in the text input field.");
                TextColors.TextColorDarkGray();
                Console.WriteLine("========================================================");
            }

            if (inp == ";")
            {
                TextColors.TextColorDarkGray();
                Console.WriteLine("========================================================");
                TextColors.TextColorDarkRed();
                Console.Write(";");
                TextColors.TextColorWhite();
                Console.Write(" - It's probably not syntax,\nbut it's the most important thing in the system code.");
                Console.WriteLine("");
                TextColors.TextColorDarkGray();
                Console.WriteLine("========================================================");
            }


        }
    }

    
}
