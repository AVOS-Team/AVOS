using AVOS;
using AVOS.BootCore;
using AVOS.System64.Applications;
using AVOS.System64.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIAVOS.API.Apps
{
    class Launcher
    {
        public static string Version = "1.1";
        public static void LauncherApps()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("========================================================");
            TextColors.TextColorWhite();
            Console.WriteLine("Avabilaive Apps: " + Kernel.AvailableAplications.ToString());
            string inp = ISteram.In("Select Apps to launch the app: ");


            if (inp == "Calc")
            {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    TextColors.TextColorWhite();
                    Calc.CalcApp();
            }

            if (inp == "AVRegistryEditor")
            {
                    AVRegistryEditorWR.AVREWR();
            }

            if (inp == "NotePad")
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("========================================================");
                TextColors.TextColorWhite();
                NotePad.Main();
            }

            if (inp == "ChangeLog")
            {
                    ChangeLog.changelog();
            }
        }
    }


    class AppsInfo
    {
        public static void AI()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("========================================================");
            TextColors.TextColorWhite();
            Console.WriteLine("Avabilaive Apps: " + Kernel.AvailableAplications.ToString());
            string inp = ISteram.In("Select an application\n from the list to find out the information: ");

            if (inp == "Calc")
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("========================================================");
                TextColors.TextColorWhite();
                Console.WriteLine("Name App: Calculator (Calc)");
                Console.WriteLine("Author: werr1x(Andrey Pepper)");
                Console.WriteLine("Description: An ordinary calculator can add,\n subtract, multiply and divide");
                Console.WriteLine("");

                if (Kernel.DeveloperTools == true)
                {
                    TextColors.TextColorGreen();
                    Console.WriteLine("Advanced:");
                    Console.WriteLine("");
                    Console.WriteLine("Package: \"avos.werr1x.calc.stable\"");
                    Console.WriteLine("Channel App: \"Stable\"");
                    Console.WriteLine("Classes App: \"Calculator.cs [C#]\"");
                    Console.WriteLine("Commands: \"calc\"");
                }
            }

            if (inp == "AVRegistryEditor")
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("========================================================");
                TextColors.TextColorWhite();
                Console.WriteLine("Name App: AVRegistryEditor");
                Console.WriteLine("Author: werr1x(Andrey Pepper)");
                Console.WriteLine("Description: Edit values to system");
                Console.WriteLine("");

                if (Kernel.DeveloperTools == true)
                {
                    TextColors.TextColorGreen();
                    Console.WriteLine("Advanced:");
                    Console.WriteLine("");
                    Console.WriteLine("Package: \"avos.werr1x.avregistryeditor.stable\"");
                    Console.WriteLine("Channel App: \"Stable\"");
                    Console.WriteLine("Classes App: \"AVRegistryEditor.cs [C#], AVRegistryEditorWR.cs [C#], AVRegistryEditorEdit.cs [C#]\"");
                    Console.WriteLine("Commands: \"avregistryeditoredit\"");
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("========================================================");

            if (inp == "NotePad")
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("========================================================");
                TextColors.TextColorWhite();
                Console.WriteLine("Name App: NotePad");
                Console.WriteLine("Author: werr1x(Andrey Pepper), Mem4ik YT (Timoooxa)");
                Console.WriteLine("Description: NotePad");
                Console.WriteLine("");

                if (Kernel.DeveloperTools == true)
                {
                    TextColors.TextColorGreen();
                    Console.WriteLine("Advanced:");
                    Console.WriteLine("");
                    Console.WriteLine("Package: \"avos.werr1x.notepad.stable\", \"avos.mem4ikyt.notepad.srable\"");
                    Console.WriteLine("Channel App: \"Stable\"");
                    Console.WriteLine("Classes App: \"NotePad.cs [C#]\"");
                    Console.WriteLine("Commands: none");
                }

                if (inp == "ChangeLog")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    TextColors.TextColorWhite();
                    Console.WriteLine("Name App: ChangeLog");
                    Console.WriteLine("Author: werr1x(Andrey Pepper)");
                    Console.WriteLine("Description: Information on update");
                    Console.WriteLine("");

                    if (Kernel.DeveloperTools == true)
                    {
                        TextColors.TextColorGreen();
                        Console.WriteLine("Advanced:");
                        Console.WriteLine("");
                        Console.WriteLine("Package: \"avos.werr1x.changelog.stable\"");
                        Console.WriteLine("Channel App: \"Stable\"");
                        Console.WriteLine("Classes App: \"ChangeLog.cs [C#]\"");
                        Console.WriteLine("Commands: none");
                    }
                }

            }
        }
    }
}
