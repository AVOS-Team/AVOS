using AVOS.System64.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVOS;

namespace APIAVOS.API.Guard
{
    static class Trust
    {
        public static string TrustVersion = "1.0";
        public static int TrustStatusCounter = 0;

        public static void TrustGuard()
        {
            TextColors.TextColorDarkGray();
            Console.WriteLine("============================================================");
            TextColors.TextColorWhite();

            if (TrustStatusCounter == 1)
            {
                TrustStatusCounter = 0 +1;
                TextColors.TextColorYellow();
                Console.WriteLine("TrustStatus: Normal");
                TextColors.TextColorDarkGray();
                Console.WriteLine("============================================================");
            }
            if (TrustStatusCounter == 2)
            {
                TrustStatusCounter = 1 + 1;
                TextColors.TextColorGreen();
                Console.WriteLine("TrustStatus: Good");
                TextColors.TextColorDarkGray();
                Console.WriteLine("============================================================");
            }
            if (TrustStatusCounter == 0)
            {
                TrustStatusCounter = 0;
                TextColors.TextColorRed();
                Console.WriteLine("TrustStatus: Bad");
                TextColors.TextColorDarkGray();
                Console.WriteLine("============================================================");
            }
            if (Kernel.enabledroot == false)
            {
                TrustStatusCounter = 0 +1;
                TextColors.TextColorGreen();
                Console.WriteLine("Root: " + Kernel.enabledroot.ToString());

            }
            if (Kernel.enabledroot == true)
            {
                TrustStatusCounter = 1 -1;
                TextColors.TextColorRed();
                Console.WriteLine("Root: " + Kernel.enabledroot.ToString());


            }
            if (Kernel.SystemSignature == false)
            {
                TrustStatusCounter = 1 - 1;
                TextColors.TextColorRed();
                Console.WriteLine("System Signature: " + Kernel.SystemSignature.ToString());
                TextColors.TextColorDarkGray();
                Console.WriteLine("============================================================");
            }
            if (Kernel.SystemSignature == true)
            {
                TrustStatusCounter = 1 + 1;
                TextColors.TextColorGreen();
                Console.WriteLine("System Signature: " + Kernel.SystemSignature.ToString());
                TextColors.TextColorDarkGray();
                Console.WriteLine("============================================================");
            }
        }
    }
}
