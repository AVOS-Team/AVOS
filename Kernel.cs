
// Библиотеки Cosmos \\

#region Библиотеки Cosmos

using Cosmos.HAL.BlockDevice.Registers;
using Sys = Cosmos.System;
using Cosmos.Common.Extensions;
using Cosmos.System.Graphics;
using Cosmos.HAL.Audio;
using Cosmos.HAL.Network;
using Cosmos.Core.IOGroup;
using Cosmos.System.ExtendedASCII;
using Cosmos.System.Audio.IO;
using Cosmos.System.Audio;
using Cosmos.Common;
using IL2CPU.API.Attribs;
using Cosmos.Core;
using Cosmos.System.FileSystem;
using Cosmos.HAL.BlockDevice.Ports;
using Cosmos.System.Network.IPv4.UDP.DHCP;
using Cosmos.System.Graphics.Fonts;
using SysGPU = Cosmos.Common;
using Cosmos.System.FileSystem.VFS;
using Cosmos.HAL.Drivers.Video;
using Cosmos.HAL;
using Cosmos.Core.Memory;
using Cosmos.System.Network;
using Cosmos.System.Network.Config;
using Cosmos.System.Network.IPv4;
using Cosmos.System.Network.IPv4.UDP;   // для DHCP
using Cosmos.System.Network.IPv4.TCP;
#endregion

// Системные библиотеки \\

#region Системные библиотеки

using System.Diagnostics;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.NetworkInformation;
using System.IO;
using System.Media;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;
using System.Drawing;
using System.Xml.Linq;
using System.Net.Sockets;
using System.Text.Json.Nodes;
using System.Text.Json;

#endregion

// Библиотеки AVOS \\

#region Библиотеки AVOS

using AVOS.BootCore;
using AVOS.System64;
using AVOS.KernelLibs.native;
using AVOS.BootCore.Libraries.runtime;
using AVOS.KernelLibs.native.IOsterams;
using AVOS.Core.Vendor;
using AVOS.System64.Processing;
using AVOS.Core;
using AVOS.System64.Colors;
using AVOS.System64.Applications;
using AVOS.System64.KernelCMD;
using AVOS.System64.Drivers.Network;
using AVOS.API;
using AVOS;
using APIAVOS;
using APIAVOS.API.DateTime;
using AVOS.System64.Configuration;
using AVOS.Core.Uincode;
using APIAVOS.API.ConsoleEngine;
using AVOS.System64.Drivers.Keyboard;
using AVOS.System64.Data.Users;
using APIAVOS.API.ConsoleEngine.Commands;
using APIAVOS.API.Drivers.SimpleDriver;
using APIAVOS.API.Apps;
using AVOS.System64.ADV;
using AVOS.System64.AccountManager;
using AVOS.System64.AccountManager.PasswordManager;
using AVOS.System64.AccountManager.UUID;
using APIAVOS.API.TIMOXA_BIBLIOTEKA;
using APIAVOS.API.Guard;
using APIAVOS.API;
using AVOS.System64.Graphics;
using AVOSAPI.API.Plugins.Authors.AndreyPepper.AVDiagnostics;
using AVOS.System64.Managment;
//using AVOS.System64.Applications.Music;
using AVOSAPI.API;
//using AVOS.System64.ProgrammingLanguages.JSON.Files;
using AVOS.System64.ProgrammingLanguages.JSONParser;
using AVOS.System64.LoaderFiles;
using AVOS.System64.Security;
using AVOS.System64.Drivers.Brightness;
using AVOS.API.ConsoleEngine;
using AVOS.System64.Drivers.Network.FTP;

//using AVOS.System64.Display;//AOD
#endregion

// Сторонние библиотеки \\

#region Сторонние библиотеки
//using Microsoft.EntityFrameworkCore.Internal;
//using Microsoft.EntityFrameworkCore.Metadata.Internal;
#endregion

// OS \\

#region Сама система

namespace AVOS
{
    // Ядро \\

    #region Ядро

    public class Kernel : Cosmos.System.Kernel
    {
        // Основное \\

        #region Основное

        // Стринги \\

        #region Стринги

        public static string username = null;
        public static string osname = "AVOS";
        public static string AvailableKeyboardMap = "ENG, FRA ES, TR, GB, DEU, US-D";
        public static string AvailableAplications = "Calc, AVRegistryEditor, NotePad, ChangeLog";
        public static string AvaibableExtensions = "AVConversion (1), AVTools (2)";
        public static string AvaibablePlugins = "AVDiagnostics (1)";
        public static string ComputerName = null;
        public static string HostName = null;
        public static string boottype = "Live USB/CD";
        public static string systemtype = "64 Bit / 32 Bit";
        public static string architecturesystem = "ARM";
        public static string shellname = "AVOS.avosh";
        public static string audio = "Embedded audio";
        public static string sysver = "4.0";
        public static string authors = "werr1x(Andrey Pepper), Mem4ikYT";
        public static string githublink = "'https://github.com/AVOS-Team'";
        public static string userLogged = null;
        public static string userLevelLogged = "admin";
        public static string AvailableUserType = "Usual, Admin, Root, Tester, Dev";
        public static string build = "50";
        public static string revision = "4.20251019F6R";
        public static string edition = "Professional";
        public static string insidermode = null;
        public static string langSelected = "en_US";
        public static string telegram = "'https://t.me/andreypepper'";
        public static string boottime = null;
        public static string github3 = "'https://github.com/AVOS-Team/AVOS-Extensions-Plugins/releases'";
        public static string currentPath;
        public static string[] usrlines;
        public static string updatechanels = "Beta, RTM, Alpha";
        public static string password1 = null;
        public static string LoginType;
        public static string PIN;
        public static string UUID = null;
        public static string KeyboardSelected = null;
        public static string SystemInstalled = "no";
        public static string DriversAll = "Network + (SimpleHttpServer), Keyboard";
        public static int DriversCount = 2;
        public static int CustomApps = 2;
        public static int TotalUsersMax = 5;
        public static int TotalUsersMin = 1;
        public static int AllExtensions = 3;
        public static string saveinfo = null;
        public static string generalUser = null;
        public static string usernamenew = null;
        public static string AllUsers = " , , , , ,";
        public static string currentdirectory = @"0:\";


        #endregion

        // Конфигурация \\

        #region Конфиг

