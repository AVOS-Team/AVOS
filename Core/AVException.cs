using AVOS.BootCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOS.Core
{
    internal class AVException
    {
        private string type;
        private string text;
        public AVException(string type, string text)
        {
            this.type = type;
            this.text = text;
            execute();
        }
        private void execute()
        {
            if (type != "" && text != "")
                ISteram.OutLN($"[{type};{text}]", ConsoleColor.Red);
            else if (type == "")
                ISteram.OutLN($"[{text}]", ConsoleColor.Red);
            else if (text == "")
                ISteram.OutLN($"[{type}]", ConsoleColor.Red);
            else
                ISteram.OutLN("[UNKNOWN ERROR]", ConsoleColor.Red);
        }
    }
}
