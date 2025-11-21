using AVOS.BootCore;
using AVOS.System64.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVOS;

namespace AVOS.System64.AccountManager
{
    class ChangeUserType
    {
        public static void Change()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("========================================================");
            TextColors.TextColorWhite();
            Console.WriteLine("Default UserType: " + Kernel.userLogged.ToString());
            Console.WriteLine("Available UserType: " + Kernel.AvailableUserType.ToString());
            TextColors.TextColorMagenta();
            string inp = ISteram.In("Enter new UserType: ");

            if (inp == "Admin")

            {
                Kernel.userLogged = "Admin";
            }

            if (inp == "Root")

            {
                Kernel.userLogged = "Root";
                Kernel.enabledroot = true;
            }

            if (inp == "Usual")

            {
                Kernel.userLogged = "Usual";
            }

            if (inp == "Dev")

            {
                Kernel.userLogged = "Dev";
                Kernel.DeveloperTools = true;
            }

            if (inp == "Tester")

            {
                Kernel.userLogged = "Tester";
            }

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("========================================================");
        }
    }
}
