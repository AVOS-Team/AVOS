using AVOS.System64.Graphics;
using AVOS.System64.Processing;
using System;
using System.Drawing;

namespace AVOS.System64.AppsGUI
{
    public class MessageBox : Process
    {
        public string Message = "AVOS.";

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

            // текст по центру
            int textX = x + (w / 2) - (Message.Length * 8 / 2);
            int textY = y + (h / 2);
            GUI.MainCanvas.DrawString(Message, GUI.Font16, Color.White, textX, textY);
        }
    }
}
