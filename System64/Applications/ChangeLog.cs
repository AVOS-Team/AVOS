using AVOS.System64.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AVOS.System64.Applications
{
    class ChangeLog
    {
        public static void changelog()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("========================================================");
            TextColors.TextColorWhite();
            Console.WriteLine("4.0 - First Version");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("========================================================");
        }
    }
}
