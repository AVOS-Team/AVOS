using Cosmos.System.Network.Config;
using CosmosFtpServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOS.System64.Drivers.Network.FTP
{
    class FTP
    {
        public static void Start()
        {
            using (var xServer = new FtpServer(Kernel.fs, @"0:\\"))
            {
                Console.WriteLine("FTP Server listening at " + NetworkConfiguration.CurrentAddress + ":21 ...");
                xServer.Listen();
            }
        }
    }
}
