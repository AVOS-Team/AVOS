using IL2CPU.API.Attribs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOS.System64.Graphics
{
    class Files
    {
        [ManifestResourceStream(ResourceName = "AVOS.System64.Graphics.Wallpapers.Wall1.bmp")] public static byte[] AVOSBackroundRaw;
        [ManifestResourceStream(ResourceName = "AVOS.System64.Graphics.Wallpapers.Wall2.bmp")] public static byte[] AVOSBackround2Raw;
        [ManifestResourceStream(ResourceName = "AVOS.System64.Graphics.Wallpapers.Wall2S.bmp")] public static byte[] AVOSBackround2SRaw;
        [ManifestResourceStream(ResourceName = "AVOS.System64.Graphics.Wallpapers.Wall3.bmp")] public static byte[] AVOSBackround3Raw;
        [ManifestResourceStream(ResourceName = "AVOS.System64.Graphics.Wallpapers.Wall3S.bmp")] public static byte[] AVOSBackround3SRaw;

        [ManifestResourceStream(ResourceName = "AVOS.System64.Graphics.Cursors.Cursor1.bmp")] public static byte[] AVOSCursorRaw;
        [ManifestResourceStream(ResourceName = "AVOS.System64.Graphics.Cursors.Cursor2.bmp")] public static byte[] AVOSCursor2Raw;
        [ManifestResourceStream(ResourceName = "AVOS.System64.Graphics.Cursors.Cursor2E.bmp")] public static byte[] AVOSCursor2ERaw;
    }
}
