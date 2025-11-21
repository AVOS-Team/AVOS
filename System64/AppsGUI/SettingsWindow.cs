using AVOS.System64.Graphics;
using AVOS.System64.Processing;
using System;
using System.Drawing;
using Cosmos.System;

namespace AVOS.System64.AppsGUI
{
    public class SettingsWindow : Process
    {
        private bool lastMousePressed = false;

        public override void Run()
        {
            int x = WindowData.WinPos.X;
            int y = WindowData.WinPos.Y;
            int w = WindowData.WinPos.Width;
            int h = WindowData.WinPos.Height;

            if (WindowData.State == WindowData.WindowState.Maximized)
            {
                x = 0;
                y = 0;
                w = GUI.ScreenSizeX;
                h = GUI.ScreenSizeY - 50;
            }

            // фон
            GUI.MainCanvas.DrawFilledRectangle(GUI.colors.ColorMain, x, y + Window.TopSize, w, h - Window.TopSize);
            GUI.MainCanvas.DrawString("Taskbar:", GUI.Font18, Color.White, x + 20, y + 60);

            // чекбоксы
            int cbX = x + 30;
            int cbY1 = y + 100;
            int cbY2 = y + 140;
            int cbSize = 20;

            // чекбокс 1 — секунды
            GUI.MainCanvas.DrawRectangle(Color.White, cbX, cbY1, cbSize, cbSize);
            if (GUI.ShowSeconds)
                GUI.MainCanvas.DrawString("Y", GUI.Font18, Color.White, cbX + 2, cbY1 - 3);
            GUI.MainCanvas.DrawString("Show seconds", GUI.Font18, Color.White, cbX + 30, cbY1);

            // чекбокс 2 — дата
            GUI.MainCanvas.DrawRectangle(Color.White, cbX, cbY2, cbSize, cbSize);
            if (GUI.ShowDate)
                GUI.MainCanvas.DrawString("Y", GUI.Font18, Color.White, cbX + 2, cbY2 - 3);
            GUI.MainCanvas.DrawString("Show date", GUI.Font18, Color.White, cbX + 30, cbY2);

            // обработка кликов
            bool mousePressed = (MouseManager.MouseState == MouseState.Left);
            if (lastMousePressed && !mousePressed)
            {
                int mx = GUI.MX;
                int my = GUI.MY;

                if (mx >= cbX && mx <= cbX + cbSize && my >= cbY1 && my <= cbY1 + cbSize)
                    GUI.ShowSeconds = !GUI.ShowSeconds;

                if (mx >= cbX && mx <= cbX + cbSize && my >= cbY2 && my <= cbY2 + cbSize)
                    GUI.ShowDate = !GUI.ShowDate;
            }

            lastMousePressed = mousePressed;
        }
    }
}
