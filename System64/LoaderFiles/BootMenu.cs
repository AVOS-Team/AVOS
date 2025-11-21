using AVOS.KernelLibs.native;
using AVOS.System64.Colors;
using Cosmos.HAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Sys = Cosmos.System;

namespace AVOS.System64.LoaderFiles
{
    public static class BootMenu
    {
        private static int selected = 0;
        private static int timeoutSeconds = 5;
        //private static string bootArgs = "root=0: system=cosmos";
        //public static string defaults = null;
        //private static string configPath = @"0:\AVOS\Boot\config.cfg"; // FAT32 диск Cosmos’a

        private static string[] options = {
        "Boot AVOS",
        "BIOS Settings",
        "Safe mode",
        "Memory test",
        "Reboot"
    };

        public static int Show()
        {
            DateTime start = DateTime.Now;
            bool autoBoot = true;

            Console.Clear();
            DrawFrame();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(3, 2);
            Console.Write("AVOS BootMenu");
            Console.ResetColor();

            Console.SetCursorPosition(3, 4);
            TextColors.TextColorYellow();
            Console.WriteLine("Use PgUp or PgDn to move, Enter to select, C for console");

            DrawMenu();

            while (true)
            {
                int remaining = timeoutSeconds - (int)(DateTime.Now - start).TotalSeconds;
                Console.SetCursorPosition(5, 6 + options.Length + 2);

                if (autoBoot && remaining > 0)
                {
                    Console.Write($"Auto boot in {remaining}s... (press any key to cancel)    ");
                }
                else if (autoBoot && remaining <= 0)
                {
                    return 0; // автостарт
                }

                if (Sys.KeyboardManager.TryReadKey(out var keyEvent))
                {
                    if (autoBoot)
                    {
                        autoBoot = false;
                        Console.SetCursorPosition(5, 6 + options.Length + 2);
                        Console.Write(new string(' ', 60));
                    }

                    int oldSelected = selected;

                    if (keyEvent.Key == Sys.ConsoleKeyEx.UpArrow)
                        selected = (selected - 1 + options.Length) % options.Length;
                    else if (keyEvent.Key == Sys.ConsoleKeyEx.DownArrow)
                        selected = (selected + 1) % options.Length;
                    else if (keyEvent.Key == Sys.ConsoleKeyEx.Enter)
                        return selected;
                    else if (keyEvent.Key == Sys.ConsoleKeyEx.C)
                        OpenConsole();

                    if (oldSelected != selected)
                    {
                        DrawOption(oldSelected, false);
                        DrawOption(selected, true);
                    }
                }

                System.Threading.Thread.Sleep(100);
            }
        }

