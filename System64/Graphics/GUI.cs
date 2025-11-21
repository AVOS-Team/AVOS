using AVOS.Fonts;
using AVOS.Fonts.TFF;
using AVOS.System64.AppsGUI;
using AVOS.System64.Graphics;
using AVOS.System64.Managment;
using AVOS.System64.Processing;
using Cosmos.Core;
using Cosmos.Core.Memory;
using Cosmos.Debug.Kernel;
using Cosmos.HAL;
using Cosmos.System;
using Cosmos.System.Graphics;
using Cosmos.System.Graphics.Fonts;
using CosmosTTF;
using System;
using System.Collections.Generic;
using Cosmos.HAL.Drivers.Video.SVGAII;
using System.Drawing;
using static AVOS.Kernel;

namespace AVOS.System64.Graphics
{
    public static class GUI
    {
        public static int ScreenSizeX = 1920, ScreenSizeY = 1080;
        public static SVGAIICanvas MainCanvas;
        public static Bitmap Wallpaper, Cursor;
        public static Colors colors = new Colors();
        public static Debugger mDebugger = new Debugger("AVOS | GUI");

        private static int oldX, oldY;
        public static int MX, MY;
        public static bool Clicked;
        public static bool StartMenuVisible = false;
        public static string WallpaperSelect = null;
        public static string CursorSelect = null;
        public static string MouseSensitivity = null;
        public static Process currentProcess;

        private static FPSCounter fpsCounter = new FPSCounter();
        private static DateTime lastClickTime = DateTime.Now;

        // Шрифты
        public static PCScreenFont Font16 = null;
        public static PCScreenFont Font18 = null;

        // Настройки
        public static bool ShowSeconds = false;
        public static bool ShowDate = true;

        private static List<Rectangle> taskRects = new List<Rectangle>();
        private static List<Process> taskProcs = new List<Process>();

        private static Rectangle startButton;
        private static Rectangle exitButton;

        public static void Update()
        {
            try
            {
                if (Font16 == null)
                {
                    mDebugger.Send("Loading fonts...");
                    Font16 = PCScreenFont.LoadFont(Fonts.FontsGui.Font16);
                    Font18 = PCScreenFont.LoadFont(Fonts.FontsGui.Font18);
                    mDebugger.Send("Fonts loaded successfully.");
                }

                MX = (int)MouseManager.X;
                MY = (int)MouseManager.Y;

                MainCanvas.DrawImage(Wallpaper, 0, 0);
                ProcessManager.Update();

                // === Панель задач ===
                int taskbarHeight = 50;
                int taskbarY = ScreenSizeY - taskbarHeight;
                MainCanvas.DrawFilledRectangle(Color.FromArgb(40, 40, 40), 0, taskbarY, ScreenSizeX, taskbarHeight);

                // Кнопка Пуск
                startButton = new Rectangle(10, taskbarY + 5, 40, 40);
                MainCanvas.DrawFilledRectangle(Color.FromArgb(60, 60, 60), startButton.X, startButton.Y, startButton.Width, startButton.Height);
                MainCanvas.DrawString("⊞", Font16, Color.White, startButton.X + 10, startButton.Y + 10);

                // Окна
                taskRects.Clear();
                taskProcs.Clear();
                int xOffset = 70;

                foreach (var proc in ProcessManager.ProcessList)
                {
                    if (proc?.WindowData == null)
                        continue;

                    Rectangle rect = new Rectangle(xOffset, taskbarY + 5, 120, 40);
                    taskRects.Add(rect);
                    taskProcs.Add(proc);

                    Color btnColor = Color.FromArgb(70, 70, 70); // по умолчанию

                    // Цвет по состоянию окна
                    if (proc == currentProcess)
                        btnColor = Color.FromArgb(100, 100, 100); // активное
                    else if (proc.WindowData.State == WindowData.WindowState.Minimized)
                        btnColor = Color.FromArgb(50, 50, 50); // свернутое

                    MainCanvas.DrawFilledRectangle(btnColor, rect.X, rect.Y, rect.Width, rect.Height);
                    MainCanvas.DrawString(proc.Name, Font16, Color.White, rect.X + 5, rect.Y + 15);

                    xOffset += 130;
                }


                // === Время и дата ===
                string time = ShowSeconds ? DateTime.Now.ToString("HH:mm:ss") : DateTime.Now.ToString("HH:mm");
                int rightX = ScreenSizeX - 110;

                MainCanvas.DrawString(time, Font16, Color.White, rightX, taskbarY + 5);

                if (ShowDate)
                {
                    string date = DateTime.Now.ToString("dd.MM.yyyy");
                    MainCanvas.DrawString(date, Font16, Color.White, rightX - 5, taskbarY + 25);
                }

                // === Меню Пуск ===
                Rectangle settingsBtn = Rectangle.Empty;
                Rectangle explorerBtn = Rectangle.Empty;
                Rectangle rebootButton = Rectangle.Empty;

                if (StartMenuVisible)
                {
                    int menuWidth = 300;
                    int menuHeight = 450;
                    int menuX = 10;
                    int menuY = taskbarY - menuHeight;

                    MainCanvas.DrawFilledRectangle(Color.FromArgb(50, 50, 50), menuX, menuY, menuWidth, menuHeight);
                    MainCanvas.DrawString("Start", Font18, Color.White, menuX + 10, menuY + 10);

                    settingsBtn = new Rectangle(menuX + 10, menuY + 50, 200, 25);
                    explorerBtn = new Rectangle(menuX + 10, menuY + 80, 200, 25);
                    rebootButton = new Rectangle(menuX + 10, menuY + 110, 200, 25);
                    exitButton = new Rectangle(menuX + 10, menuY + 140, 200, 25);

                    MainCanvas.DrawString("Settings", Font16, Color.White, settingsBtn.X, settingsBtn.Y);
                    MainCanvas.DrawString("Explorer", Font16, Color.White, explorerBtn.X, explorerBtn.Y);
                    MainCanvas.DrawString("Reboot", Font16, Color.White, rebootButton.X, rebootButton.Y);
                    MainCanvas.DrawString("Shutdown", Font16, Color.White, exitButton.X, exitButton.Y);
                }

                // === Обработка кликов ===
                if (MouseManager.MouseState == MouseState.Left &&
                    (DateTime.Now - lastClickTime).TotalMilliseconds > 200)
                {
                    lastClickTime = DateTime.Now;

                    // Кнопка Пуск
                    if (IsInside(MX, MY, startButton))
                    {
                        StartMenuVisible = !StartMenuVisible;
                        mDebugger.Send("Start button clicked. Menu visible = " + StartMenuVisible);
                    }

                    // Кнопки окон
                    for (int i = 0; i < taskRects.Count; i++)
                    {
                        var rect = taskRects[i];
                        if (IsInside(MX, MY, rect))
                        {
                            currentProcess = taskProcs[i];
                            mDebugger.Send("Activated window: " + currentProcess.Name);
                        }
                    }

                    // Меню Пуск
                    if (StartMenuVisible)
                    {
                        if (IsInside(MX, MY, settingsBtn))
                        {
                            mDebugger.Send("Settings button clicked.");
                            StartMenuVisible = false;
                            ProcessManager.Start(new SettingsWindow
                            {
                                WindowData = new WindowData { WinPos = new Rectangle(200, 200, 400, 220) },
                                Name = "Настройки системы"
                            });
                        }

                        if (IsInside(MX, MY, explorerBtn))
                        {
                            mDebugger.Send("Explorer button clicked.");
                            StartMenuVisible = false;
                            ProcessManager.Start(new MessageBox
                            {
                                WindowData = new WindowData { WinPos = new Rectangle(300, 250, 400, 200) },
                                Name = "Проводник",
                                Message = "Проводник в разработке"
                            });
                        }

                        if (IsInside(MX, MY, rebootButton))
                        {
                            mDebugger.Send("Reboot button clicked.");
                            StartMenuVisible = false;
                            PowerCTL.MReboot();
                        }

                        if (IsInside(MX, MY, exitButton))
                        {
                            mDebugger.Send("Exit button clicked.");
                            StartMenuVisible = false;
                            ShutdownGUI();
                        }
                    }
                }

                if (MouseManager.MouseState == MouseState.None)
                    Clicked = false;

                // Курсор
                MainCanvas.DrawImageAlpha(Cursor, (int)MouseManager.X, (int)MouseManager.Y);

                MainCanvas.Display();
                fpsCounter.FrameUpdate();
            }
            catch (Exception ex)
            {
                mDebugger.Send("EXCEPTION in GUI.Update: " + ex.Message);
            }
        }

