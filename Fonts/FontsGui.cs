using IL2CPU.API.Attribs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOS.Fonts
{
    public class FontsGui
    {
        [ManifestResourceStream(ResourceName = "AVOS.Fonts.zap-ext-light16.psf")] public static byte[] Font16;
        [ManifestResourceStream(ResourceName = "AVOS.Fonts.zap-ext-light18.psf")] public static byte[] Font18;
        [ManifestResourceStream(ResourceName = "AVOS.Fonts.lat9w-16.psf")] public static byte[] FontLat;
        [ManifestResourceStream(ResourceName = "AVOS.Fonts.ruscii_8x16.psf")] public static byte[] FontRuscii;
        [ManifestResourceStream(ResourceName = "AVOS.Fonts.tis-ptlight.f16.psf")] public static byte[] FontTis;
    }
}
