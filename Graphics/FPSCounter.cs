using Cosmos.HAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOS.System64.Graphics
{
    public class FPSCounter
    {
        private int frames = 0;
        private uint lastSecond = 0;
        private int fps = 0;

        public int FPS => fps;

        public void FrameUpdate()
        {
            frames++;
            uint currentSecond = RTC.Second;
            if (currentSecond != lastSecond)
            {
                fps = frames;
                frames = 0;
                lastSecond = currentSecond;
            }
        }
    }

}
