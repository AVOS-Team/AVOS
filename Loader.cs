using AVOS.BootCore;
using AVOS.System64.Colors;
using AVOS.System64.LoaderFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOS
{
    class Loader
    {
        public static void Load()
        {
            input:
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==========================================================");
            TextColors.TextColorWhite();
            Console.WriteLine("                         Loader                           ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==========================================================");
            TextColors.TextColorWhite();
            Console.WriteLine("You can boot into the \"System (1)\" or into the \"UEFI (2)\"");
            string inp = ISteram.In("Write where to boot: ");

            if (inp == null )
            {
                Console.WriteLine("Tell me again where to upload to");
                System.Threading.Thread.Sleep(2400);
                goto input;
            }
            if (inp == "1")
            {
                Console.Clear();
            }
            if (inp == "2")
            {
                UEFI.Password();
            }
        }
    }
}