        private static bool IsInside(int x, int y, Rectangle r)
        {
            return (x >= r.X && x <= r.X + r.Width && y >= r.Y && y <= r.Y + r.Height);
        }

        public static void ShutdownGUI()
        {
            try
            {
                mDebugger.Send("Executing full shutdown sequence...");

                var processes = new List<Process>(ProcessManager.ProcessList);
                foreach (var proc in processes)
                {
                    try
                    {
                        ProcessManager.ProcessList.Remove(proc);
                        mDebugger.Send("Process removed: " + proc.Name);
                    }
                    catch (Exception ex)
                    {
                        mDebugger.Send("Error removing process: " + ex.Message);
                    }
                }

                MainCanvas.DrawFilledRectangle(Color.Black, 0, 0, ScreenSizeX, ScreenSizeY);
                MainCanvas.Display();

                mDebugger.Send("Screen cleared. Calling Power.Shutdown()...");
                PowerCTL.MShutdown();
            }
            catch (Exception ex)
            {
                mDebugger.Send("EXCEPTION in ShutdownGUI: " + ex.Message);
            }
        }

        public static void Move()
        {
            try
            {
                if (currentProcess != null)
                {
                    currentProcess.WindowData.WinPos.X = (int)MouseManager.X - oldX;
                    currentProcess.WindowData.WinPos.Y = (int)MouseManager.Y - oldY;
                }
            }
            catch (Exception ex)
            {
                mDebugger.Send("EXCEPTION in GUI.Move: " + ex.Message);
            }
        }

        public static void StartGUI()
        {
            try
            {
                mDebugger.Send("Starting GUI...");
                MainCanvas = new SVGAIICanvas(new Mode((uint)ScreenSizeX, (uint)ScreenSizeY, ColorDepth.ColorDepth32));
                MouseManager.ScreenWidth = (uint)ScreenSizeX;
                MouseManager.ScreenHeight = (uint)ScreenSizeY;
                MouseManager.X = (uint)ScreenSizeX / 2;
                MouseManager.Y = (uint)ScreenSizeY / 2;

                ProcessManager.Start(new MessageBox
                {
                    WindowData = new WindowData { WinPos = new Rectangle(100, 100, 350, 200) },
                    Name = "FPS: " + fpsCounter.FPS,
                    Message = "Добро пожаловать в AVOS!"
                });

                mDebugger.Send("GUI initialized successfully.");
            }
            catch (Exception ex)
            {
                mDebugger.Send("EXCEPTION in StartGUI: " + ex.Message);
            }
        }
    }
}
