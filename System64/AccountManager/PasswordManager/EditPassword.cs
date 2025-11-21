using AVOS.System64.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOS.System64.AccountManager.PasswordManager
{
    class EditPassword
    {
        public static void Edit()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("========================================================");
            TextColors.TextColorWhite();
            Console.WriteLine("Default Password: " + Kernel.password1.ToString());
            TextColors.TextColorMagenta();
            Console.WriteLine("Enter new Password: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Kernel.password1 = Console.ReadLine();
            TextColors.TextColorWhite();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("========================================================");
        }
    }
}