        public static Config SystemConfig;
        public static Config UserConfig;
        public static PowerCTL PWRController;
        public static AVBsOD AVBsODD;
        public static Processor Processorr;
        public static VM VMW;
        public static AVSU AVSUU;
        public static DevTools DevToolss;
        public static NetworkTools NetworkToolss;
        //public static CosmosVFS fs;
        //KeyEvent key;
        public static bool IsDebugMode { get => Convert.ToBoolean(SystemConfig["Debug"]); }
        public static int RunnerMemorySize { get => Convert.ToInt32(SystemConfig["RunnerMemorySize"]); }
        public static string RootPasswd { get => UserConfig["RootPassword"]; }
        public static int DefaultRunnerMemorySize { get => Convert.ToInt32(SystemConfig["DefaultRunnerMemorySize"]); }

        public static Boolean DeveloperTools = false;
        public static Boolean UnicodeSupport = true;
        public static Boolean CertificateAVOS = true;
        public static Boolean SystemSignature = true;
        public static Boolean LicenseAgreement = true;
        public static Boolean X509Certificates = true;
        public static Boolean X509Extensions = true;
        public static string UpdateChanel = "RTM";
        public static string ScreenResolution = null;
        public static bool IsRoot;
        private bool SystemReady = false;
        private int initDelay = 50; // запуск после ~50 циклов Run()
        bool capsState = false;
        bool numState = false;
        bool scrollState = false;
        //private PS2Keyboard keyboard = new();
        public static bool Running = false;
        public static bool RunGui;
        public static bool guimode = false;
        public static bool diskReady = true;
        private TcpListener _listener;
        int lastHeapCollect;
        public static bool InLogged = false;
        public static bool kernelrootenabled = false;
        public static bool enabledroot = false;
        private static bool _networkConnected = false;
        public static bool NetworkConnected;
        private string inputBuffer = "";
        private bool commandReady = false;

        #endregion

        // Графика \\

        #region Графика

        public static Font font16;
        public static Font font18, fontRuscii, fontLat, fontTis, fontDefault;

        // Цвета \\

        #region Цвета

        //public static Color fontColor = Color.White;

        #endregion

        #endregion

        // Файловая система \\

        #region Файловая система

        public static Cosmos.System.FileSystem.CosmosVFS fs;

        #endregion

        // Перед запуском \\

        #region Перед запуском

