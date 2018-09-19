using UnityEngine;

public static partial class ColorEx
{
    #region Default Color

    // NOTE:
    // Exclusive Color.clear.

    public static Color[] DefaultColors = new Color[]
    {
        Color.black,
        Color.blue,
        Color.cyan,
        Color.gray,
        Color.green,
        Color.magenta,
        Color.red,
        Color.white,
        Color.yellow
    };

    public static int DefaultColorsLength = DefaultColors.Length;

    public static Color GetRandomDefaultColor()
    {
        return ColorEx.DefaultColors[Random.Range(0, ColorEx.DefaultColorsLength)];
    }

    #endregion Default Color

    #region Method

    public static HSVColor ToHSVColor(this Color rgbColor)
    {
        return new HSVColor(rgbColor);
    }

    public static Vector4 ToVector4(this Color rgbColor)
    {
        return new Vector4(rgbColor.r, rgbColor.g, rgbColor.b, rgbColor.a);
    }

    #endregion Method
}