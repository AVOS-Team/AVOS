using Cosmos.System.Graphics.Fonts;
using CosmosTTF;
using static AVOS.Kernel;
using AVOS.System64.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVOS.Fonts.TFF;

namespace AVOS.System64.Managment
{
    public static class StringsAcitons
	{
		public static void DrawCenteredString(string myString, int WinLengh, int WinPosX, int WinPosY, int space, Color color, Font font)
		{
			string[] strings = myString.Split(new string[] { "\n" }, StringSplitOptions.None).Select(s => s.Trim()).ToArray();
			for (int i = 0; i < strings.Length; i++)
			{
				int lengh = 0;
				if (font == Kernel.font18 || font == Kernel.fontRuscii || font == Kernel.fontDefault)
				 lengh = strings[i].Length * 8;
				else
					 lengh = strings[i].Length * 6;
				int posX = (WinLengh - lengh) / 2;
				GUI.MainCanvas.DrawString(strings[i], font, color, posX + WinPosX, WinPosY + i * space);
			}
		}

		public static void DrawCenteredTTFString(string myString, int WinLengh, int WinPosX, int WinPosY, int space, Color color, string fontName, int fontSize)
		{
			string[] strings = myString.Split(new string[] { "\n" }, StringSplitOptions.None).Select(s => s.Trim()).ToArray();
			for (int i = 0; i < strings.Length; i++)
			{
				int lengh = TTFManager.GetTTFWidth(strings[i], fontName, fontSize);

				int posX = (WinLengh - lengh) / 2;
				GUI.MainCanvas.DrawStringTTF(strings[i], fontName, color, fontSize, posX + WinPosX, WinPosY + i * space);
			}
		}

		public static void DrawCenteredStringAlt(string myString, int WinLengh, int WinPosX, int WinPosY, int space, Color color, Font font)
		{
			string[] strings = myString.Split(new string[] { "\n" }, StringSplitOptions.None).Select(s => s.Trim()).ToArray();
			for (int i = 0; i < strings.Length; i++)
			{
				int lengh = 0;
				if (font == Kernel.font18)
					lengh = strings[i].Length * 8;
				else
					lengh = strings[i].Length * 6;
				int posX = (WinLengh - lengh) / 2;
                GUI.MainCanvas.DrawString(strings[i], font, color, posX + WinPosX, WinPosY + i * space);
			}
		}

        internal static void DrawCenteredTTFString(string v1, Color fontColor, string v2, int v3)
        {
            throw new NotImplementedException();
        }
    }
}