        protected override void BeforeRun()
        {
            Console.SetWindowSize(90, 30);
            //Console.OutputEncoding = Cosmos.System.ExtendedASCII.CosmosEncodingProvider.Instance.GetEncoding(437);
            fs = new Sys.FileSystem.CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            Directory.CreateDirectory(@"0:\AVOS\SettingsDisplay\");
            //Sys.KeyboardManager.OnKeyChanged += KeyEvent;
            Keybinds.Init();
            CLS();
            int choice = BootMenu.Show();

            switch (choice)
            {
                case 0:
                    Console.WriteLine("Booting Cosmos OS normally...");
                    System.Threading.Thread.Sleep(2000);
                    CLS();
                    Check.CheckCer();
                    break;

                case 1:
                    Console.WriteLine("Starting UEFI");
                    System.Threading.Thread.Sleep(2000);
                    CLS();
                    UEFI.Password();
                    break;

                case 2:
                    Console.WriteLine("Starting safe mode...");
                    break;

                case 3:
                    MemoryTest.RunMemoryTest();
                    System.Threading.Thread.Sleep(3000);
                    CLS();
                    Check.CheckCer();
                    break;

                case 4:
                    Console.WriteLine("Rebooting...");
                    Sys.Power.Reboot();
                    break;

            }
            //Loader.Load();
            CLS();
            System.Threading.Thread.Sleep(1000);
            Running = true;
            NetworkDriver.DHCP();
            TextColors.TextColorMagenta();
            Console.WriteLine("Loading the system and values!");
            System.Threading.Thread.Sleep(1300);
            CLS();
            Login.LoginUser();
            TextColors.TextColorWhite();
        }

        #endregion

        // Запуск \\

        #region Запуск
        protected override void Run()
        {
            if (guimode == false)
            {
                Date();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("AVOS");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("@");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(username);
                TextColors.TextColorDarkRed();
                Console.Write(";");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(userLogged);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("$");
                Console.ForegroundColor = ConsoleColor.White;

                SyncLeds();
                CMD();
            }
            else
            {
                GUI.Update();
            }
            if (lastHeapCollect >= 20)
            {
                Heap.Collect();
                lastHeapCollect = 0;
            }
            else
                lastHeapCollect++;
        }

        private void SyncLeds()
        {
            KeyboardLeds.Sync(
                Sys.Global.CapsLock,
                Sys.Global.NumLock,
                Sys.Global.ScrollLock
            );
        }
        #endregion

        // Показ даты \\

        #region Дата

        public static void Date()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("AVOS                      DateTime: " + DateTime.UtcNow + "                           Month:" + RTC.Month);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        #endregion

        // Статус бар \\

        #region Статус бар

        public static void StatusBar()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Keyboard layout: " + KeyboardSelected.ToString() + "   |   " + "UserName: " + username.ToString() + "   |   " + "Update Channel: " + UpdateChanel.ToString());
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        #endregion

        // JSON \\

        #region JSON

        private static string ReadFile(string path)
        {
            try
            {
                var file = VFSManager.GetFile(path);
                if (file == null) return null;

                var stream = file.GetFileStream();
                if (stream == null) return null;

                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                return Encoding.UTF8.GetString(buffer);
            }
            catch
            {
                return null;
            }
        }

        static void PrintJson(JsonElement element, int indent = 0)
        {
            string ind = new string(' ', indent);

            switch (element.ValueKind)
            {
                case JsonValueKind.Object:
                    Console.WriteLine(ind + "{");
                    foreach (var property in element.EnumerateObject())
                    {
                        Console.Write(ind + "  \"" + property.Name + "\": ");
                        PrintJson(property.Value, indent + 2);
                    }
                    Console.WriteLine(ind + "}");
                    break;

                case JsonValueKind.Array:
                    Console.WriteLine(ind + "[");
                    foreach (var item in element.EnumerateArray())
                        PrintJson(item, indent + 2);
                    Console.WriteLine(ind + "]");
                    break;

                case JsonValueKind.String:
                    Console.WriteLine(ind + "\"" + element.GetString() + "\"");
                    break;

                case JsonValueKind.Number:
                    Console.WriteLine(ind + element.GetRawText());
                    break;

                case JsonValueKind.True:
                case JsonValueKind.False:
                    Console.WriteLine(ind + element.GetRawText());
                    break;

                case JsonValueKind.Null:
                    Console.WriteLine(ind + "null");
                    break;
            }
        }

        static void Main(string[] args)
        {
            string filename = "test.json";
            string json = File.ReadAllText(filename);

            using var doc = JsonDocument.Parse(json);
            PrintJson(doc.RootElement);
        }

        #endregion

        // Очистка консоли \\

        #region Очистка консоли

        public static void CLS()
        {
            Console.Clear();
        }

        #endregion

        // Команды \\

        #region Комманды

        public void CMD()
        {
            var input = Console.ReadLine();
            string filename = "";
            string dirname = "";
            var fs_type = fs.GetFileSystemType(@"0:\");
            var available_space = fs.GetAvailableFreeSpace(@"0:\");
            var totalsize = fs.GetTotalSize(@"0:\");
            var count = fs.Disks.Count;

            if (string.IsNullOrWhiteSpace(input))
                return;

            string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string cmd = parts[0].ToLower();

            switch (cmd)
            {
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[ ERROR: ] UNKNOWN_COMMAND. Type 'help(2,3,4)' to find out the commands.");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                    //case "mkfile":
                    //filename = Console.ReadLine();
                    //Sys.FileSystem.Listing.DirectoryEntry directoryEntry = fs.CreateFile(currentdirectory + filename);
                    break;
                case "cd":
                    currentdirectory = Console.ReadLine();
                    break;

                case "test2":
                    //KeyboardLeds.CapsOn();
                    break;
                case "test3":
                    test3.yy();
                    break;
                case "test4":
                    BrightnessDriver.FadeOut(3); // 3 = скорость
                    Console.WriteLine("Screen darkened");
                    break;
                case "test5":
                    BrightnessDriver.FadeIn(3); // 3 = скорость
                    Console.WriteLine("Screen darkened");
                    break;
                case "network -dhcp":
                    NetworkDriver.DHCP();
                    break;
                case "network -ftp":
                    FTP.Start();
                    break;
                case "network -help":
                    NetworkTools.Help();
                    break;
                case "network":
                    NetworkDriver.Network();
                    break;
                case "generatoruuid":
                    GeneratorUUID.UUID();
                    break;

                case "gui":
                    CLS();
                    BootGUI.GuiBoot();
                    break;

                case "fonts":
                    break;

                case "json":
                    //DrawConsole.Main();
                    break;

                case "calc":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");

                    break;
                case "lock":
                    Lock.Locked();
                    break;
                case "cls":
                    Console.Clear();
                    break;

                case "mkdir":
                    dirname = Console.ReadLine();
                    fs.CreateDirectory(currentdirectory + dirname);
                    break;

                case "apiinfo":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    TextColors.TextColorGreen();
                    Console.WriteLine("APIVersion: " + APIInfo.Version.ToString());
                    Console.WriteLine("APILevel: " + APIInfo.ApiLevel.ToString());
                    Console.WriteLine("APILevelName: " + APIInfo.ApiLevelName.ToString());
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    break;
                case "trust":
                    Trust.TrustGuard();
                    break;

                case "avregistryeditoredit":
                    AVRegistryEditorEdit.Edit();
                    break;

                case "delfile":
                    filename = Console.ReadLine();
                    Sys.FileSystem.VFS.VFSManager.DeleteFile(currentdirectory + filename);
                    break;

                //case "music":
                    //MusicApp.musicapp();
                    //break;

                case "verapps":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("AApps - ver1.0.1\nAPower - ver1.0.1\nAFileManager - ver1.0.0.1\nACalc - ver1.0.0\nASystemCommands - ver1.0.4\nAIOBoot - ver1.0.0\nAVendor - ver1.0.0");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    break;

                case "testaudio":
                    if (AVDiagnostics.PluginWork == true)
                    {
                        testaudio.TestAudio();
                    }

                    if (AVDiagnostics.PluginWork == false)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("========================================================");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sorry, unfortunately this extension is disabled.\nYou can enable it by writing \"extensionssettings\".");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("========================================================");
                    }
                    break;

                case "plandextinstall":
                    string github2 = github3.ToString();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("=======================================================================");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("To download extensions and plugins,\nfollow the link: \n{0}", github3);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("=======================================================================");
                    break;

                case "extensionssettings":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("=======================================================================");
                    Console.ForegroundColor = ConsoleColor.White;
                    ISteram.OutLN("Avaibable Extensions: " + AvaibableExtensions.ToString());
                    string inpz = ISteram.In("Write the extension number to configure it.: ");
                    if (inpz == "1")
                    {
                        TextColors.TextColorRed();
                        Console.WriteLine("Unfortunately, this extension has no settings!");
                    }

                    else if (inpz == "2")
                    {
                        TextColors.TextColorRed();
                        Console.WriteLine("Unfortunately, this extension has no settings!");
                    }


                    break;

                case "pluginssettings":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("=======================================================================");
                    Console.ForegroundColor = ConsoleColor.White;
                    ISteram.OutLN("Avaibable Plugins: " + AvaibablePlugins.ToString());
                    string inps = ISteram.In("Write the plugin number to configure it.: ");

                    if (inps == "3")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("=======================================================================");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("(1) The work of the plugin: " + AVDiagnostics.PluginWork.ToString());
                        Console.WriteLine("There will be a lot of settings coming soon");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("=======================================================================");

                        string inpx = ISteram.In("Write the parameter number to change the value: ");

                        if (inpx == "1")
                        {

                            Console.ForegroundColor = ConsoleColor.White;
                            string inpc = ISteram.In("Turn it on or off?: ");

                            if (inpc == "on" + "On" + "ON" + "oN")
                            {
                                AVDiagnostics.PluginWork = true;
                            }

                            if (inpc == "off" + "Off" + "OFF" + "OfF" + "oFF" + "ofF" + "OFf" + "oFf")
                            {
                                AVDiagnostics.PluginWork = false;
                            }
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("=======================================================================");
                        }
                    }

                    if (inps == null)
                    {
                        Console.WriteLine("You haven't entered anything.");
                    }

                    break;

                case "cow":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@"\|/          (__)    
     `\------(oo)
       ||    (__)
       ||w--||     \|/
   \|/");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case "links":
                    string git = githublink.ToString();
                    string tg = telegram.ToString();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Github: {0}\nContact the owner: {1}", git, tg);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");

                    break;

                case "@echo":
                    string echoresult = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    TextColors.TextColorWhite();
                    Console.WriteLine("Echo Typed: {0}", echoresult);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    break;

                case "keyboard":
                    KeyboardCommand.KeyboardCMD();
                    break;

                case "crash":
                    Console.WriteLine("Not aviablie");
                    break;

                case "dir":

                    try
                    {
                        var directory_list = Sys.FileSystem.VFS.VFSManager.GetDirectoryListing(currentdirectory);

                        foreach (var directoryEntry in directory_list)
                        {
                            try
                            {
                                var entry_type = directoryEntry.mEntryType;
                                if (entry_type == Sys.FileSystem.Listing.DirectoryEntryTypeEnum.File)
                                {
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("| <File>       " + directoryEntry.mName);
                                    Console.ForegroundColor = ConsoleColor.White;

                                }

                                if (entry_type == Sys.FileSystem.Listing.DirectoryEntryTypeEnum.Directory)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("| <Directory>      " + directoryEntry.mName);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }

                            catch (Exception e)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(" [ ERROR: ] Directory not found");
                                Console.WriteLine(e.ToString());
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        break;
                    }
                    break;

                case "pkgmanager":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    TextColors.TextColorGreen();
                    Console.WriteLine("AApps - net.andreypepper.avos.aapps\nAPower - net.andreypepper.avos.apower\nAFileManager - net.andreypepper.avos.afilemanager\nACalc - net.andreypepper.avos.acalc\nASystemCommands - net.andreypepper.avos.asystemcommands\nABootCore - net.andreypepper.avos.abootcore\nAVendor - net.andreypepper.avos.avendor\nAIOBoot - net.andreypepper.avos.aioboot\nAKernel - net.andreypepper.avos.akernel\nAAudio - net.andreypepper.avos.aaudio\nADevTools - net.andreypepper.avos.adevtools\nAVSU - net.andreypepper.avos.avsu");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    break;

                case "keybinds":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    BackgroundColors.BackgroundColorBlue();
                    TextColors.TextColorMagenta();
                    Console.WriteLine("NumLock: " + Keybinds.numlock);
                    Console.WriteLine("CapsLock: " + Keybinds.capslock);
                    Console.WriteLine("ScrollLock: " + Keybinds.scrolllock);
                    BackgroundColors.BackgroundColorBlack();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    break;

                case "customapps":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    TextColors.TextColorWhite();
                    Console.WriteLine("Custom Apps: " + CustomApps.ToString());
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    break;

                case "update":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("===================================================================");
                    TextColors.TextColorWhite();
                    Console.WriteLine("The updates are on GitHub,\nhere is the link: 'https://github.com/AVOS-Team/AVOS/releases'");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("===================================================================");
                    break;

                case "about":
                    string sysversion = sysver.ToString();
                    string runtimever = AVOS.BootCore.Libraries.runtime.RuntimeAPI.runtimeversion;
                    string kernelversion = AVOS.System64.KernelVersion.kernelversion;
                    string vendorver = AVOS.Core.Vendor.VendorVersion.vendorversion;
                    string github = githublink.ToString();
                    string build1 = build.ToString();
                    string revirsion = revision.ToString();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("About");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("System version: {0}\nRuntime version: {1}\nKernel version: {2}\nVendor version: {3}\nGithub: {4}\nBuild {5}\nRevision: {6}\nLicense: BSD 3-Clause License\nCreated: Andrey Pepper\nCopyright 2023, Andrey Pepper ", sysversion, runtimever, kernelversion, vendorver, github, build1, revirsion);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    break;

                case "advabout":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Operating system name:     AVOS");
                    Console.WriteLine("Kernel name:               AVK");
                    Console.WriteLine("Kernel using name:         Cosmos-devkit");
                    Console.WriteLine(".NET version:              6.0");
                    Console.WriteLine("Operating system version:  " + sysver);
                    Console.WriteLine("Operating system build: " + build);
                    Console.WriteLine("Boot Time: " + DateTime.UtcNow);
                    Console.WriteLine("Edition " + edition.ToString());
                    Console.WriteLine("Username: " + username.ToString());
                    Console.WriteLine("Password: " + password1.ToString());
                    Console.WriteLine("Full system name : AVendoringOperatingSystem");
                    Console.WriteLine("Vendor Version: " + VendorVersion.vendorversion.ToString());
                    Console.WriteLine("Runtime Version: " + RuntimeAPI.runtimeversion.ToString());
                    Console.WriteLine("Kernel Version: " + KernelVersion.kernelversion.ToString());
                    Console.WriteLine("AVSU Version: " + AVSU.avsuversion.ToString());
                    Console.WriteLine("Unicode Version: " + UnicodeVersion.Unicodever.ToString());
                    Console.WriteLine("Unicode Support: " + UnicodeSupport.ToString());
                    Console.WriteLine("Root Enabled: " + enabledroot.ToString());
                    Console.WriteLine("Kernel Root Enabled: " + kernelrootenabled.ToString());
                    Console.WriteLine("Developer Tools: " + DeveloperTools.ToString());
                    Console.WriteLine("Update Chanel: " + UpdateChanel.ToString());
                    Console.WriteLine("Shell name: " + shellname.ToString());
                    break;


                //--------------------------\\
                // Paxa Paxa ti moguch      ||
                // Mozet daze zaebexa       ||
                //--------------------------//



                case "diskinfo":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    TextColors.TextColorWhite();
                    Console.WriteLine("File System Type: " + fs_type);
                    Console.WriteLine("Disk RAM: " + available_space);
                    Console.WriteLine("Total Size: " + totalsize);
                    Console.WriteLine("Disks Count: " + count);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    break;


                case "userinfo":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    TextColors.TextColorWhite();
                    Console.WriteLine("Username: " + username.ToString());
                    Console.WriteLine("Password: " + password1.ToString());
                    Console.WriteLine("TypeUser: " + userLogged.ToString());
                    Console.WriteLine("UUID: " + UUID.ToString());
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    break;


                case "editusername":
                    EditUser.Edit();
                    break;

                case "editpassword":
                    EditPassword.Edit();
                    break;

                case "portsusb":
                    break;

                case "advdatetime":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    TextColors.TextColorWhite();
                    Console.WriteLine("DateTime: " + DateTime.UtcNow);
                    Console.WriteLine("");
                    break;
                case "changetypeuser":
                    ChangeUserType.Change();
                    break;


                case "devmode":

                    Console.WriteLine("                                                    \r\n                              ,----..               \r\n   ,---,                     /   /   \\   .--.--.    \r\n  '  .' \\            ,---.  /   .     : /  /    '.  \r\n /  ;    '.         /__./| .   /   ;.  \\  :  /`. /  \r\n:  :       \\   ,---.;  ; |.   ;   /  ` ;  |  |--`   \r\n:  |   /\\   \\ /___/ \\  | |;   |  ; \\ ; |  :  ;_     \r\n|  :  ' ;.   :\\   ;  \\ ' ||   :  | ; | '\\  \\    `.  \r\n|  |  ;/  \\   \\\\   \\  \\: |.   |  ' ' ' : `----.   \\ \r\n'  :  | \\  \\ ,' ;   \\  ' .'   ;  \\; /  | __ \\  \\  | \r\n|  |  '  '--'    \\   \\   ' \\   \\  ',  / /  /`--'  / \r\n|  :  :           \\   `  ;  ;   :    / '--'.     /  \r\n|  | ,'            :   \\ |   \\   \\ .'    `--'---'   \r\n`--''               '---\"     `---`                 \r\n                                                    ");
                    Console.WriteLine("Developers:\nAndrey Pepper, Mem4ikYT (Timoooxa)");
                    break;

                case "apps":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Applications created by the author: Andrey Pepper");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("AApps - System App - (Created by Andrey Pepper)\nAPower - System App - (Created by Andrey Pepper)\nAFileManager - System App - (Created by Andrey Pepper)\nACalc - System App - (Created by Andrey Pepper)\nASystemCommands - System App - (Created by Andrey Pepper)\nABootCore - System App (Created by Andrey Pepper)\nAVendor - Vendor App (Created by Andrey Pepper)\nAIOBoot - Boot App (Created by Andrey Pepper)\nAKernel - Kernel (Created by Andrey Pepper)\nAAudio - Audio App (Created by Andrey Pepper)");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    break;

                case "help":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    TextColors.TextColorWhite();
                    Console.WriteLine("                                                        ");
                    Console.WriteLine("                        Page: 1                         ");
                    Console.WriteLine("              Enter 'help2' to go to page 2             ");
                    Console.WriteLine("                                                        ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("help - Help\nshutdown - Shutdown PC\nrestart - Restart PC\nsysinfo - Information about your PC\nmkfile - Create File\ncd - Moving through directories\ncls - Clear to console\nmkdir - Create Directory\ndelfile - Delete File\ndir - Shows all directories\ndeldir - Delete Directory (Delete)\nabout - About system\napps - Shows all applications in the system\nverapps - Shows all versions of applications");
                    TextColors.TextColorDarkGray();
                    Console.WriteLine("========================================================");
                    break;

                case "test":
                    //DHCP.Ask();
                    break;

                case "diagnostics":
                    AVDiagnostics.Diagnostics();
                    break;

                case "help2":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    TextColors.TextColorWhite();
                    Console.WriteLine("                                                        ");
                    Console.WriteLine("                        Page: 2                         ");
                    Console.WriteLine("              Enter 'help3' to go to page 3             ");
                    Console.WriteLine("                                                        ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("syntax - Gives information about what is (@, !, >, ;)\nsyntaxsall - Shows all syntaxes\ntestaudio - Plays a special sound for the test\ncalc - Calculator\nnetwork - Network\nchangelog - ChangeLog\nadvabout - Advanced About\nadvsysinfo - Advanced Sysinfo\n@echo - Echo\nlinks - Links\npkgmanager - Package Apps Manager\nupdate - Update To System\nplandextinstall - Plugins And Extensions Install\nrandom - Random");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    break;

                case "help3":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    TextColors.TextColorWhite();
                    Console.WriteLine("                                                        ");
                    Console.WriteLine("                        Page: 3                         ");
                    Console.WriteLine("              Enter 'help4' to go to page 4             ");
                    Console.WriteLine("                                                        ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("editusername - Edit UserName\neditpassword - Edit Password\nchangetypeuser - Change Type User\nemergencyrestart - Emergency Restart\nuserinfo - UserInfo\nfactoryreset - Factory Reset\nkeyboardinfo - Keyboard Info\nsetkeyboardmap - Set Keyboard Map\ndrivers - Drivers All\ndriversversion - Drivers Version");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    break;

                case "help4":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    TextColors.TextColorWhite();
                    Console.WriteLine("                                                        ");
                    Console.WriteLine("                        Page: 4                         ");
                    Console.WriteLine("                                                        ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("devtoolsenable - Dev Tools Enable\n;devtools - For Developers\nappslauncher - Apps Launcher\navregistryeditoredit - AVRegistryEditorEdit\nsystemcom - System Components\ninfoapps - Info Apps\ncpulogo - Cpu Logo\nlock - Lock User\ngeneratoruuid - Generator UUID\nextensionssettings - Settings Extensions\ntrust - Trust Guard\napiinfo - Api Info\ndeletepassword - Delete Password\ncreatepassword - Create Password\ndiagnostics - Diagnostics\ngui - Start GUI Mode\nkeybinds - KeyBinds (NumLock, CapsLock and ScrollLock)\nnetwork -dhcp - DHCP\nnetwork -ftp - Start FTP server\network -help - Help");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    break;

                case "syntax":
                    Syntax.Syntaxs();
                    break;

                case "changelog":
                    ChangeLog.changelog();
                    break;

                case "syntaxsall":
                    SyntaxsAll.SyntaxsAl();
                    break;

                case "shutdown":
                    PowerCTL.Shutdown();
                    break;

                case "emergencyrestart":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    TextColors.TextColorWhite();
                    string inp2 = ISteram.In("Do you want to make an emergency restart? Write (Yes/No): ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    TextColors.TextColorWhite();

                    if (inp2 == "Yes")
                    {
                        IOBoot.ioboot();
                        IOBoot2.atteon();
                        Warring.warring();
                        CLS();
                    }

                    if (inp2 == "No")
                    {
                        Console.WriteLine("Okay!");
                    }

                    break;

                case ";devtools":

                    if (DeveloperTools == true)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("========================================================");
                        DevTools.Info();

                    }

                    if (DeveloperTools == false)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("========================================================");
                        TextColors.TextColorRed();
                        Console.WriteLine("No Permission");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("========================================================");
                    }

                    break;

                case "devtoolsenable":
                    string inp5 = ISteram.In("Enable Developer Tools? (y/n): ");

                    if (inp5 == "y")
                    {
                        DeveloperTools = true;
                        Console.WriteLine("Successfully");
                    }

                    if (inp5 == "n")
                    {
                        DeveloperTools = false;
                        Console.WriteLine("Successfully");
                    }
                    break;


                case "driversversion":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    TextColors.TextColorWhite();
                    Console.WriteLine("SimpleDriver: " + SimpleDriver.SimpleDriverVersion.ToString());
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    break;

                case "factoryreset":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    TextColors.TextColorWhite();
                    string inp3 = ISteram.In("Do you want to reset everything to factory settings? (Yes/No): ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    TextColors.TextColorWhite();

                    if (inp3 == "Yes")
                    {
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Factory reset in tree seconds (3)");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Factory reset in two seconds  (2)");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Factory reset in one seconds  (1)");
                        CLS();
                        Check.CheckCer();

                    }

                    if (inp3 == "No")
                    {
                        Console.WriteLine("Okay!");
                    }
                    break;

                case "appslauncher":
                    Launcher.LauncherApps();
                    break;

                case "keyboardinfo":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    TextColors.TextColorWhite();
                    Console.WriteLine("Keyboard Map :" + KeyboardSelected.ToString());
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    break;

                case "drivers":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    TextColors.TextColorWhite();
                    Console.WriteLine("Drivers: " + DriversAll.ToString());
                    Console.WriteLine("Drivers Count: " + DriversCount.ToString());
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    break;

                case "setkeyboardmap":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    TextColors.TextColorWhite();
                    string inp4 = ISteram.In("Enter \"en, fr, es, tr, de, gb, us-d\" to change the keyboard layout: ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");

                    if (inp4 == "en")

                    {
                        KeyboardDriver.KeyBoardUS();
                        Console.WriteLine("Successfully");
                        Kernel.KeyboardSelected = "ENG";
                    }

                    if (inp4 == "fr")

                    {
                        KeyboardDriver.KeyboardFR();
                        Console.WriteLine("Successfully");
                        Kernel.KeyboardSelected = "FR";
                    }

                    if (inp4 == "es")

                    {
                        KeyboardDriver.KeyboardES();
                        Console.WriteLine("Successfully");
                        Kernel.KeyboardSelected = "ES";
                    }

                    if (inp4 == "tr")

                    {
                        KeyboardDriver.KeyboardTR();
                        Console.WriteLine("Successfully");
                        Kernel.KeyboardSelected = "TR";
                    }

                    if (inp4 == "gb")

                    {
                        KeyboardDriver.KeyboardGB();
                        Console.WriteLine("Successfully");
                        Kernel.KeyboardSelected = "GB";
                    }

                    if (inp4 == "de")

                    {
                        KeyboardDriver.KeyboardDE();
                        Console.WriteLine("Successfully");
                        Kernel.KeyboardSelected = "DE";
                    }

                    if (inp4 == "us-d")
                    {
                        TextColors.TextColorRed();
                        Console.WriteLine();
                        string i = ISteram.In("Are you sure? This is a special keyboard layout.\nWrite \"Yes\" to enable, \"No\" to opt out. ");

                        if (i == "Yes")
                        {
                            KeyboardDriver.KeyboardUSDvorak();
                            Kernel.KeyboardSelected = "US-D";
                            Console.WriteLine("Successfully");
                        }

                        if (i == "No")
                        {
                            Console.WriteLine("Okay");
                        }
                    }
                    break;

                case "advsysinfo":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    TextColors.TextColorYellow();
                    Console.WriteLine("Date and time:             " + Time.MonthString() + "/" + Time.DayString() + "/" + Time.YearString() + ", " + Time.TimeString(true, true, true));
                    Console.WriteLine("Total memory:              " + APIAVOS.API.Memory.TotalMemory + "MB");
                    Console.WriteLine("Used memory:               " + APIAVOS.API.Memory.GetUsedMemory() + "MB");
                    Console.WriteLine("Free memory:               " + APIAVOS.API.Memory.GetFreeMemory() + "MB");
                    Console.WriteLine("BootType:   " + boottype.ToString());
                    Console.WriteLine("SystemType:   " + systemtype.ToString());
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    break;

                case "deletepassword":
                    DeletePassword.DelPassword();
                    break;

                case "createpassword":
                    CreatePassword.CrePassword();
                    break;

                case "kernelcmd":
                    KernelCommands.KCMD();
                    break;

                case "infoapps":
                    AppsInfo.AI();
                    break;

                case "restart":
                    PowerCTL.Reboot();
                    break;

                case "cpulogo":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    TextColors.TextColorWhite();
                    Console.WriteLine("" + Cosmos.Core.CPU.GetCPUBrandString());

                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");

                    if (Cosmos.Core.CPU.GetCPUVendorName().Contains("Intel")) // Для Intel
                    {
                        Console.WriteLine("88                              88");
                        Console.WriteLine("\"\"              ,d              88");
                        Console.WriteLine("                88              88");
                        Console.WriteLine("88 8b,dPPYba, MM88MMM ,adPPYba, 88");
                        Console.WriteLine("88 88P'   `\"8a  88   a8P_____88 88");
                        Console.WriteLine("88 88       88  88   8PP\"\"\"\"\"\"\" 88");
                        Console.WriteLine("88 88       88  88,  \"8b,   ,aa 88");
                        Console.WriteLine("88 88       88  \"Y888 `\"Ybbd8\"' 88");
                        Console.WriteLine("                                                     ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("========================================================");
                    }

                    else if (Cosmos.Core.CPU.GetCPUVendorName().Contains("AMD")) // Для AMD
                    {
                        Console.WriteLine("              *@@@@@@@@@@@@@@@    ");
                        Console.WriteLine("                 @@@@@@@@@@@@@    ");
                        Console.WriteLine("                @%       @@@@@    ");
                        Console.WriteLine("              @@@%       @@@@@    ");
                        Console.WriteLine("             @@@@&       @@@@@    ");
                        Console.WriteLine("             @@@@@@@@@     @@@    ");
                        Console.WriteLine("             #######              ");
                        Console.WriteLine();
                        Console.WriteLine("            @@     @\\ /@  @@@@*   ");
                        Console.WriteLine("           @..@    @ @ @  @.   @  ");
                        Console.WriteLine("          @    @   @   @  @@@@*   ");
                        Console.WriteLine("                                                     ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("========================================================");
                    }


                    else
                    {
                        TextColors.TextColorRed();
                        Console.WriteLine("Unfortunately, we can't identify the logo for your processor.");
                    }

                    break;

                case "random":
                    var rand = new Random();
                    for (int i = 0; i < 5; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("========================================================");
                        TextColors.TextColorWhite();
                        Console.WriteLine(rand.Next(1000));
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("========================================================");
                    }
                    break;

                case "sysinfo":
                    string CPU = Cosmos.Core.CPU.GetCPUBrandString();
                    string CPUvendor = Cosmos.Core.CPU.GetCPUVendorName();
                    string CPUname = Cosmos.Core.CPU.GetCPUBrandString();
                    uint amount_of_ram = Cosmos.Core.CPU.GetAmountOfRAM();
                    ulong avialible_ram = Cosmos.Core.GCImplementation.GetAvailableRAM();
                    uint UsedRam = Cosmos.Core.GCImplementation.GetUsedRAM();
                    string archsys = architecturesystem.ToString();
                    string computername = Kernel.ComputerName.ToString();
                    string sysaudio = audio.ToString();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("CPU: {0}\nCPU Vendor: {1}\nCPU Name: {2}\nAmount of RAM: {3} MB\nAvailable RAM: {4} MB\nUsed RAM: {5}\nArchitectureSystem: {6}\nComputer Name: {7}\nAudio: {8}", CPU, CPUvendor, CPUname, amount_of_ram, avialible_ram, UsedRam, archsys, computername, sysaudio);
                    Processor.Bites();
                    VM.VMS();
                    break;
            }
         }

            #endregion

        }
        #endregion

        // Дополнительные компоненты \\

        #region Дополнительные компоненты

        // Контроль выключения и перезагрузки системы \\

        #region Контроль выключения и перезагрузки системы

        public class PowerCTL
        {
            public PowerCTL() { }

            public static void Shutdown()
            {
                Console.WriteLine("Shutting down in tree seconds (3)");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Shutting down in two seconds  (2)");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Shutting down in one seconds  (1)");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Goodbye");
                System.Threading.Thread.Sleep(1000);
                Kernel.Running = false;
                Sys.Power.Shutdown();
                Console.Clear();
            }

            public static void Reboot()
            {
                Console.WriteLine("Restarting in tree seconds (3)");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Restarting in two seconds  (2)");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Restarting in one seconds  (1)");
                System.Threading.Thread.Sleep(1000);
                Kernel.Running = false;
                Sys.Power.Reboot();
                Console.Clear();
            }

            // Для GUI \\

            public static void MShutdown()
            {
                Kernel.Running = false;
                Kernel.guimode = false;
                Sys.Power.Shutdown();
                Console.Clear();
            }

            public static void MReboot()
            {
                Kernel.Running = false;
                Kernel.guimode = false;
                Sys.Power.Reboot();
                Console.Clear();
            }
        }

        #endregion

        // AVBsOD\\ 

        #region AVBsOD

        public class AVBsOD
        {
            // Если в названии ошибки написано например "AV401.1WQ", то это дополнение к ошибкам. Максимум дополнений 5!

            #region Таблица уровней ошибок

            // Таблица уровней ошибок \\

            // W = Обычная ошибка 
            // WE = Критическая ошибка
            // WR = Ошибка во время выполнения действия
            // WQ = Ошибка связана с загрущиком
            // WF = Ошибку невозможно исправить
            // WI = Предупреждение
            // 

            #endregion

            public AVBsOD() { }

            public static void CertificateErrorCrash()
            {
                CertificateError();

                TextColors.TextColorWhite();
                Console.WriteLine("Press any key to shutdown...");
                Console.ReadKey();
                PowerCTL.Shutdown();
            }

            public static void CertificateError()
            {
                Kernel.CLS();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("========================================================");
                TextColors.TextColorRed();
                Console.WriteLine(" [ ERROR: ] StopCVode: AS402WQ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("========================================================");
                TextColors.TextColorRed();
                Console.WriteLine("Error means: No Certificate AVOS");
            }


        }

        #endregion

        // Процессор \\

        #region Процессор

        public class Processor
        {
            public Processor() { }

            public static void Bites()
            {
                // Если процесор имеет поддержку 64-bit, то будет показыватся что он имеет 64-bit, и так с 32-bit.

                if (Environment.Is64BitProcess)
                {
                    TextColors.TextColorGreen();
                    Console.WriteLine("\nProcessor Bit Architecture: 64-bit");
                }
                else
                {
                    TextColors.TextColorRed();
                    Console.WriteLine("\nProcessor Bit Architecture: 32-bit");
                }

            }
        }

        #endregion

        // Виртуализация \\

        #region Виртуализация

        public class VM
        {
            public VM() { }

            public static void VMS()
            {
                if (Sys.VMTools.IsVMWare)
                {
                    // Если вы тестируйте систему, то виртуализация будет "VMware" \\
                    TextColors.TextColorGreen();
                    Console.WriteLine("Virtualization: VMware");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                }
                else if (Sys.VMTools.IsQEMU)
                {
                    // Если вы тестируйте систему, то виртуализация будет "QEMU (или KVM)" \\
                    TextColors.TextColorCyan();
                    Console.WriteLine("Virtualization: QEMU (or maybe KVM)");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                }
                else if (Sys.VMTools.IsVirtualBox)
                {
                    // Если вы тестируйте систему, то виртуализация будет "VirtualBox" \\
                    TextColors.TextColorDarkGreen();
                    Console.WriteLine("Virtualization: VirtualBox");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                }
                else
                {
                    // Если вы тестируйте, или запустили систему на реальном железе. То будет показывать "Виртуальзация не поддерживается", или же включена. \\
                    TextColors.TextColorRed();
                    Console.WriteLine("Environment isn't virtualized");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("========================================================");
                }
            }

        }

        #endregion

        // AVSU (Для инструментов разработчика) \\

        #region AVSU

        public class AVSU
        {
            public AVSU() { }

            public static string avsuversion = "1.0[B]";


            public static void avsu_info()
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("========================================================");
                TextColors.TextColorYellow();
                Console.WriteLine("Auhtor: Andrey Pepper\nVersion: 1.0[B]\n");
                TextColors.TextColorRed();
                Console.WriteLine("Note: This is an experimental version, there may be bugs.");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("========================================================");
            }

            public static void avsu_run()
            {

            }
        }
        #endregion

        #endregion

        // Инструменты разработчика \\

        #region Инструменты разработчика

        public class DevTools
        {
            public DevTools() { }

            public static string DevToolsVer = "1.1";
            public static string auhtors = "Andrey Pepper";

            public static void Info()
            {
                Kernel.CLS();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("AVOS");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("@");
                TextColors.TextColorGray();
                Console.Write("DevTools ");
                TextColors.TextColorDarkYellow();
                Console.Write("[E]: ");
                TextColors.TextColorWhite();
                DevCMD();
            }

            public static void DevCMD()
            {
                var input = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                switch (input)
                {
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" [ ERROR: ] UNKNOWN_COMMAND. Type 'help' to find out the commands.");
                        Console.ForegroundColor = ConsoleColor.White;

                        break;

                    case "help":
                        Console.WriteLine("                                                            ");
                        string inp = ISteram.In("Write \"devtools\" to find out the list of commands for DevTools,\n\"avsu\" to find out the list of commands for AVSU.: ");

                        if (inp == "devtools")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("========================================================");
                            TextColors.TextColorYellow();
                            Console.WriteLine("                        DevTools:                       ");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("========================================================");
                            TextColors.TextColorYellow();
                            Console.WriteLine("help - Help\nabout - Information\ncls/clear - Clear\nstrings/strings2 - All String's\nbools - All Boolean's");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("========================================================");

                        }
                        if (inp == "avsu")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("========================================================");
                            TextColors.TextColorYellow();
                            Console.WriteLine("                        AVSU:                           ");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("========================================================");
                            TextColors.TextColorDarkGreen();
                            Console.WriteLine("avsu -i = Info\navsu -r = Running The Application In Administrator Mode");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("========================================================");
                        }
                        break;

                    case "about":
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("========================================================");
                        TextColors.TextColorWhite();
                        Console.WriteLine("Version: " + DevToolsVer.ToString());
                        Console.WriteLine("Auhtors: " + auhtors.ToString());
                        TextColors.TextColorRed();
                        Console.WriteLine("Note: This is an experimental version, there may be bugs.");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("========================================================");
                        break;

                    case "cls":
                        Console.Clear();
                        break;

                    case "clear":
                        Console.Clear();
                        break;
                    case "test":
                        break;
                    case "strings":
                        TextColors.TextColorGreen();
                        Console.WriteLine("string | username: " + Kernel.username.ToString());
                        Console.WriteLine("string | osname: " + Kernel.osname.ToString());
                        Console.WriteLine("string | AvailableKeyboardMap: " + Kernel.AvailableKeyboardMap.ToString());
                        Console.WriteLine("string | AvailableAplications: " + Kernel.AvailableAplications.ToString());
                        Console.WriteLine("string | ComputerName: " + Kernel.ComputerName.ToString());
                        Console.WriteLine("string | boottype: " + Kernel.systemtype.ToString());
                        Console.WriteLine("string | systemtype: " + Kernel.systemtype.ToString());
                        Console.WriteLine("string | architecturesystem: " + Kernel.architecturesystem.ToString());
                        Console.WriteLine("string | shellname: " + Kernel.shellname.ToString());
                        Console.WriteLine("string | audio: " + Kernel.audio.ToString());
                        Console.WriteLine("string | sysver: " + Kernel.sysver.ToString());
                        Console.WriteLine("string | authors: " + Kernel.authors.ToString());
                        Console.WriteLine("string | userLogged: " + Kernel.userLogged.ToString());
                        Console.WriteLine("string | userLevelLogged: " + Kernel.userLevelLogged.ToString());
                        Console.WriteLine("string | AvailableUserType: " + Kernel.AvailableUserType.ToString());
                        Console.WriteLine("string | build: " + Kernel.build.ToString());
                        Console.WriteLine("string | revision: " + Kernel.revision.ToString());
                        Console.WriteLine("string | edition: " + Kernel.edition.ToString());
                        Console.WriteLine("string | langSelected: " + Kernel.langSelected.ToString());
                        Console.WriteLine("string | updatechanels: " + Kernel.updatechanels.ToString());
                        Console.WriteLine("string | password1: " + Kernel.password1.ToString());
                        Console.WriteLine("To continue, write \"strings2\"");
                        break;
                    case "strings2":
                        TextColors.TextColorGreen();
                        Console.WriteLine("string | UUID: " + Kernel.UUID.ToString());
                        Console.WriteLine("string | insidermode: " + Kernel.insidermode.ToString());
                        Console.WriteLine("string | KeyboardSelected: " + Kernel.KeyboardSelected.ToString());
                        Console.WriteLine("string | DriversAll: " + Kernel.DriversAll.ToString());
                        Console.WriteLine("string | saveinfo: " + Kernel.saveinfo.ToString());
                        Console.WriteLine("string | generalUser: " + Kernel.generalUser.ToString());
                        Console.WriteLine("string | AllUsers: " + Kernel.AllUsers.ToString());
                        Console.WriteLine("string | UpdateChanel: " + Kernel.UpdateChanel.ToString());
                        break;
                    case "bools":
                        TextColors.TextColorYellow();
                        Console.WriteLine("Boolean | DeveloperTools: " + Kernel.DeveloperTools.ToString());
                        Console.WriteLine("Boolean | UnicodeSupport: " + Kernel.UnicodeSupport.ToString());
                        Console.WriteLine("Boolean | CertificateAVOS: " + Kernel.CertificateAVOS.ToString());
                        Console.WriteLine("Boolean | SystemSignature: " + Kernel.SystemSignature.ToString());
                        Console.WriteLine("Boolean | LicenseAgreement: " + Kernel.LicenseAgreement.ToString());
                        Console.WriteLine("Boolean | X509Certificates: " + Kernel.X509Certificates.ToString());
                        Console.WriteLine("Boolean | X509Extensions: " + Kernel.X509Extensions.ToString());
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("bool | Running: " + Kernel.Running.ToString());
                        Console.WriteLine("bool | diskReady: " + Kernel.diskReady.ToString());
                        Console.WriteLine("bool | kernelrootenabled: " + Kernel.kernelrootenabled.ToString());
                        Console.WriteLine("bool | enabledroot: " + Kernel.enabledroot.ToString());
                        Console.WriteLine("bool | InLogged: " + Kernel.InLogged.ToString());
                        break;
                    case "zhopa":
                        timoxa.vzlom_zhopi();
                        break;

                    // Комманды для AVSU \\

                    #region Комманды для AVSU

                    case "avsu -i":
                        AVSU.avsu_info();
                        break;

                        #endregion

                }
            }
        }

        #endregion

        // Помощник для работы с интернетом \\

        #region Помощник для работы с интернетом

        public class NetworkTools
        {
            public NetworkTools() { }

            public static void Help()
            {
                TextColors.TextColorGreen();
                Console.WriteLine("                          Network Help");
                Console.WriteLine("1) network -dhcp | Detects IP addresses via DHCP");
                //Console.WriteLine("2) network -ping | Checking the Internet");
                Console.WriteLine("2) network -ftp | Start FTP server");
                Console.WriteLine("3) network -help | Help");
            }
        }

        #endregion

        // Конец \\

    }
#endregion

#endregion
