using AVOS.System64.Graphics;
using AVOS.System64.Managment;
using AVOS.System64.Processing;
using System;
using System.Collections.Generic;

namespace AVOS.System64.Managment
{
    public static class ProcessManager
    {
        public static List<Process> ProcessList = new List<Process>();

        public static void Start(Process proc)
        {
            if (!ProcessList.Contains(proc))
                ProcessList.Add(proc);
        }

        public static void Update()
        {
            // обновляем и рисуем все процессы
            foreach (var proc in ProcessList.ToArray())
            {
                try
                {
                    if (proc?.WindowData == null)
                        continue;

                    // === Рисуем рамку и кнопки управления ===
                    bool visible = WindowManager.DrawWindowFrame(proc);
                    if (!visible)
                        continue; // окно свернуто

                    // === Если окно не свернуто — вызываем его Run() ===
                    proc.Run();
                }
                catch (Exception ex)
                {
                    GUI.mDebugger.Send($"Process error in {proc?.Name}: {ex.Message}");
                }
            }
        }
    }
}
