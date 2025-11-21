using AVOS.System64.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOS.System64.AccountManager.PINManager
{
    class CreatePIN
    {
        public static void CrePIN()
        {
            if (Kernel.PIN != "")
            {
                TextColors.TextColorDarkGray();
                Console.WriteLine("============================================================");
                TextColors.TextColorWhite();
                Console.WriteLine("You can't create a pin-code, because you already have one!");
                TextColors.TextColorDarkGray();
                Console.WriteLine("============================================================");
            }
            if (Kernel.PIN == "")
            {
                TextColors.TextColorDarkGray();
                Console.WriteLine("============================================================");
                TextColors.TextColorWhite();
                Console.WriteLine("Write a new pin-code: ");
                TextColors.TextColorCyan();
                Kernel.PIN = Console.ReadLine();
                TextColors.TextColorWhite();
                Console.WriteLine("Your pin-code: " + Kernel.PIN.ToString());
                TextColors.TextColorDarkGray();
                Console.WriteLine("============================================================");
            }
        }
    }
}
