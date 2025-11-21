using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOS.System64.LoaderFiles
{
    class MemoryTest
    {
        public static void RunMemoryTest()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=== AVOS Memory Test ===");
            Console.ResetColor();
            Console.WriteLine("Press ESC to cancel.\n");

            uint testSize = 16 * 1024 * 1024; // 16 MB
            uint step = 1024 * 1024;          // 1 MB
            byte pattern1 = 0xAA;
            byte pattern2 = 0x55;
            uint tested = 0;
            int errors = 0;

            // рамка прогресса
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|                              |");
            Console.WriteLine("+------------------------------+");
            Console.SetCursorPosition(2, 2);

            DateTime startTime = DateTime.Now;

            unsafe
            {
                byte* ptr = (byte*)0x00100000; // старт с 1 MB

                for (uint offset = 0; offset < testSize; offset += step)
                {
                    // шаблон 1
                    for (uint i = 0; i < step; i++)
                        ptr[offset + i] = pattern1;

                    for (uint i = 0; i < step; i++)
                    {
                        if (ptr[offset + i] != pattern1)
                        {
                            errors++;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"\nError at 0x{(uint)(0x00100000 + offset + i):X8}");
                            Console.ResetColor();
                            break;
                        }
                    }

                    // шаблон 2
                    for (uint i = 0; i < step; i++)
                        ptr[offset + i] = pattern2;

                    for (uint i = 0; i < step; i++)
                    {
                        if (ptr[offset + i] != pattern2)
                        {
                            errors++;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"\nError at 0x{(uint)(0x00100000 + offset + i):X8}");
                            Console.ResetColor();
                            break;
                        }
                    }

                    tested += step;

                    // прогресс-бар
                    double percent = (double)tested / testSize;
                    int blocks = (int)(percent * 30);
                    Console.SetCursorPosition(2, 2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(new string('#', blocks));
                    Console.ResetColor();

                    // скорость
                    TimeSpan elapsed = DateTime.Now - startTime;
                    double seconds = elapsed.TotalSeconds > 0 ? elapsed.TotalSeconds : 1;
                    double mbPerSec = (tested / 1024.0 / 1024.0) / seconds;

                    Console.SetCursorPosition(0, 5);
                    Console.Write($"Tested: {tested / 1024 / 1024} MB / {testSize / 1024 / 1024} MB   ");
                    Console.SetCursorPosition(0, 6);
                    Console.Write($"Speed:  {mbPerSec:F1} MB/s                     ");

                    if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)
                    {
                        Console.WriteLine("\n\nTest cancelled by user.");
                        return;
                    }
                }
            }

            TimeSpan total = DateTime.Now - startTime;
            Console.SetCursorPosition(0, 8);
            Console.WriteLine($"\nCompleted in {total.TotalSeconds:F1}s");

            if (errors == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Result: OK (no errors detected)");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Result: FAIL ({errors} errors found)");
            }
            Console.ResetColor();
        }
    }
}
