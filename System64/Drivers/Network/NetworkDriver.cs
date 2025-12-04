using Cosmos.HAL.BlockDevice.Registers;
using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using System.IO;
using Cosmos.Common.Extensions;
using Cosmos.System.Graphics;
using Cosmos.HAL.Audio;
using Cosmos.HAL.Network;
using Cosmos.Core.IOGroup;
using Cosmos.System.ExtendedASCII;

using Cosmos.System.Audio.IO;
using Cosmos.System.Audio;
using AVOS.BootCore;
using System.Media;
using AVOS.KernelLibs.native;
using AVOS.BootCore.Libraries.runtime;
using Cosmos.Common;
using System.Security.Cryptography.X509Certificates;
using AVOS.KernelLibs.native.IOsterams;
using AVOS.Core.Vendor;
using AVOS.Core;
using AVOS.System64.Colors;
using AVOS.System64.Applications;
using IL2CPU.API.Attribs;
using Cosmos.Core;
using AVOS.System64.KernelCMD;
using Cosmos.System.FileSystem;
using Cosmos.HAL;
using Cosmos.System.Network.Config;
using Cosmos.System.Network.IPv4;
using Cosmos.System.Network.IPv4.UDP.DHCP;
using Cosmos.System.Network.IPv4.UDP.DNS;
using Cosmos.System.Network.IPv4.TCP;
using CosmosFtpServer;

namespace AVOS.System64.Drivers.Network
{
    public class NetworkDriver
    {
        public static string networkdevicename = "eth0";
        public static string serverversion = "1.0.0";
        private NetworkConfig config;

        public static void Network()
        {
            //NetworkDevice nic = NetworkDevice.GetDeviceByName("eth0"); //get network device by name
            //IPConfig.Enable(nic, new Address(248, 168, 3, 12), new Address(255, 255, 255, 0), new Address(192, 168, 1, 254));

            foreach (NetworkConfig config in NetworkConfiguration.NetworkConfigs)
            {
                switch (config.Device.CardType)
                {
                    case CardType.Ethernet:
                        Console.Write("Ethernet Card : " + config.Device.NameID + " - " + config.Device.Name);
                        break;
                    case CardType.Wireless:
                        Console.Write("Wireless Card : " + config.Device.NameID + " - " + config.Device.Name);
                        break;
                }
                if (NetworkConfiguration.CurrentNetworkConfig.Device == config.Device)
                {
                    Console.WriteLine(" (current)");
                }
                else
                {
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("========================================================");
                TextColors.TextColorYellow();
                Console.WriteLine("MAC Address          : " + config.Device.MACAddress.ToString());
                Console.WriteLine("IP Address           : " + config.IPConfig.IPAddress.ToString());
                Console.WriteLine("Subnet mask          : " + config.IPConfig.SubnetMask.ToString());
                Console.WriteLine("Default Gateway      : " + config.IPConfig.DefaultGateway.ToString());
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("========================================================");
            }
        }

        public static void DHCP()
        {
            using (var xClient = new DHCPClient())
            {
                /** Send a DHCP Discover packet **/
                //This will automatically set the IP config after DHCP response
                xClient.SendDiscoverPacket();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("DHCP successfully");
            }
        }

    }
}