        private static void OpenConsole()
        {
            Console.Clear();
            TextColors.TextColorYellow();
            Console.WriteLine("AVOS Interactive Console (GRUB-style)");
            Console.WriteLine("Type 'help' for commands. Type 'exit' to return.\n");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("avosh> ");
                Console.ResetColor();

                string input = Console.ReadLine()?.Trim() ?? "";
                string lower = input.ToLower();

                if (lower == "exit")
                {
                    Console.Clear();
                    RedrawMenu();
                    return;
                }
                else if (lower == "help")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Available commands:");
                    Console.WriteLine("  help             - Show this help");
                    Console.WriteLine("  reboot           - Restart the computer");
                    Console.WriteLine("  shutdown         - Shutdown the computer");
                    Console.WriteLine("  cls              - Clear the screen");
                    Console.WriteLine("  devices          - Show devices");
                    Console.WriteLine("  beep             - Beep");
                    Console.WriteLine("  set              - Show variables");
                    Console.WriteLine("  set timeout = N  - Set autoboot timeout (seconds)");
                    Console.WriteLine("  exit             - Return to boot menu\n");
                }
                else if (lower == "reboot")
                {
                    Console.WriteLine("Rebooting...");
                    Sys.Power.Reboot();
                }
                else if (lower == "shutdown")
                {
                    Console.WriteLine("Shutdown...");
                    Sys.Power.Reboot();
                }
                else if (lower == "cls")
                {
                    Console.Clear();
                    Console.WriteLine("AVOS Interactive Console (GRUB-style)");
                    Console.WriteLine("Type 'help' for commands. Type 'exit' to return.\n");
                }
                else if (lower == "test")
                {
                    Console.SetWindowSize(90, 30);
                }
                else if (lower == "devices")
                {
                    Console.WriteLine("\nDetected devices:");
                    try
                    {
                        // --- PCI устройства ---
                        var pciDevices = Cosmos.HAL.PCI.Devices;
                        if (pciDevices.Count == 0)
                        {
                            Console.WriteLine("  No PCI devices found");
                        }
                        else
                        {
                            Console.WriteLine($"  PCI devices detected: {pciDevices.Count}");
                            int shown = 0;
                            foreach (var dev in pciDevices)
                            {
                                Console.WriteLine($"    Vendor 0x{dev.VendorID:X4}, Device 0x{dev.DeviceID:X4}, Class {dev.ClassCode}");
                                shown++;
                                if (shown >= 3) // показываем только первые 3
                                {
                                    Console.WriteLine("    ...");
                                    break;
                                }
                            }
                        }

                        // --- Блочные устройства ---
                        var blockDevices = Cosmos.HAL.BlockDevice.BlockDevice.Devices;
                        if (blockDevices.Count == 0)
                        {
                            Console.WriteLine("  No block devices detected");
                        }
                        else
                        {
                            Console.WriteLine($"  Block devices: {blockDevices.Count}");
                            int index = 0;
                            foreach (var drive in blockDevices)
                            {
                                Console.WriteLine($"    Disk {index}: {drive.BlockCount} blocks × {drive.BlockSize} bytes");
                                index++;
                            }
                        }

                        // --- Ввод (клавиатура и мышь) ---
                        try
                        {
                            if (Cosmos.System.KeyboardManager.KeyAvailable)
                                Console.WriteLine("  Keyboard: Connected");
                            else
                                Console.WriteLine("  Keyboard: Possibly connected");
                        }
                        catch
                        {
                            Console.WriteLine("  Keyboard: Not available");
                        }

                        try
                        {
                            var _ = Cosmos.System.MouseManager.X;
                            Console.WriteLine("  Mouse: Connected");
                        }
                        catch
                        {
                            Console.WriteLine("  Mouse: Not available");
                        }

                        // --- Память ---
                        try
                        {
                            var mem = Cosmos.Core.CPU.GetAmountOfRAM();
                            Console.WriteLine($"  Memory: {mem} MB total");
                        }
                        catch
                        {
                            Console.WriteLine("  Memory info not available");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("  Error while reading devices: " + ex.Message);
                    }
                }
                else if (lower == "beep")
                {
                    Sys.PCSpeaker.Beep();
                    Console.WriteLine("Beep!");
                }
                else if (lower == "set")
                {
                    Console.WriteLine($"timeout={timeoutSeconds}\n");
                }
                else if (lower.StartsWith("set timeout="))
                {
                    string valStr = input.Substring("set timeout=".Length).Trim();
                    if (int.TryParse(valStr, out int newTimeout) && newTimeout >= 0 && newTimeout <= 600)
                    {
                        timeoutSeconds = newTimeout;
                        Console.WriteLine($"timeout set to {timeoutSeconds}s\n");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid value. Must be a number 0–600.\n");
                    }
                }
            }
        }
        private static void RedrawMenu()
        {
            DrawFrame();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(3, 2);
            Console.Write("AVOS BootMenu");
            Console.ResetColor();
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Use PgUp or PgDn to move, Enter to select, C for console");
            DrawMenu();
        }

        private static void DrawMenu()
        {
            for (int i = 0; i < options.Length; i++)
                DrawOption(i, i == selected);
        }

        private static void DrawOption(int index, bool active)
        {
            Console.SetCursorPosition(5, 6 + index);
            if (active)
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"> {options[index]}  ");
                Console.ResetColor();
            }
            else
            {
                Console.Write($"  {options[index]}  ");
                Console.Write(new string(' ', 20));
            }
        }

        private static void DrawFrame()
        {
            int width = 60;
            int height = 16;
            Console.ForegroundColor = ConsoleColor.Gray;
            for (int y = 0; y < height; y++)
            {
                Console.SetCursorPosition(0, y);
                if (y == 0)
                    Console.Write("+" + new string('-', width - 2) + "+");
                else if (y == height - 1)
                    Console.Write("+" + new string('-', width - 2) + "+");
                else
                    Console.Write("|" + new string(' ', width - 2) + "|");
            }
            Console.ResetColor();
        }
    }
}
