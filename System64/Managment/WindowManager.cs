using System;
using System.Drawing;
using AVOS.System64.Processing;
using Cosmos.System;
using AVOS.System64.Graphics;

namespace AVOS.System64.Managment
{
    public static class WindowManager
    {
        private static bool lastMousePressed = false;

        public static bool DrawWindowFrame(Process proc)
        {
            var win = proc.WindowData;

            // Свернуто — не рисуем содержимое
            if (win.State == WindowData.WindowState.Minimized)
                return false;

            int x = win.WinPos.X;
            int y = win.WinPos.Y;
            int w = win.WinPos.Width;
            int h = win.WinPos.Height;

            // Развернуто — растягиваем
            if (win.State == WindowData.WindowState.Maximized)
            {
                x = 0;
                y = 0;
                w = GUI.ScreenSizeX;
                h = GUI.ScreenSizeY - 50; // панель задач
            }

            // Заголовок
            GUI.MainCanvas.DrawFilledRectangle(Color.FromArgb(70, 70, 70), x, y, w, Window.TopSize);
            GUI.MainCanvas.DrawRectangle(Color.Black, x, y, w, h);
            GUI.MainCanvas.DrawString(proc.Name, GUI.Font16, Color.White, x + 10, y + 5);

            // Кнопки
            int btnW = 25, btnH = 20;
            Rectangle minBtn = new Rectangle(x + w - 90, y + 5, btnW, btnH);
            Rectangle maxBtn = new Rectangle(x + w - 60, y + 5, btnW, btnH);
            Rectangle closeBtn = new Rectangle(x + w - 30, y + 5, btnW, btnH);

            GUI.MainCanvas.DrawFilledRectangle(Color.FromArgb(100, 100, 100), minBtn.X, minBtn.Y, btnW, btnH);
            GUI.MainCanvas.DrawString("_", GUI.Font16, Color.White, minBtn.X + 6, minBtn.Y - 3);

            GUI.MainCanvas.DrawFilledRectangle(Color.FromArgb(100, 100, 100), maxBtn.X, maxBtn.Y, btnW, btnH);
            GUI.MainCanvas.DrawString("☐", GUI.Font16, Color.White, maxBtn.X + 4, maxBtn.Y);

            GUI.MainCanvas.DrawFilledRectangle(Color.FromArgb(130, 40, 40), closeBtn.X, closeBtn.Y, btnW, btnH);
            GUI.MainCanvas.DrawString("X", GUI.Font16, Color.White, closeBtn.X + 7, closeBtn.Y);

            // Обработка кликов (по отпусканию)
            bool mousePressed = (MouseManager.MouseState == MouseState.Left);
            if (lastMousePressed && !mousePressed)
            {
                int mx = GUI.MX, my = GUI.MY;

                if (Inside(mx, my, closeBtn))
                {
                    if (ProcessManager.ProcessList.Contains(proc))
                        ProcessManager.ProcessList.Remove(proc);
                }
                else if (Inside(mx, my, maxBtn))
                {
                    if (win.State == WindowData.WindowState.Maximized)
                        win.State = WindowData.WindowState.Normal;
                    else
                        win.State = WindowData.WindowState.Maximized;
                }
                else if (Inside(mx, my, minBtn))
                {
                    win.State = WindowData.WindowState.Minimized;
                }
            }

            lastMousePressed = mousePressed;

            return true;
        }

        private static bool Inside(int mx, int my, Rectangle r)
        {
            return mx >= r.X && mx <= r.X + r.Width &&
                   my >= r.Y && my <= r.Y + r.Height;
        }
    }
}
