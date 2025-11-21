using AVOS.BootCore;
using AVOS.System64.Colors;
using Cosmos.Core_Asm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOS.System64.AccountManager.PasswordManager
{
    class DeletePassword
    {
        public static void DelPassword()
        {
            if (Kernel.password1 == "")
            {
                TextColors.TextColorDarkGray();
                Console.WriteLine("============================================================");
                TextColors.TextColorWhite();
                Console.WriteLine("You can't delete the password because it's empty!");
                TextColors.TextColorDarkGray();
                Console.WriteLine("============================================================");
            }
            input:
            Console.Clear();
            TextColors.TextColorDarkGray();
            Console.WriteLine("============================================================");
            TextColors.TextColorRed();
            Console.WriteLine("If you delete the password, it will reduce the security!");
            TextColors.TextColorWhite();
            string inp = ISteram.In("Please enter your password: ");
            if (inp == Kernel.password1)
            {
                TextColors.TextColorWhite();
                Console.WriteLine("Your password has been successfully deleted!");
                Console.WriteLine("The password can be created using the command \"createpassword!\"");
                TextColors.TextColorDarkGray();
                Console.WriteLine("============================================================");
                Kernel.password1 = "";
            }
            else
            {
                TextColors.TextColorWhite();
                Console.WriteLine("You have entered an incorrect password. \nPlease try again.");
                TextColors.TextColorDarkGray();
                Console.WriteLine("============================================================");
                System.Threading.Thread.Sleep(2000);
                goto input;
            }
        }
    }
}
