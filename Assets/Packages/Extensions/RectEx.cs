using UnityEngine;

public static class RectEx
{
    #region Extension

    public static bool Contains(this Rect rect1, Rect rect2)
    {
        return rect1.Contains(rect2.min) && rect1.Contains(rect2.max);
    }

    #region Get Point

    public static Vector2 GetRandomPoint(this Rect rect)
    {
        return Vector2Ex.Random(rect.min, rect.max);
    }

    public static Vector2 GetTopLeftPoint(this Rect rect)
    {
        return new Vector2(rect.xMin, rect.yMax);
    }

    public static Vector2 GetTopRightPoint(this Rect rect)
    {
        return new Vector2(rect.xMax, rect.yMax);
    }

    public static Vector2 GetBottomLeftPoint(this Rect rect)
    {
        return new Vector2(rect.xMin, rect.yMin);
    }

    public static Vector2 GetBottomRightPoint(this Rect rect)
    {
        return new Vector2(rect.xMax, rect.yMin);
    }

    #endregion Get Point

    #endregion Extension
}