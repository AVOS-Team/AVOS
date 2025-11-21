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
// ничего \\
using Cosmos.System.Audio.IO;
using Cosmos.System.Audio;
using AVOS.BootCore;
using AVOS.System64;
using System.Media;
using AVOS.KernelLibs.native;
using AVOS.BootCore.Libraries.runtime;
using Cosmos.Common;
using System.Security.Cryptography.X509Certificates;

namespace AVOS.KernelLibs.native.IOsterams
{
    class IOBoot
    {
        public static void ioboot()
        {
            ISteram.Clear();
            ISteram.Out(" [ AVOS.avosh ] Loading AVOS\n", ConsoleColor.Magenta);
            System.Threading.Thread.Sleep(1300);
            ISteram.Out(" [ AVOS.avosh ] Localization Initialization - Successfully\n", ConsoleColor.Magenta);
            System.Threading.Thread.Sleep(1300);
            ISteram.Out(" [ AVOS.avosh ] Loading Runtime - Successfully\n", ConsoleColor.Magenta);
            System.Threading.Thread.Sleep(1300);
            ISteram.Out(" [ AVOS.avosh ] Loading Kernel - Successfully\n", ConsoleColor.Magenta);
            System.Threading.Thread.Sleep(1300);
            ISteram.Out(" [ AVOS.avosh ] Loading KernelLibs - Successfully\n", ConsoleColor.Magenta);
            System.Threading.Thread.Sleep(1300);
            ISteram.Out(" [ AVOS.avosh ] Loading Vendor - Successfully\n", ConsoleColor.Magenta);
            System.Threading.Thread.Sleep(1300);
            ISteram.Out(" [ AVOS.avosh ] Loading Apps - Successfully\n", ConsoleColor.Magenta);
            System.Threading.Thread.Sleep(1300);
            ISteram.Out(" [ AVOS.avosh ] Create User - Successfully\n", ConsoleColor.Magenta);
            System.Threading.Thread.Sleep(1300);
            ISteram.Out(" [ AVOS.avosh ] Loading Syntaxs - Successfully\n", ConsoleColor.Magenta);
            System.Threading.Thread.Sleep(1300);
            ISteram.Out(" [ AVOS.avosh ] Loading Commands - Successfully\n", ConsoleColor.Magenta);
            System.Threading.Thread.Sleep(1000);
            ISteram.Out("Done\n");
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Clear();
        }
    }
}
