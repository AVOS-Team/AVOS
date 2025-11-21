
// Библиотеки \\

using System;

namespace AVOS.BootCore
{

    // С помощью её, отобржается текст во время загрузки, например: "Loading AVOS". \\

   class ISteram
    {
        public static void Out(string text, ConsoleColor color = ConsoleColor.White)
        {
            if (color != ConsoleColor.White)
            {
                Console.ForegroundColor = color;
                Console.Write(text);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else Console.Write(text);
        }

        public static void OutLN(string text, ConsoleColor color = ConsoleColor.White)
        {
            if (color != ConsoleColor.White)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(text);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else Console.WriteLine(text);
        }

        public static string In(string text, ConsoleColor color = ConsoleColor.White)
        {
            if (color != ConsoleColor.White)
            {
                Console.ForegroundColor = color;
                Console.Write(text);
                Console.ForegroundColor = ConsoleColor.White;
                return Console.ReadLine();
            }
            Console.Write(text);
            return Console.ReadLine();
        }

        public static void Clear()
        {
            Console.Clear();
        }

        public static void SetBckgColor(ConsoleColor color)
        {
            Console.BackgroundColor = color;
        }
    }
}
