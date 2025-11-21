using Cosmos.Core;
using Cosmos.HAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOS.System64.Drivers.Keyboard
{
    public static class KeyboardLeds
    {
        public static bool Caps;
        public static bool Num;
        public static bool Scroll;

        private static void WaitInput()
        {
            // Ждём пока контроллер готов принять команду
            while ((IOPort.Read8(0x64) & 0x02) != 0) { }
        }

        private static void WaitOutput()
        {
            // Ждём пока появится ответ
            while ((IOPort.Read8(0x64) & 0x01) == 0) { }
        }

        private static void Send(byte data)
        {
            WaitInput();
            IOPort.Write8(0x60, data);

            // Ждём ACK (0xFA)
            WaitOutput();
            IOPort.Read8(0x60);
        }

        private static void Update()
        {
            byte mask = 0;
            if (Scroll) mask |= 0x01;
            if (Num) mask |= 0x02;
            if (Caps) mask |= 0x04;

            Send(0xED);   // Команда управления лампами
            Send(mask);   // Устанавливаем состояние
        }

        public static void SetCaps(bool state)
        {
            Caps = state;
            Update();
        }

        public static void SetNum(bool state)
        {
            Num = state;
            Update();
        }

        public static void SetScroll(bool state)
        {
            Scroll = state;
            Update();
        }
    }
}
