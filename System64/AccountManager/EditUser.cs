using AVOS.System64.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOS.System64.AccountManager
{
    class EditUser
    {
        public static void Edit()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("========================================================");
            TextColors.TextColorWhite();
            Console.WriteLine("Default UserName: " + Kernel.username.ToString());
            TextColors.TextColorMagenta();
            Console.WriteLine("Enter new UserName: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Kernel.username = Console.ReadLine();
            TextColors.TextColorWhite();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("========================================================");
        }
    }
}
