using AVOS.System64.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOS.System64.AccountManager.PasswordManager
{
    class CreatePassword
    {
        public static void CrePassword()
        {
            if (Kernel.password1 != "")
            {
                TextColors.TextColorDarkGray();
                Console.WriteLine("============================================================");
                TextColors.TextColorWhite();
                Console.WriteLine("You can't create a password, because you already have one!");
                TextColors.TextColorDarkGray();
                Console.WriteLine("============================================================");
            }
            if (Kernel.password1 == "")
            {
                TextColors.TextColorDarkGray();
                Console.WriteLine("============================================================");
                TextColors.TextColorWhite();
                Console.WriteLine("Write a new password: ");
                TextColors.TextColorCyan();
                Kernel.password1 = Console.ReadLine();
                TextColors.TextColorWhite();
                Console.WriteLine("Your password: " + Kernel.password1.ToString());
                TextColors.TextColorDarkGray();
                Console.WriteLine("============================================================");
            }
        }
    }
}
