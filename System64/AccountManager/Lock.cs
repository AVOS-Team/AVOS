using AVOS.BootCore;
using AVOS.System64.Colors;
using AVOS.System64.Security;
using Cosmos.HAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOS.System64.AccountManager
{
    class Lock
    {
        public static void Locked()
        {
            string loginType = File.ReadAllText(@"0:\AVOS\UserInfo\LoginType.txt");
            string storedPass = "";
            string storedPIN = "";

            if (loginType == "Password")
                storedPass = File.ReadAllText(@"0:\AVOS\UserInfo\Password.txt");

            if (loginType == "PIN")
                storedPIN = File.ReadAllText(@"0:\AVOS\UserInfo\PIN.txt");

            int attempts = 0;
            const int maxAttempts = 5;

            input:
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("AVOS                       DateTime: " + DateTime.UtcNow + "                           Month:" + RTC.Month);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("  ");
            Console.WriteLine(@"             /$$        /$$$$$$   /$$$$$$  /$$   /$$ /$$$$$$$$ /$$$$$$$ 
            | $$       /$$__  $$ /$$__  $$| $$  /$$/| $$_____/| $$__  $$
            | $$      | $$  \ $$| $$  \__/| $$ /$$/ | $$      | $$  \ $$
            | $$      | $$  | $$| $$      | $$$$$/  | $$$$$   | $$  | $$
            | $$      | $$  | $$| $$      | $$  $$  | $$__/   | $$  | $$
            | $$      | $$  | $$| $$    $$| $$\  $$ | $$      | $$  | $$
            | $$$$$$$$|  $$$$$$/|  $$$$$$/| $$ \  $$| $$$$$$$$| $$$$$$$/
            |________/ \______/  \______/ |__/  \__/|________/|_______/ ");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                 User computer is locked. Please enter a password!");
            Console.WriteLine("    ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("                                   UserName: " + Kernel.username);
            Console.WriteLine("    ");
            TextColors.TextColorYellow();
            if (loginType == "Password")
                Console.WriteLine("Please enter your password: ");
            else
                Console.WriteLine("Please enter your PIN:");

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            string inputValue = SecureInput.ReadHidden();

            bool correct =
                (loginType == "Password" && inputValue == storedPass) ||
                (loginType == "PIN" && inputValue == storedPIN);
            if (correct)
            {
                Kernel.InLogged = true;
                Console.WriteLine();
                Console.WriteLine("      ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("                The screen is unlocked. Press the key to continue");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            attempts++;
            if (attempts >= maxAttempts)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("            Too many failed attempts. System locked.");
                System.Threading.Thread.Sleep(3000);
                PowerCTL.Shutdown();
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid " + loginType.ToLower() + ". Attempts left: " + (maxAttempts - attempts));
            System.Threading.Thread.Sleep(1500);
            goto input;
        }
    }
}
