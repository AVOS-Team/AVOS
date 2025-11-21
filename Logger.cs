using System;
using System.Collections.Generic;
using System.IO;
using Cosmos.System.FileSystem;

public static class Logger
{
    private static List<string> logs = new List<string>();
    public static CosmosVFS vfs;

    public static void Init(CosmosVFS filesystem)
    {
        vfs = filesystem;
        if (!File.Exists(@"0:\AVOS\Logs\log.txt"))
        {
            File.Create(@"0:\AVOS\Logs\log.txt").Close();
        }
    }

    private static void Add(string formatted, bool showOnScreen = true)
    {
        logs.Add(formatted);

        if (showOnScreen)
        {
            Console.WriteLine(formatted);
        }

        try
        {
            File.AppendAllText(@"0:\AVOS\Logs\log.txt", formatted + Environment.NewLine);
        }
        catch (Exception e)
        {
            if (showOnScreen)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[Logger ERROR] Error when reading the logs file: {e.Message}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }

    public static void Log(string message)
    {
        string formatted = $"[{DateTime.Now}] {message}";
        Add(formatted, true);
    }

    public static void SilentLog(string message)
    {
        string formatted = $"[{DateTime.Now}] {message}";
        Add(formatted, false); // только файл + память
    }

    public static void Error(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Log("[ERROR] " + message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    public static void Info(string message)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Log("[INFO] " + message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    public static void ShowLogs()
    {
        Console.WriteLine("---- Logs (for RAM) ----");
        foreach (var log in logs)
        {
            Console.WriteLine(log);
        }

        Console.WriteLine("---- Logs (for File) ----");
        try
        {
            string[] fileLogs = File.ReadAllLines(@"0:\AVOS\Logs\log.txt");
            foreach (var line in fileLogs)
            {
                Console.WriteLine(line);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error when reading the logs file: {e.Message}");
        }

        Console.WriteLine("--------------------------");
    }

    public static void ClearLogs()
    {
        logs.Clear();
        try
        {
            File.WriteAllText(@"0:\AVOS\Logs\log.txt", string.Empty);
            Console.WriteLine("Logs have been cleared successfully!");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error clearing the log file: {e.Message}");
        }
    }
}
