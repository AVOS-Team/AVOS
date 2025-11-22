using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOS.System64.Security
{
    public static class SecureInput
    {
        public static string ReadHidden()
        {
            string input = "";
            ConsoleKeyInfo key;

            while (true)
            {
                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }

                if (key.Key == ConsoleKey.Backspace)
                {
                    if (input.Length > 0)
                    {
                        input = input.Remove(input.Length - 1);
                        Console.Write("");
                    }
                    continue;
                }

                input += key.KeyChar;
                Console.Write("*");
            }

            return input;
        }
    }
}

