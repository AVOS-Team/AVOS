using Cosmos.Core;
using Cosmos.HAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AVOS.System64.Drivers.Brightness
{
    public static class BrightnessDriver
    {
        private static int currentBrightness = 100;

        private static readonly (byte R, byte G, byte B)[] Palette =
        {
        (0,0,0),(0,0,170),(0,170,0),(0,170,170),
        (170,0,0),(170,0,170),(170,85,0),(170,170,170),
        (85,85,85),(85,85,255),(85,255,85),(85,255,255),
        (255,85,85),(255,85,255),(255,255,85),(255,255,255)
    };

        public static void SetBrightness(int percent)
        {
            if (percent < 0) percent = 0;
            if (percent > 100) percent = 100;

            currentBrightness = percent;
            Apply(percent);
        }

        // Плавное затемнение (до 0)
        public static void FadeOut(int speed = 5)
        {
            for (int b = currentBrightness; b >= 0; b -= speed)
            {
                Apply(b);
                Thread.Sleep(10);
            }
            currentBrightness = 0;
        }

        // Плавное включение (до 100)
        public static void FadeIn(int speed = 5)
        {
            for (int b = currentBrightness; b <= 100; b += speed)
            {
                Apply(b);
                Thread.Sleep(10);
            }
            currentBrightness = 100;
        }

        private static void Apply(int percent)
        {
            byte scale = (byte)(percent * 255 / 100);

            // Начинаем запись DAC с индекса 0
            IOPort.Write8(0x3C8, 0);

            for (int i = 0; i < 16; i++)
            {
                var (R, G, B) = Palette[i];

                byte r = (byte)((R * scale) / 255);
                byte g = (byte)((G * scale) / 255);
                byte b = (byte)((B * scale) / 255);

                IOPort.Write8(0x3C9, r);
                IOPort.Write8(0x3C9, g);
                IOPort.Write8(0x3C9, b);
            }
        }
    }
}
