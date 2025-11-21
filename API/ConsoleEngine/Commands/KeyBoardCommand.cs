using AVOS;
using AVOS.BootCore;
using AVOS.System64.Colors;
using AVOS.System64.Drivers.Keyboard;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIAVOS.API.ConsoleEngine.Commands
{
    public class KeyboardCommand
    {
        public static void KeyboardCMD()
        {
            string inp = ISteram.In("Enter \"en, fr, es, tr, de, gb, us-d\" to change the keyboard layout: ");

            if (inp == "en")
            {
                KeyboardDriver.KeyBoardUS();
                Kernel.KeyboardSelected = "ENG";
                Console.WriteLine("Successfully");
                Directory.CreateDirectory(@"0:\AVOS\Settings\");
                File.Create(@"0:\AVOS\Settings\KeyboardLayout.txt");
                File.WriteAllText(@"0:\AVOS\Settings\KeyboardLayout.txt", Kernel.KeyboardSelected);
            }

            if (inp == "fr")
            {
                KeyboardDriver.KeyboardFR();
                Kernel.KeyboardSelected = "FRA";
                Console.WriteLine("Successfully");
                Directory.CreateDirectory(@"0:\AVOS\Settings\");
                File.Create(@"0:\AVOS\Settings\KeyboardLayout.txt");
                File.WriteAllText(@"0:\AVOS\Settings\KeyboardLayout.txt", Kernel.KeyboardSelected);
            }

            if (inp == "es")
            {
                KeyboardDriver.KeyboardES();
                Kernel.KeyboardSelected = "ES";
                Console.WriteLine("Successfully");
                Directory.CreateDirectory(@"0:\AVOS\Settings\");
                File.Create(@"0:\AVOS\Settings\KeyboardLayout.txt");
                File.WriteAllText(@"0:\AVOS\Settings\KeyboardLayout.txt", Kernel.KeyboardSelected);
            }

            if (inp == "tr")
            {
                KeyboardDriver.KeyboardTR();
                Kernel.KeyboardSelected = "TR";
                Console.WriteLine("Successfully");
                Directory.CreateDirectory(@"0:\AVOS\Settings\");
                File.Create(@"0:\AVOS\Settings\KeyboardLayout.txt");
                File.WriteAllText(@"0:\AVOS\Settings\KeyboardLayout.txt", Kernel.KeyboardSelected);
            }

            if (inp == "de")
            {
                KeyboardDriver.KeyboardDE();
                Kernel.KeyboardSelected = "DEU";
                Console.WriteLine("Successfully");
                Directory.CreateDirectory(@"0:\AVOS\Settings\");
                File.Create(@"0:\AVOS\Settings\KeyboardLayout.txt");
                File.WriteAllText(@"0:\AVOS\Settings\KeyboardLayout.txt", Kernel.KeyboardSelected);
            }

            if (inp == "gb")
            {
                KeyboardDriver.KeyboardGB();
                Kernel.KeyboardSelected = "GB";
                Console.WriteLine("Successfully");
                Directory.CreateDirectory(@"0:\AVOS\Settings\");
                File.Create(@"0:\AVOS\Settings\KeyboardLayout.txt");
                File.WriteAllText(@"0:\AVOS\Settings\KeyboardLayout.txt", Kernel.KeyboardSelected);
            }

            if (inp == "us-d")
            {
                TextColors.TextColorRed();
                Console.WriteLine();
                string inp2 = ISteram.In("Are you sure? This is a special keyboard layout.\nWrite \"Yes\" to enable, \"No\" to opt out.");

                if (inp2 == "Yes")
                {
                    KeyboardDriver.KeyboardUSDvorak();
                    Kernel.KeyboardSelected = "US-D";
                    Console.WriteLine("Successfully");
                    Directory.CreateDirectory(@"0:\AVOS\Settings\");
                    File.Create(@"0:\AVOS\Settings\KeyboardLayout.txt");
                    File.WriteAllText(@"0:\AVOS\Settings\KeyboardLayout.txt", Kernel.KeyboardSelected);
                }

                if (inp2 == "No")
                {
                    Console.WriteLine("Okay");
                }
            }
        }
    }
}
