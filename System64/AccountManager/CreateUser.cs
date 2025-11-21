using AVOS.BootCore;
using AVOS.System64.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOS.System64.AccountManager
{
    class CreateUser
    {
        public static void CreateProfile()
        {
            input:
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==========================================================");
            TextColors.TextColorWhite();
            Console.WriteLine("                                                          ");
            Console.WriteLine("                      Create New User                     ");
            Console.WriteLine("                          (1/3)                           ");
            Console.WriteLine("                                                          ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==========================================================");
            TextColors.TextColorYellow();
            Console.WriteLine("Create New User: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string inp = Kernel.usernamenew = Console.ReadLine();

            //if (inp == "")
            //{
                //TextColors.TextColorRed();
                //Console.WriteLine("It is impossible to create a user with an empty name! Try again.");
                //System.Threading.Thread.Sleep(1700);
                //goto input;
           //}
            if (inp == "")
            {

            }

        }
    }
}
