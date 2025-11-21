using AVOS.System64.Colors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AVOS.Kernel;

namespace AVOS.System64.AccountManager.UUID
{
    class GeneratorUUID
    {
        public static void UUID()
        {
            Guid myuuid = Guid.NewGuid();
            string myuuidAsString = myuuid.ToString();
            TextColors.TextColorGreen();
            File.Create(@"0:\AVOS\UserInfo\UUID.txt");
            File.WriteAllText(@"0:\AVOS\UserInfo\UUID.txt", Kernel.UUID);
            Console.WriteLine("Generated UUID: " + myuuidAsString);
            Console.WriteLine("The UUID has been saved");

            Kernel.UUID = myuuidAsString;
        }
    }
}
