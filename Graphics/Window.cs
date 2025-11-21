using Fos = Cosmos.System;
using Cosmos.System.Graphics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVOS.System64.Processing;
using AVOS.System64.AppsGUI;
using AVOS.System64.Graphics;
using static AVOS.System64.Graphics.Colors;
using System.Drawing;
using Cosmos.System.Graphics.Fonts;
using AVOS.Fonts;
using AVOS.System64.Managment;
using CosmosTTF;
using LunarLabs.Fonts;
using static AVOS.Kernel;
using AVOS.BootCore;
using AVOS.System64.Colors;
using System.Security.Cryptography.X509Certificates;

namespace AVOS.System64.Graphics
{
    public static class Window
    {
        public static int TopSize = 3;

        public static void DrawTop(Process proc)
        {
            CustomDrawing.DrawTopRoundedRectangle(proc.WindowData.WinPos.X, proc.WindowData.WinPos.Y, proc.WindowData.WinPos.Width, TopSize, TopSize / 2, GUI.colors.ColorText);
            GUI.MainCanvas.DrawString(proc.Name, GUI.Font18, GUI.colors.ColorDark, proc.WindowData.WinPos.X + 15, proc.WindowData.WinPos.Y + 8);
        }
    }
}
