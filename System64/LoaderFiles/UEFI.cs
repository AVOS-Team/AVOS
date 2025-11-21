using AVOS.BootCore;
using AVOS.System64.Colors;
using Cosmos.Core_Asm;
using Cosmos.System.Graphics;
using System;
using Cosmos.HAL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOS.System64.LoaderFiles
{
    class UEFI
    {
        // Конфиг

        #region Конфиг

        public static Boolean SecureBoot = true;
        public static string BIOSPassword = "Not-Installed";
        public static string BIOSPassword1 = null;
        public static Boolean ASCIIFont = false;

        #endregion
        public static void Password()
        {

            if (BIOSPassword == "Not-Installed")
            {
                BIOS();
            }

            if (BIOSPassword1 == "Installed")
            {
                INPUT:
                Console.Clear();
                TextColors.TextColorWhite();
                string inp = ISteram.In("Enter BIOSPassword: ");
                
                if (inp == BIOSPassword)
                {
                    BIOS();
                }

                else
                {
                    TextColors.TextColorRed();
                    Console.WriteLine("Try to enter the correct password again");
                    goto INPUT;
                }
            }
        }

        public static void BIOS()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("================================================================================");
            TextColors.TextColorWhite();
            Console.WriteLine("                                       UEFI                                     ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("================================================================================");
            TextColors.TextColorWhite();
            Console.WriteLine("");
            Console.WriteLine("1) SecureBoot: " + SecureBoot.ToString());
            Console.WriteLine("");
            Console.WriteLine("2) BIOS Password: " + BIOSPassword.ToString());
            Console.WriteLine("");
            Console.WriteLine("3) Font ASCII: " + ASCIIFont.ToString());
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("================================================================================");
            TextColors.TextColorWhite();
            Console.WriteLine("                              Control keys:                                     ");
            Console.WriteLine("Press ESC to switch to Loader");
            Console.WriteLine("Press F1 to edit the values");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("================================================================================");
            TextColors.TextColorWhite();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;

                    if (key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(1000);
                        BootMenu.Show();
                        return;
                    }

                    else if (key == ConsoleKey.F1)
                    {
                        EditUEFI();
                        return;
                    }

                }
            }
        }

        public static void EditUEFI()
        {
            string inp = ISteram.In("Write down what you want to change: ");

            if (inp == "1")
            {
                string inpz = ISteram.In("Write \"true\" or \"false\": ");
                if (inpz == "true")
                {
                    Console.WriteLine("Successfully");
                    SecureBoot = true;
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    Password();
                    
                }

                if (inpz == "false")
                {
                    Console.WriteLine("Successfully");
                    SecureBoot = false;
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    Password();
                }
            }

            if (inp == "2")
            {

                BIOSPassword = ISteram.In("Write a password: ");
                BIOSPassword1 = "Installed";
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Successfully");
                Console.Clear();
                BootMenu.Show();
            }

            if (inp == "3")
            {
                string inps = ISteram.In("Write \"true\" or \"false\": ");
                if (inps == "true")
                {
                    Console.OutputEncoding = Cosmos.System.ExtendedASCII.CosmosEncodingProvider.Instance.GetEncoding(437);
                    ASCIIFont = true;
                    Console.WriteLine("Successfully");
                    Password();
                }

                else
                {
                    ASCIIFont = false;
                    Console.Clear();
                    Console.WriteLine("Successfully");
                    Password();
                }
            }
        }
    }


    class UEFIError
    {
        public static void SecureBootError()
        {
            Kernel.CLS();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("========================================================");
            TextColors.TextColorRed();
            Console.WriteLine(" [ ERROR: ] StopCVode: AS401WQ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("========================================================");
            TextColors.TextColorRed();
            Console.WriteLine("Error means: SecureBoot is off");
        }

        public static void SecureBootCrash()
        {
            SecureBootError();

            TextColors.TextColorWhite();
            Console.WriteLine("Press any key to reboot UEFI...");
            Console.ReadKey();
            System.Threading.Thread.Sleep(3000);
            Kernel.CLS();
            UEFI.BIOS();
        }
    }
}
