using APIAVOS.API.ConsoleEngine.Commands;
using AVOS.BootCore;
using AVOS.KernelLibs.native.IOsterams;
using AVOS.KernelLibs.native.ISterams;
using AVOS.System64.AccountManager.UUID;
using AVOS.System64.Colors;
using AVOS.System64.Drivers.Keyboard;
using AVOS.System64.LoaderFiles;
using Cosmos.Core_Asm;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVOS;
using static AVOS.Kernel;
using System.Security.Cryptography.X509Certificates;
using AVOS.System64.Security;

namespace AVOS
{

    class Check
    {
        public static void CheckCer()
        {
            if (UEFI.SecureBoot == true)
            {
                if (Kernel.CertificateAVOS == true)
                {
                    Installer.install();
                    Installer2.Intsller();
                    UserInstaller.Install();
                    Kernel.CLS();
                    LicenseAgreement.License();
                    Console.Clear();
                    UUIDCreate.UUID();
                    Kernel.CLS();
                    LoginTypeSetup.Setup();
                    Kernel.CLS();
                    PasswordSetup.Setup();
                    Kernel.CLS();
                    UserTypeSetup.Setup();
                    Kernel.CLS();
                    ComputerNameSetup.Setup();
                    Kernel.CLS();
                    HostNameSetup.Setup();
                    Kernel.CLS();
                    Result.Info();
                    Kernel.CLS();
                    System.Threading.Thread.Sleep(2710);
                    IOBoot.ioboot();
                    IOBoot2.atteon();
                    if (Kernel.SystemSignature == false)
                    {
                        IOBoot3.Singatyre();
                        Warring.warring();
                    }
                    if (Kernel.SystemSignature == true)
                    {
                        Warring.warring();
                    }

                }

                else
                {
                    AVBsOD.CertificateErrorCrash();
                }
            }
            else
            {
                UEFIError.SecureBootCrash();
            }


        }
    }

    class Installer
    {
        public static void install()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==========================================================");
            TextColors.TextColorWhite();
            Console.WriteLine("                                                          ");
            Console.WriteLine("                        Installer                         ");
            Console.WriteLine("                         Page: 1                          ");
            Console.WriteLine("                                                          ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==========================================================");
            TextColors.TextColorWhite();
            string inp = ISteram.In("Allow the system to save all information in the system files? \"Yes\" or \"No\": ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==========================================================");


            if (inp == "Yes") 
            {
                Kernel.saveinfo = "Yes";
                ISteram.Out("Okay! Thank You!");
            }
            if (inp == "No")
            {
                Kernel.saveinfo = "No";
                ISteram.Out("Okay! Thank You!");
            }

