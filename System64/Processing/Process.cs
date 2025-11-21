using System.Drawing;

namespace AVOS.System64.Processing
{
    public class Process
    {
        public virtual void Run() { }
        public virtual void Start() { }

        public string Name;
        public WindowData WindowData = new WindowData();
    }

    public class WindowData
    {
        public Rectangle WinPos = new Rectangle { X = 100, Y = 100, Height = 200, Width = 300 };
        public bool MoveAble = true;

        public enum WindowState { Normal, Minimized, Maximized }
        public WindowState State = WindowState.Normal;
    }
}
