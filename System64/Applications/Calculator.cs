using Cosmos.HAL.BlockDevice.Registers;
using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using AVOS;
using System.IO;
using Cosmos.Common.Extensions;
using IL2CPU.API.Attribs;
using Cosmos.System.Graphics;
using Cosmos.HAL.Audio;
using Cosmos.HAL.Network;
using Cosmos.Core.IOGroup;
using Cosmos.System.ExtendedASCII;
// ничего\
using Cosmos.System.Audio.IO;
using Cosmos.System.Audio;
using AVOS.BootCore;
using AVOS.System64;
using System.Media;
using AVOS.KernelLibs.native;
using AVOS.BootCore.Libraries.runtime;
using Cosmos.Common;
using System.Security.Cryptography.X509Certificates;
using AVOS.KernelLibs.native.IOsterams;
using AVOS.Core.Vendor;
using AVOS.Core;
using AVOS.System64.Colors;

namespace AVOS.System64.Applications
{
    class Calc
    {
        public static void CalcApp()
        {
            double a, b;
            char c;
            Console.Write("Enter First Number: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Enter Operation (+ - * /): ");
            c = char.Parse(Console.ReadLine());
            switch (c)
            {
                case '+':
                    Console.WriteLine("Result: {0}+{1}={2}", a, b, a + b);
                    break;
                case '-':
                    Console.WriteLine("Result: {0}-{1}={2}", a, b, a - b);
                    break;
                case '*':
                    Console.WriteLine("Result: {0}*{1}={2}", a, b, a * b);
                    break;
                case '/':
                    Console.WriteLine("Result: {0}/{1}={2}", a, b, a / b);
                    break;
                default:
                    Console.WriteLine(" [ ERROR: ] Unknown operation!");
                    break;
            }
        }
    }
}