            Console.Clear();
        }
        
    }

    class Installer2
    {
        public static void Intsller()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==========================================================");
            TextColors.TextColorWhite();
            Console.WriteLine("                                                          ");
            Console.WriteLine("                        Installer                         ");
            Console.WriteLine("                         Page: 2                          ");
            Console.WriteLine("                                                          ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==========================================================");
            TextColors.TextColorWhite();
            KeyboardCommand.KeyboardCMD();

            Console.Clear();
        }
    }

    class UserInstaller
    {
        public static void Install()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==========================================================");
            TextColors.TextColorWhite();
            Console.WriteLine("                                                          ");
            Console.WriteLine("                        Installer                         ");
            Console.WriteLine("                         Page: 3                          ");
            Console.WriteLine("                          (1/3)                           ");
            Console.WriteLine("                                                          ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==========================================================");
            TextColors.TextColorYellow();
            Directory.CreateDirectory(@"0:\AVOS\UserInfo\");
            Console.WriteLine("Create your Username: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Kernel.username = Console.ReadLine();
            Kernel.generalUser = Kernel.username;
            File.Create(@"0:\AVOS\UserInfo\UserName.txt");
            File.WriteAllText(@"0:\AVOS\UserInfo\UserName.txt", username);
            if (Kernel.username == "")
            {
                Kernel.username = "userAVOS";
                Kernel.generalUser = "userAVOS";
                File.WriteAllText(@"0:\AVOS\UserInfo\UserName.txt", "userAVOS");
            }
            TextColors.TextColorWhite();
        }
    }

    class LicenseAgreement
    {
        public static void License()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==========================================================");
            TextColors.TextColorWhite();
            Console.WriteLine("                                                          ");
            Console.WriteLine("                        Installer                         ");
            Console.WriteLine("                         Page: 3                          ");
            Console.WriteLine("                          (2/3)                           ");
            Console.WriteLine("                                                          ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==========================================================");
            TextColors.TextColorWhite();
            Console.WriteLine("                        LicenseAgreement                   ");
            Console.WriteLine("  ");
            Console.WriteLine("If you want to create an AVOS-based system, there should be a mention of AVOS in the code. There should also be a reference to \"powered by AVOS\" in your system's code. If you have already created a system based on AVOS, you have three days to add this reference.\r\n");
            string inp = ISteram.In("Do you want to accept the License Agreement? (Yes/No): ");

            if (inp == "Yes")
            {
                Console.Clear();
                Kernel.LicenseAgreement = true;
                File.Create(@"0:\AVOS\UserInfo\License.txt");
                File.WriteAllText(@"0:\AVOS\UserInfo\License.txt", Kernel.LicenseAgreement.ToString());
            }

            if (inp == "No")
            {
                Console.WriteLine("  ");
                TextColors.TextColorRed();
                Console.WriteLine("Unfortunately, you refused. The installation cannot be continued further.\n Press any key to turn off the computer");

                Console.ReadKey();

                PowerCTL.Shutdown();
            }
        }
    }

    class UUIDCreate
    {
        public static void UUID()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==========================================================");
            TextColors.TextColorWhite();
            Console.WriteLine("                                                          ");
            Console.WriteLine("                        Installer                         ");
            Console.WriteLine("                         Page: 3                          ");
            Console.WriteLine("                          (3/3)                           ");
            Console.WriteLine("                                                          ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==========================================================");
            TextColors.TextColorWhite();
            Console.WriteLine("You need to generate a UUID for the user. Press any key to generate.");
            Console.ReadKey();

            GeneratorUUID.UUID();

            System.Threading.Thread.Sleep(1710);
        }
    }

    class LoginTypeSetup
    {
        public static void Setup()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==========================================================");
            TextColors.TextColorWhite();
            Console.WriteLine("                                                          ");
            Console.WriteLine("                        Installer                         ");
            Console.WriteLine("                         Page: 4                          ");
            Console.WriteLine("                                                          ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==========================================================");
            TextColors.TextColorYellow();
            Console.WriteLine("Select login method:");
            Console.WriteLine("1) Password (letters + numbers)");
            Console.WriteLine("2) PIN-code (digits only)");
            TextColors.TextColorWhite();

            string inp = ISteram.In("Enter 1 or 2: ");

            if (inp == "1")
            {
                Kernel.LoginType = "Password";
                File.Create(@"0:\AVOS\UserInfo\LoginType.txt");
                File.WriteAllText(@"0:\AVOS\UserInfo\LoginType.txt", LoginType);
            }
            else if (inp == "2")
            {
                Kernel.LoginType = "PIN";
                File.Create(@"0:\AVOS\UserInfo\LoginType.txt");
                File.WriteAllText(@"0:\AVOS\UserInfo\LoginType.txt", LoginType);
            }
            else
            {
                TextColors.TextColorRed();
                Console.WriteLine("Invalid input. Default is Password.");
                Kernel.LoginType = "Password";
            }
        }
    }


    class PasswordSetup
    {
        public static void Setup() 
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==========================================================");
            TextColors.TextColorWhite();
            Console.WriteLine("                                                          ");
            Console.WriteLine("                        Installer                         ");
            Console.WriteLine("                         Page: 5                          ");
            Console.WriteLine("                                                          ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==========================================================");
            TextColors.TextColorWhite();
            if (Kernel.LoginType == "Password")
            {
                SetupPassword();
            }
            else if (Kernel.LoginType == "PIN")
            {
                SetupPIN();
            }

        }

        private static void SetupPassword()
        {
            TextColors.TextColorYellow();
            Console.WriteLine("Create your Password: ");
            TextColors.TextColorDarkYellow();

            Kernel.password1 = Console.ReadLine();

            File.WriteAllText(@"0:\AVOS\UserInfo\Password.txt", Kernel.password1);
        }

        static void SetupPIN()
        {
            while (true)
            {
                TextColors.TextColorYellow();
                Console.WriteLine("Create PIN (4–10 digits): ");
                TextColors.TextColorDarkYellow();

                string pin1 = SecureInput.ReadHidden();

                // Проверка длины
                if (pin1.Length < 4 || pin1.Length > 10)
                {
                    TextColors.TextColorRed();
                    Console.WriteLine("PIN length must be 4–10 digits! Try again.");
                    System.Threading.Thread.Sleep(1500);
                    continue; // вернуться на ввод
                }

                // Проверка цифр
                if (!pin1.All(char.IsDigit))
                {
                    TextColors.TextColorRed();
                    Console.WriteLine("PIN must contain digits only! Try again.");
                    System.Threading.Thread.Sleep(1500);
                    continue;
                }

                Console.WriteLine("Confirm PIN: ");
                string pin2 = SecureInput.ReadHidden();

                if (pin1 != pin2)
                {
                    TextColors.TextColorRed();
                    Console.WriteLine("PIN does not match! Try again.");
                    System.Threading.Thread.Sleep(1500);
                    continue;
                }

                Kernel.PIN = pin1; // сохраняем PIN
                File.WriteAllText(@"0:\AVOS\UserInfo\PIN.txt", pin1);
                break; // успешно создан PIN
            }
        }

    }

    class UserTypeSetup
    {
        public static void Setup()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==========================================================");
            TextColors.TextColorWhite();
            Console.WriteLine("                                                          ");
            Console.WriteLine("                        Installer                         ");
            Console.WriteLine("                         Page: 6                          ");
            Console.WriteLine("                                                          ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==========================================================");
            TextColors.TextColorYellow();
            Console.WriteLine("Available UserType: " + Kernel.AvailableUserType.ToString());
            TextColors.TextColorWhite();
            string inp = ISteram.In("Enter UserType: ");

            if (inp == "Admin")
            {
                Kernel.userLogged = "Admin";
                File.Create(@"0:\AVOS\UserInfo\UserType.txt");
                File.WriteAllText(@"0:\AVOS\UserInfo\UserType.txt", userLogged);
            }

            if (inp == "Root")
            {
                Kernel.userLogged = "Root";
                Kernel.enabledroot = true;
                File.Create(@"0:\AVOS\UserInfo\UserType.txt");
                File.WriteAllText(@"0:\AVOS\UserInfo\UserType.txt", userLogged);
            }

            if (inp == "Usual")
            {
                Kernel.userLogged = "Usual";
                File.Create(@"0:\AVOS\UserInfo\UserType.txt");
                File.WriteAllText(@"0:\AVOS\UserInfo\UserType.txt", userLogged);
            }

            if (inp == "Dev")
            {
                Kernel.userLogged = "Dev";
                Kernel.DeveloperTools = true;
                File.Create(@"0:\AVOS\UserInfo\UserType.txt");
                File.WriteAllText(@"0:\AVOS\UserInfo\UserType.txt", userLogged);
            }

            if (inp == "Tester")
            {
                Kernel.userLogged = "Tester";
                File.Create(@"0:\AVOS\UserInfo\UserType.txt");
                File.WriteAllText(@"0:\AVOS\UserInfo\UserType.txt", userLogged);
            }
        }
    }

    class ComputerNameSetup
    {
        public static void Setup()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==========================================================");
            TextColors.TextColorWhite();
            Console.WriteLine("                                                          ");
            Console.WriteLine("                        Installer                         ");
            Console.WriteLine("                         Page: 7                          ");
            Console.WriteLine("                                                          ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==========================================================");
            TextColors.TextColorYellow();
            Console.WriteLine("Write the computer name: ");
            TextColors.TextColorDarkYellow();
            Directory.CreateDirectory(@"0:\AVOS\Settings\ComputerName");
            File.Create(@"0:\AVOS\Settings\ComputerName.txt");
            Kernel.ComputerName = Console.ReadLine();
            File.WriteAllText(@"0:\AVOS\Settings\ComputerName.txt", ComputerName);
        }
    }

    class HostNameSetup
    {
        public static void Setup()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==========================================================");
            TextColors.TextColorWhite();
            Console.WriteLine("                                                          ");
            Console.WriteLine("                        Installer                         ");
            Console.WriteLine("                         Page: 8                          ");
            Console.WriteLine("                                                          ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==========================================================");
            TextColors.TextColorYellow();
            Console.WriteLine("Write the hostname: ");
            TextColors.TextColorDarkYellow();
            Directory.CreateDirectory(@"0:\AVOS\Settings\HostName");
            File.Create(@"0:\AVOS\Settings\HostName.txt");
            Kernel.HostName = Console.ReadLine();
            File.WriteAllText(@"0:\AVOS\Settings\HostName.txt", HostName);
        }
    }

    class Result
    {
        public static void Info()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" ==========================================================");
            TextColors.TextColorWhite();
            Console.WriteLine("                                                          ");
            Console.WriteLine("                        Result                            ");
            Console.WriteLine("                                                          ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==========================================================");
            TextColors.TextColorWhite();
            Console.WriteLine("1) Saving Information: " + Kernel.saveinfo);
            Console.WriteLine("2) Keyboard Layout: " + Kernel.KeyboardSelected);
            Console.WriteLine("3.1) UserName: " + Kernel.username);
            Console.WriteLine("3.2) LicenseAgreement: " + Kernel.LicenseAgreement);
            Console.WriteLine("3.3) UUID: " + Kernel.UUID);
            Console.WriteLine("4) LoginType: " + Kernel.LoginType);
            if (Kernel.LoginType == "PIN")
                Console.WriteLine("5) PIN: " + Kernel.PIN);
            else
                Console.WriteLine("5) Password: " + Kernel.password1);
            Console.WriteLine("6) UserType: " + Kernel.userLogged);
            Console.WriteLine("7) ComputerName: " + Kernel.ComputerName);
            Console.WriteLine("8) HostName: " + Kernel.HostName);
            Console.WriteLine("                                                          ");
            Console.WriteLine("Press any button to finish the installation");
            Console.ReadKey();

            Console.WriteLine("                                                          ");
            Console.WriteLine("Saving files...");
            SaveInstallerFiles.SaveAll();   // ← АВТОСОХРАНЕНИЕ ЗДЕСЬ!

            System.Threading.Thread.Sleep(5000);
        }
    }

    class SaveInstallerFiles
    {
        public static void SaveAll()
        {
            if (Kernel.saveinfo != "Yes") return;

            // Создаём каталоги (если нет)
            Directory.CreateDirectory(@"0:\AVOS\Settings");

            // Username
            File.WriteAllText(@"0:\AVOS\UserInfo\UserName.txt", Kernel.username);

            // Password / Pin-code
            if(LoginType == "Password")
            {
                File.WriteAllText(@"0:\AVOS\UserInfo\Password.txt", Kernel.password1);
            }
            if (LoginType == "PIN")
            {
                File.WriteAllText(@"0:\AVOS\UserInfo\PIN.txt", Kernel.PIN);
            }

            // UserType
            File.WriteAllText(@"0:\AVOS\UserInfo\UserType.txt", Kernel.userLogged);

            // UUID
            File.WriteAllText(@"0:\AVOS\UserInfo\UUID.txt", Kernel.UUID);

            // LoginType
            File.WriteAllText(@"0:\AVOS\UserInfo\loginType.txt", Kernel.LoginType);

            // ComputerName
            File.WriteAllText(@"0:\AVOS\Settings\ComputerName.txt", Kernel.ComputerName);

            // HostName
            File.WriteAllText(@"0:\AVOS\Settings\HostName.txt", Kernel.HostName);

            // License
            File.WriteAllText(@"0:\AVOS\Settings\License.txt", Kernel.LicenseAgreement.ToString());

            // Keyboard Layout
            File.WriteAllText(@"0:\AVOS\Settings\KeyboardLayout.txt", Kernel.KeyboardSelected);
        }
    }


}

