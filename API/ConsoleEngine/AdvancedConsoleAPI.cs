using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIAVOS.API.ConsoleEngine
{
    class AdvancedConsoleAPI
    {
        public static void WriteLineInfo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                               [Info]                        ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void WriteLineWarning()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("                                  [WARNING]                        ");
            Console.ForegroundColor = ConsoleColor.White;
        }


        public static void WriteLineOK()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("                           [OK]                        ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void WriteLineError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("                           [ERROR]                        ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void WriteLineWaiting()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("                           [WAITING]                        ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void WriteLineNote()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("                                     [NOTICE]                                   ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

}
