using UnityEngine;

namespace Extensions
{
    public static class ColorExtension
    {
        public static string ToHex(this Color color, bool includeHash = false)
        {
            var r = Mathf.FloorToInt(color.r * 255).ToString("X2");
            var g = Mathf.FloorToInt(color.g * 255).ToString("X2");
            var b = Mathf.FloorToInt(color.b * 255).ToString("X2");

            return (includeHash ? "#" : "") + r + g + b;
        }

        public static Color FromHex(string hex)
        {
            hex = hex.TrimStart('#');

            var r = (HexToInt(hex[1]) + HexToInt(hex[0]) * 16f) / 255f;
            var g = (HexToInt(hex[3]) + HexToInt(hex[2]) * 16f) / 255f;
            var b = (HexToInt(hex[5]) + HexToInt(hex[4]) * 16f) / 255f;

            return new Color(r, g, b, 1f);
        }

        public static Color FromInt(int r, int g, int b, int a = 255)
        {
            return new Color(r / 255f, g / 255f, b / 255f, a / 255f);
        }

        public static void SetAlpha(this Color color, float a)
        {
            var newColor = color;
            newColor.a   = a;
            color        = newColor;
        }

        public static void SetColor(this Color color, float r, float g, float b)
        {
            var newColor = color;
            newColor.r   = r;
            newColor.g   = g;
            newColor.b   = b;
            color        = newColor;
        }

        private static int HexToInt(char hexValue)
        {
            return int.Parse(hexValue.ToString(), System.Globalization.NumberStyles.HexNumber);
        }
    }
}
