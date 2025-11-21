using APIAVOS.API.ConsoleEngine;
using AVOS.BootCore;
using AVOS.System64.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOS.KernelLibs.native.IOsterams
{
    class Warring
    {
        public static void warring()
        {
            TextColors.TextColorDarkGray();
            ISteram.OutLN("========================================================================================");
            AdvancedConsoleAPI.WriteLineWarning();
            TextColors.TextColorWhite();
            ISteram.OutLN("\nSometimes the system, commands and the kernel may give an error,\nif your processor has flown, then restart the computer");
            TextColors.TextColorDarkGray();
            ISteram.OutLN("========================================================================================");
            TextColors.TextColorWhite();
            ISteram.OutLN("Press key to continue");

            Console.ReadKey();

            Console.Clear();
        }
    }
}
