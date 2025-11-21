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
using Cosmos.System.Audio.IO;
using Cosmos.System.Audio;
using AVOS.BootCore;
using AVOS.System64;
using System.Media;
using AVOS.KernelLibs.native;
using AVOS.BootCore.Libraries.runtime;

namespace AVOS.KernelLibs.native
{
    class testaudio
    {
        public static void TestAudio()
        {
            Console.WriteLine("Testing audio in tree seconds - (3)");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Testing audio in two seconds  - (2)");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Testing audio in one seconds  - (1)");
            System.Threading.Thread.Sleep(1000);
            Sys.PCSpeaker.Beep();
            Sys.PCSpeaker.Beep();
            Sys.PCSpeaker.Beep();
            System.Threading.Thread.Sleep(1000);
            string inp = ISteram.In("If you hear a sound, then write 'y', if you can't hear it, then write 'n'?  ");
            if (inp == "y")
            {
                Console.WriteLine("Okay, it's good that the audio test was successful");
            }
            if (inp == "n")
            {
                Console.WriteLine("Write to Telegram '@avos_feedback', your problem with sound");
            }
        }
    }
}
