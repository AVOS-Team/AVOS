using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIAVOS.API;

public static class Clipboard
{
    private static string _text = string.Empty;

    public static void SetText(string text)
    {
        _text = text;
    }

    public static string GetText()
    {
        return _text;
    }

    public static bool HasText()
    {
        return !string.IsNullOrEmpty(_text);
    }
}
