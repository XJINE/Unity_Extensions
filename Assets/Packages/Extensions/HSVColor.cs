using UnityEngine;

[System.Serializable]
public struct HSVColor
{
    #region Field

    public float h;
    public float s;
    public float v;
    public float a;

    private static float tempH, tempS, tempV;

    #endregion Field

    #region Constructor

    public HSVColor(Color rgbColor)
    {
        Color.RGBToHSV(rgbColor, out tempH, out tempS, out tempV);

        this.h = tempH;
        this.s = tempS;
        this.v = tempV;
        this.a = rgbColor.a;
    }

    #endregion Constructor

    #region Method

    public override string ToString()
    {
        return h + ", " + s + ", " + v + ", " + a;
    }

    public Color ToColor()
    {
        Color rgbColor = Color.HSVToRGB(this.h, this.s, this.v);
        rgbColor.a = this.a;

        return rgbColor;
    }

    public HSVColor ToGrayScale()
    {
        return new HSVColor()
        {
            h = this.h,
            s = 0,
            v = this.v,
            a = this.a
        };
    }

    public HSVColor Lerp(HSVColor to, float ratio)
    {
        return new HSVColor()
        {
            h = Mathf.Lerp(this.h, to.h, ratio),
            s = Mathf.Lerp(this.s, to.s, ratio),
            v = Mathf.Lerp(this.v, to.v, ratio),
            a = Mathf.Lerp(this.a, to.a, ratio)
        };
    }

    public HSVColor LerpH(float to, float ratio)
    {
        return new HSVColor()
        {
            h = Mathf.Lerp(this.h, to, ratio),
            s = this.s,
            v = this.v,
            a = this.a
        };
    }

    public HSVColor LerpS(float to, float ratio)
    {
        return new HSVColor()
        {
            h = this.h,
            s = Mathf.Lerp(this.s, to, ratio),
            v = this.v,
            a = this.a
        };
    }

    public HSVColor LerpV(float to, float ratio)
    {
        return new HSVColor()
        {
            h = this.h,
            s = this.s,
            v = Mathf.Lerp(this.v, to, ratio),
            a = this.a
        };
    }

    #endregion Method
}