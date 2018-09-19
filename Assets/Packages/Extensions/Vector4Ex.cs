using UnityEngine;

public static class Vector4Ex
{
    #region Method

    public static Vector4 Random(float min, float max)
    {
        return new Vector4()
        {
            x = UnityEngine.Random.Range(min, max),
            y = UnityEngine.Random.Range(min, max),
            z = UnityEngine.Random.Range(min, max),
            w = UnityEngine.Random.Range(min, max),
        };
    }

    public static Vector4 Random(int min, int max)
    {
        return new Vector4()
        {
            x = UnityEngine.Random.Range(min, max),
            y = UnityEngine.Random.Range(min, max),
            z = UnityEngine.Random.Range(min, max),
            w = UnityEngine.Random.Range(min, max),
        };
    }

    public static Vector4 Random(Vector4 min, Vector4 max)
    {
        return new Vector4()
        {
            x = UnityEngine.Random.Range(min.x, max.x),
            y = UnityEngine.Random.Range(min.y, max.y),
            z = UnityEngine.Random.Range(min.z, max.z),
            w = UnityEngine.Random.Range(min.w, max.w),
        };
    }

    public static Color ToColor(this Vector4 vector4)
    {
        return new Color(vector4.x, vector4.y, vector4.z, vector4.w);
    }

    #endregion Method
}