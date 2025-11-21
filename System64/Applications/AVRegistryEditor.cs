using APIAVOS.API.ConsoleEngine;
using AVOS.BootCore;
using AVOS.System64.Colors;
using AVOS.System64.Drivers.Keyboard;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOS.System64.Applications
{
    class AVRegistryEditor
    {
        public static string AVRegistryEditorVersion = "1.5.0";
        public static string AviabileID = "01 (Username), 02 (Password), 03 (UserType), 04 (KeyboardLayout), 05 (ComputerName), 06 (DevelopersTools), 07 (CertificateAVOS), 08 (LicenseAgreement)";
        public static void AVRegistryEditorCMD()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("=================================================================");
            TextColors.TextColorWhite();
            Console.WriteLine("AVOS_username (ID: #01): " + Kernel.username.ToString());
            Console.WriteLine("AVOS_password (ID: #02): " + Kernel.password1.ToString());
            Console.WriteLine("AVOS_usertype (ID: #03): " + Kernel.userLogged.ToString());
            Console.WriteLine("AVOS_keyboardlayuot (ID: #04): " + Kernel.KeyboardSelected.ToString());
            Console.WriteLine("AVOS_computername (ID: #05): " + Kernel.ComputerName.ToString());
            Console.WriteLine("AVOS_developertools (ID: #06): " + Kernel.DeveloperTools.ToString());
            Console.WriteLine("AVOS_certificateavos (ID: #07): " + Kernel.CertificateAVOS.ToString());
            Console.WriteLine("AVOS_licenseagreement (ID: #08): " + Kernel.LicenseAgreement.ToString());
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("=================================================================");
            TextColors.TextColorWhite();
            string inp = ISteram.In("Do you want to edit the values? Write \"Y\", if not, then write \"N\": ");
            
            if (inp == "Y")
            {
                System.Threading.Thread.Sleep(1300);
                AVRegistryEditorEdit.Edit();
            }
        }
    }

    class AVRegistryEditorWR
    {
        public static void AVREWR()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("=================================================================");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                              [WARNING]                 ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("=================================================================");
            TextColors.TextColorRed();
            Console.WriteLine("USE THE REGISTRY EDITOR CAREFULLY, IF YOU ENTER THE WRONG VALUE,\nIT CAN LEAD TO SERIOUS ERRORS IN THE SYSTEM!");
            Console.WriteLine("");
            TextColors.TextColorWhite();
            string inp = ISteram.In("Enter \"y\" to consent to use this app, if you understand what you are doing,\nenter \"n\" to leave the app!: ");

            if (inp == "y")
            {
                System.Threading.Thread.Sleep(1300);
                AVRegistryEditor.AVRegistryEditorCMD();
            }

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("=================================================================");
        }
    }

    class AVRegistryEditorEdit
    {
        public static void Edit()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("=================================================================");
            TextColors.TextColorWhite();
            Console.WriteLine("Aviabive ID: " + AVRegistryEditor.AviabileID.ToString());
            string inp = ISteram.In("Enter the ID to edit the value: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("=================================================================");

            if (inp == "01")
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("=================================================================");
                TextColors.TextColorWhite();
                Console.WriteLine("Enter new value: ");
                TextColors.TextColorMagenta();
                Kernel.username = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("=================================================================");
            }

            if (inp == "02")
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("=================================================================");
                TextColors.TextColorWhite();
                Console.WriteLine("Enter new value: ");
                TextColors.TextColorMagenta();
                Kernel.password1 = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("=================================================================");
            }

            if (inp == "03")
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("=================================================================");
                TextColors.TextColorWhite();
                Console.WriteLine("Available Value: " + Kernel.AvailableUserType.ToString());
                Console.WriteLine("Enter new value: ");
                TextColors.TextColorMagenta();
                string inp2 = Kernel.userLogged = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("=================================================================");

                if (inp2 == "Admin")

                {
                    string inpz = ISteram.In("Are you sure?");

                    if(inpz == "yes")
                    {
                        Kernel.userLogged = "Admin";
                    }
                }

                if (inp2 == "Root")

                {
                    string inps = ISteram.In("Are you sure?");

                    if(inps == "yes")
                    {
                        Kernel.userLogged = "Root";
                    }

                }

                if (inp2 == "Usual")

                {
                    string inpf = ISteram.In("Are you sure?");

                    if(inpf == "yes")
                    {
                        Kernel.userLogged = "Usual";
                    }
                }

                if (inp2 == "Dev")

                {
                    string inpe = ISteram.In("Are you sure?");

                    if(inpe == "yes")
                    {
                        Kernel.userLogged = "Dev";
                        Kernel.DeveloperTools = true;
                    }
                }

                if (inp2 == "Tester")

                {
                    string inpm = ISteram.In("Are you sure?");
                    if(inpm == "yes")
                    {
                        Kernel.userLogged = "Tester";
                    }
                }
            }

            if (inp == "04")

                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("=================================================================");
                    TextColors.TextColorWhite();
                    Console.WriteLine("Available Value: " + Kernel.AvailableKeyboardMap.ToString());
                    Console.WriteLine("Enter new value: ");
                    TextColors.TextColorMagenta();
                    string inp3 = Kernel.KeyboardSelected = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("=================================================================");

                    if (inp3 == "ENG")

                    {
                        KeyboardDriver.KeyBoardUS();
                        Console.WriteLine("Successfully");
                        Kernel.KeyboardSelected = "ENG";
                    }

                    if (inp3 == "fr")

                    {
                        KeyboardDriver.KeyboardFR();
                        Console.WriteLine("Successfully");
                        Kernel.KeyboardSelected = "FRA";
                    }

                    if (inp3 == "ES")

                    {
                        KeyboardDriver.KeyboardES();
                        Console.WriteLine("Successfully");
                        Kernel.KeyboardSelected = "ES";
                    }

                    if (inp3 == "TR")

                    {
                        KeyboardDriver.KeyboardTR();
                        Console.WriteLine("Successfully");
                        Kernel.KeyboardSelected = "TR";
                    }

                    if (inp3 == "GB")

                    {
                        KeyboardDriver.KeyboardGB();
                        Console.WriteLine("Successfully");
                        Kernel.KeyboardSelected = "GB";
                    }

                    if (inp3 == "DE")

                    {
                        KeyboardDriver.KeyboardDE();
                        Console.WriteLine("Successfully");
                        Kernel.KeyboardSelected = "DEU";
                    }
                    if (inp3 == "us-d")
                    {
                       TextColors.TextColorRed();
                       Console.WriteLine();
                       string inp2 = ISteram.In("Are you sure? This is a special keyboard layout.\nWrite \"Yes\" to enable, \"No\" to opt out.");

                       if (inp2 == "Yes")
                       {   
                       KeyboardDriver.KeyboardUSDvorak();
                       Kernel.KeyboardSelected = "US-D";
                       Console.WriteLine("Successfully");
                       }

                       if (inp2 == "No")
                       {
                        Console.WriteLine("Okay");
                       }
                }

                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("=================================================================");
                }

            if (inp == "05")

                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("=================================================================");
                    TextColors.TextColorWhite();
                    Console.WriteLine("Enter new value: ");
                    TextColors.TextColorMagenta();
                    Kernel.ComputerName = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("=================================================================");
                }

            if (inp == "06")

                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("=================================================================");
                    TextColors.TextColorWhite();
                    string inp4 = ISteram.In("Enter new value (true, false): ");
                    TextColors.TextColorMagenta();
                    
                    if (inp4 == "true" + "True")
                    {
                        string inpk = ISteram.In("Are you sure?"); 
                        if(inpk == "true")
                    {
                        Kernel.DeveloperTools = true;
                    }
                    }

                    if (inp4 == "false" + "False")
                    {
                        string inpp = ISteram.In("Are you sure?");
                        if(inpp == "false")
                    {
                        Kernel.DeveloperTools = false;
                    }
                    Kernel.DeveloperTools = false;
                    }
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("=================================================================");
                }
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("=================================================================");

            if (inp == "07")

            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("=================================================================");

                TextColors.TextColorWhite();
                string inp5 = ISteram.In("Enter new value (true, false): ");
                TextColors.TextColorMagenta();

                if (inp5 == "true" + "True")
                {
                    Kernel.CertificateAVOS = true;
                }

                if (inp5 == "false" + "False")
                {
                    Kernel.CertificateAVOS = false;
                }
            }
            
            if (inp == "08")
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("=================================================================");

                TextColors.TextColorWhite();
                string inp5 = ISteram.In("Enter new value (true, false): ");
                TextColors.TextColorMagenta();

                if (inp5 == "true" + "True")
                {
                    Kernel.LicenseAgreement = true;
                }

                if (inp5 == "false" + "False")
                {
                    Kernel.LicenseAgreement = false;
                }
            }

        }
    
    }

}

