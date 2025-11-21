using APIAVOS.API.Extensions.Authors.AndreyPepper;
using APIAVOS.API.Extensions.Authors.AndreyPepper.AVConversion;
using APIAVOS.API.Extensions.Authors.AndreyPepper.AVTools;
using AVOSAPI.API.Plugins.Authors.AndreyPepper.AVDiagnostics;
using AVOS.BootCore;
using AVOS.System64.Applications;
using AVOS.System64.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOS.System64.KernelCMD
{
    class KernelCommands
    {
        public static void KCMD() 
        {
            string inp = ISteram.In("Enter the available commands, for the kernel \n(kernel -i - Info Kernel, kernel -e - Extensions Kernel)\n: ");

            if (inp == "kernel -i") 
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("========================================================");
                TextColors.TextColorWhite();
                Console.WriteLine("Drivers All: Network, Keyboard.\n");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("========================================================");
            }
            if (inp == "kernel -e")
            {
                string plver1 = AVConversion.avplconver.ToString();
                string plver2 = AVTools.avpltoolsver.ToString();
                string plver3 = AVDiagnostics.avpldiagnosticsver.ToString();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("========================================================");
                TextColors.TextColorWhite();
                Console.WriteLine("AVConversion - ver {0} - Installed\nAVTools - ver {1} - Instaled\nAVDiagnostics - ver {2}", plver1, plver2, plver3);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("========================================================");

            }
        }
    }
}
