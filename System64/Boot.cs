using AVOS.System64.Graphics;
using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cosmos.HAL.Drivers.Video.VGADriver;
using static AVOS.Kernel;
using static AVOS.System64.Graphics.GUI;
using APIAVOS.API;
using AVOS.System64.Colors;
using AVOS.BootCore;
using Fos = Cosmos.System;
using System.Runtime.ExceptionServices;
using AVOS.System64.Processing;

namespace AVOS.System64
{
    public class BootGUI
    {
        public static void GuiBoot()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("========================================================");
            TextColors.TextColorGreen();
            Console.WriteLine("                       GUI Setup                        ");
            Console.WriteLine("                         (1/3)                          ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("========================================================");
            TextColors.TextColorWhite();
            Console.WriteLine("Before using the GUI, you need to configure it.");
            Console.WriteLine("Everything is available: 1 | 2, 2S | 3, 3S | 4, 4S");
            string inp = ISteram.In("Choose a wallpaper: ");
            if (inp == "1")
            {
                WallpaperSelect = "1";
            }
            if (inp == "2")
            {
                WallpaperSelect = "2";
            }
            if (inp == "2S")
            {
                WallpaperSelect = "2S";
            }
            if (inp == "3")
            {
                WallpaperSelect = "3";
            }
            if (inp == "3S")
            {
                WallpaperSelect = "3S";

            }
            if (inp == "4")
            {
                WallpaperSelect = "4";

            }
            if (inp == "4S")
            {
                WallpaperSelect = "4S";

            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("========================================================");
            TextColors.TextColorGreen();
            Console.WriteLine("                       GUI Setup                        ");
            Console.WriteLine("                         (2/4)                          ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("========================================================");
            TextColors.TextColorWhite();
            Console.WriteLine("Before using the GUI, you need to configure it.");
            Console.WriteLine("Everything is available: 1 | 2, 2E");
            string ins = ISteram.In("Choose a cursor: ");
            if (ins == "1")
            {
                CursorSelect = "1";

            }
            if (ins == "2")
            {
                CursorSelect = "2";
            }
            if (ins == "2E")
            {
                CursorSelect = "2E";
            }
            CLS();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("========================================================");
            TextColors.TextColorGreen();
            Console.WriteLine("                       GUI Setup                        ");
            Console.WriteLine("                         (3/4)                          ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("========================================================");
            TextColors.TextColorWhite();
            Console.WriteLine("Before using the GUI, you need to configure it.");
            Console.WriteLine("Everything is available: 1,2,3,4,5");
            string inz = ISteram.In("Choose a mouse sensitivity: ");
            if (inz == "1")
            {
                MouseSensitivity = "1";
            }
            if (inz == "2")
            {
                MouseSensitivity = "2";
            }
            if (inz == "3")
            {
                MouseSensitivity = "";

            }
            if (inz == "4")
            {
                MouseSensitivity = "4";
            }
            if (inz == "5")
            {
                MouseSensitivity = "5";
            }
            //Window.Inizalization(proc: process);
            
            // Инициализация \\

               #region Инициализация

            if (WallpaperSelect == "1")
            {
                if (CursorSelect == "1")
                {
                    if (MouseSensitivity == "1")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackroundRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 1;
                        GUI.StartGUI();
                        guimode = true;
                    }
                    if (MouseSensitivity == "2")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackroundRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 2;
                        GUI.StartGUI();
                        guimode = true;
                    }
                    if (MouseSensitivity == "3")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackroundRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 3;
                        GUI.StartGUI();
                        guimode = true;
                    }
                    if (MouseSensitivity == "4")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackroundRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 4;
                        GUI.StartGUI();
                        guimode = true;
                    }
                    if (MouseSensitivity == "5")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackroundRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 5;
                        GUI.StartGUI();
                        guimode = true;
                    }

                }
                if (CursorSelect == "2")
                {
                    if (MouseSensitivity == "1")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackroundRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 1;
                        GUI.StartGUI();
                        guimode = true;
                    }
                    if (MouseSensitivity == "2")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackroundRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 2;
                        GUI.StartGUI();
                        guimode = true;
                    }
                    if (MouseSensitivity == "3")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackroundRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 3;
                        GUI.StartGUI();
                        guimode = true;
                    }
                    if (MouseSensitivity == "4")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackroundRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 4;
                        GUI.StartGUI();
                        guimode = true;
                    }
                    if (MouseSensitivity == "5")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackroundRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 5;
                        GUI.StartGUI();
                        guimode = true;
                    }
                }
                if (CursorSelect == "2E")
                {
                    if (MouseSensitivity == "1")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackroundRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 1;
                        GUI.StartGUI();
                        guimode = true;
                    }
                    if (MouseSensitivity == "2")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackroundRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 2;
                        guimode = true;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "3")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackroundRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 3;
                        GUI.StartGUI();
                        guimode = true;
                    }
                    if (MouseSensitivity == "4")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackroundRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 4;
                        GUI.StartGUI();
                        guimode = true;
                    }
                    if (MouseSensitivity == "5")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackroundRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 5;
                        GUI.StartGUI();
                        guimode = true;
                    }
                }

            }
            if (WallpaperSelect == "2")
            {
                if (CursorSelect == "1")
                {
                    if (MouseSensitivity == "1")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround2Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 1;
                        GUI.StartGUI();
                        guimode = true;
                    }
                    if (MouseSensitivity == "2")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround2Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 2;
                        GUI.StartGUI();
                        guimode = true;
                    }
                    if (MouseSensitivity == "3")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround2Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 3;
                        GUI.StartGUI();
                        guimode = true;
                    }
                    if (MouseSensitivity == "4")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround2Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 4;
                        GUI.StartGUI();
                        guimode = true;
                    }
                    if (MouseSensitivity == "5")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround2Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 5;
                        GUI.StartGUI();
                    }

                }
                if (CursorSelect == "2")
                {
                    if (MouseSensitivity == "1")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround2Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 1;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "2")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround2Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 2;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "3")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround2Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 3;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "4")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround2Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 4;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "5")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround2Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 5;
                        GUI.StartGUI();
                    }

                }
                if (CursorSelect == "2E")
                {
                    if (MouseSensitivity == "1")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround2Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 1;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "2")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround2Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 2;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "3")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround2Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 3;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "4")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround2Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 4;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "5")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround2Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 5;
                        GUI.StartGUI();
                    }
                }
                
            }
            if (WallpaperSelect == "2S")
            {
                if (CursorSelect == "1")
                {
                    if (MouseSensitivity == "1")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround2SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 1;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "2")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround2SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 2;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "3")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround2SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 3;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "4")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround2SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 4;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "5")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround2SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 5;
                        GUI.StartGUI();
                    }
                }
                if (CursorSelect == "2")
                {
                    if (MouseSensitivity == "1")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround2SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 1;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "2")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround2SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 2;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "3")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround2SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 3;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "4")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround2SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 4;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "5")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround2SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 5;
                        GUI.StartGUI();
                    }
                }
                if (CursorSelect == "2E")
                {
                    if (MouseSensitivity == "1")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround2SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 1;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "2")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround2SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 2;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "3")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround2SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 3;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "4")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround2SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 4;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "5")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround2SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 5;
                        GUI.StartGUI();
                    }
                }
            }
            if (WallpaperSelect == "3")
            {
                if (CursorSelect == "1")
                {
                    if (MouseSensitivity == "1")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround3Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 1;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "2")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround3Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 2;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "3")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround3Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 3;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "4")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround3Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 4;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "5")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround3Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 5;
                        GUI.StartGUI();
                    }
                }
                if (CursorSelect == "2")
                {
                    if (MouseSensitivity == "1")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround3Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 1;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "2")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround3Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 2;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "3")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround3Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 3;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "4")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround3Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 4;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "5")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround3Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 5;
                        GUI.StartGUI();
                    }
                }
                if (CursorSelect == "2E")
                {
                    if (MouseSensitivity == "1")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround3Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 1;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "2")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround3Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 2;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "3")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround3Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 3;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "4")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround3Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 4;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "5")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround3Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 5;
                        GUI.StartGUI();
                    }
                }
            }
            if (WallpaperSelect == "3S")
            {
                if (CursorSelect == "1")
                {
                    if (MouseSensitivity == "1")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround3SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 1;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "2")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround3SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 2;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "3")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround3SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 3;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "4")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround3SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 4;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "5")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround3SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 5;
                        GUI.StartGUI();
                    }

                }
                if (CursorSelect == "2")
                {
                    if (MouseSensitivity == "1")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround3Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 1;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "2")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround3Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 2;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "3")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround3Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 3;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "4")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround3Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 4;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "5")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround3Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 5;
                        GUI.StartGUI();
                    }
                }
                if (CursorSelect == "2E")
                {
                    if (MouseSensitivity == "1")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround3Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 1;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "2")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround3Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 2;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "3")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround3Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 3;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "4")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround3Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 4;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "5")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround3Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 5;
                        GUI.StartGUI();
                    }
                }
            }
            if (WallpaperSelect == "4")
            {
                if (CursorSelect == "1")
                {
                    if (MouseSensitivity == "1")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround4Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 1;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "2")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround4Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 2;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "3")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround4Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 3;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "4")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround4Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 4;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "5")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround4Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 5;
                        GUI.StartGUI();
                    }
                }
                if (CursorSelect == "2")
                {
                    if (MouseSensitivity == "1")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround4Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 1;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "2")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround4Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 2;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "3")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround4Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 3;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "4")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround4Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 4;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "5")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround4Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 5;
                        GUI.StartGUI();
                    }
                }
                if (CursorSelect == "2E")
                {
                    if (MouseSensitivity == "1")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround4Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 1;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "2")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround4Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 2;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "3")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround4Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 3;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "4")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround4Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 4;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "5")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround4Raw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 5;
                        GUI.StartGUI();
                    }
                }
            }
            if (WallpaperSelect == "4S")
            {
                if (CursorSelect == "1")
                {
                    if (MouseSensitivity == "1")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround4SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 1;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "2")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround4SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 2;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "3")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround4SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 3;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "4")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround4SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 4;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "5")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround4SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursorRaw);
                        Fos.MouseManager.MouseSensitivity = 5;
                        GUI.StartGUI();
                    }
                }
                if (CursorSelect == "2")
                {
                    if (MouseSensitivity == "1")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround4SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 1;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "2")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround4SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 2;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "3")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround4SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 3;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "4")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround4SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 4;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "5")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround4SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2Raw);
                        Fos.MouseManager.MouseSensitivity = 5;
                        GUI.StartGUI();
                    }
                }
                if (CursorSelect == "2E")
                {
                    if (MouseSensitivity == "1")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround4SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 1;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "2")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround4SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 2;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "3")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround4SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 3;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "4")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround4SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 4;
                        GUI.StartGUI();
                    }
                    if (MouseSensitivity == "5")
                    {
                        CLS();
                        Kernel.RunGui = true;
                        GUI.Wallpaper = new Bitmap(Graphics.Files.AVOSBackround4SRaw);
                        GUI.Cursor = new Bitmap(Graphics.Files.AVOSCursor2ERaw);
                        Fos.MouseManager.MouseSensitivity = 5;
                        GUI.StartGUI();
                    }
                }
            }
            #endregion

        }

    }
    public static class BootConsole
    {
        public static void LoaderBoot()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" ");
            Console.WriteLine("\r\n                    /$$$$$$  /$$    /$$  /$$$$$$   /$$$$$$ \r\n                   /$$__  $$| $$   | $$ /$$__  $$ /$$__  $$\r\n                  | $$  \\ $$| $$   | $$| $$  \\ $$| $$  \\__/\r\n                  | $$$$$$$$|  $$ / $$/| $$  | $$|  $$$$$$ \r\n                  | $$__  $$ \\  $$ $$/ | $$  | $$ \\____  $$\r\n                  | $$  | $$  \\  $$$/  | $$  | $$ /$$  \\ $$\r\n                  | $$  | $$   \\  $/   |  $$$$$$/|  $$$$$$/\r\n                  |__/  |__/    \\_/     \\______/  \\______/ \r\n                                                           \r\n                                                           \r\n                                                           \r\n");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("-------------------");
            Console.WriteLine("|%%");
            Console.WriteLine("|%%");
            Console.WriteLine("-------------------");
            System.Threading.Thread.Sleep(2700);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" ");
            Console.WriteLine("\r\n                    /$$$$$$  /$$    /$$  /$$$$$$   /$$$$$$ \r\n                   /$$__  $$| $$   | $$ /$$__  $$ /$$__  $$\r\n                  | $$  \\ $$| $$   | $$| $$  \\ $$| $$  \\__/\r\n                  | $$$$$$$$|  $$ / $$/| $$  | $$|  $$$$$$ \r\n                  | $$__  $$ \\  $$ $$/ | $$  | $$ \\____  $$\r\n                  | $$  | $$  \\  $$$/  | $$  | $$ /$$  \\ $$\r\n                  | $$  | $$   \\  $/   |  $$$$$$/|  $$$$$$/\r\n                  |__/  |__/    \\_/     \\______/  \\______/ \r\n                                                           \r\n                                                           \r\n                                                           \r\n");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("-------------------");
            Console.WriteLine("|%%%%");
            Console.WriteLine("|%%%%");
            Console.WriteLine("-------------------");

        }
    }
}
