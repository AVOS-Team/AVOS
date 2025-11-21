using APIAVOS.API.ConsoleEngine;
using AVOS.BootCore;
using AVOS.System64.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOS.KernelLibs.native.ISterams
{
    class IOBoot3
    {
        public static void Singatyre()
        {
            TextColors.TextColorDarkGray();
            ISteram.OutLN("========================================================================================");
            AdvancedConsoleAPI.WriteLineNote();
            TextColors.TextColorWhite();
            Console.WriteLine("You have run the build without the signature of the system, \nwhich means that the build may be unofficial.");
            TextColors.TextColorDarkGray();
            ISteram.OutLN("========================================================================================");
            TextColors.TextColorWhite();
            ISteram.OutLN("Press the key to continue");

            Console.ReadKey();

            Console.Clear();
        }
    }
}
