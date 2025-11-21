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
    class IOBoot2
    {
        public static void atteon()
        {
            TextColors.TextColorDarkGray();
            ISteram.OutLN("========================================================================================");
            AdvancedConsoleAPI.WriteLineInfo();
            TextColors.TextColorWhite();
            ISteram.OutLN("Some commands are not implemented,\nit is not recommended to enter these commands that are not implemented,\notherwise the system will crash.");
            TextColors.TextColorDarkGray();
            ISteram.OutLN("========================================================================================");
            TextColors.TextColorWhite();
            ISteram.OutLN("Press the key to continue");

            Console.ReadKey();

            Console.Clear();
        }
    }
}