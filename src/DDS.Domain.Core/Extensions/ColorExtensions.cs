using System.Drawing;

namespace DDS.Domain.Core.Extensions
{
    public static class ColorExtensions
    {
        public static string ToHex(this Color source)
        {
            return $"#{source.R:X2}{source.G:X2}{source.B:X2}";
        }
    }
}
