using UnityEngine;

public static class RectEx
{
    #region Extension

    public static bool Contains(this Rect rect1, Rect rect2)
    {
        return rect1.Contains(rect2.min) && rect1.Contains(rect2.max);
    }

    #endregion Extension
}