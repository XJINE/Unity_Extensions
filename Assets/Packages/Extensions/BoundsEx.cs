using UnityEngine;

public static class BoundsEx
{
    #region Extension

    public static bool Contains(this Bounds bounds1, Bounds bounds2)
    {
        return bounds1.Contains(bounds2.min) && bounds1.Contains(bounds2.max);
    }

    #region Get Point

    public static Vector3 GetRandomPoint(this Bounds bounds)
    {
        return Vector3Ex.Random(bounds.min, bounds.max);
    }

    public static Vector3[] GetCornerPoints(this Bounds bounds)
    {
        return new Vector3[]
        {
            GetFrontTopLeftPoint(bounds),
            GetFrontTopRightPoint(bounds),
            GetFrontBottomLeftPoint(bounds),
            GetFrontBottomRightPoint(bounds),
            GetBackTopLeftPoint(bounds),
            GetBackTopRightPoint(bounds),
            GetBackBottomLeftPoint(bounds),
            GetBackBottomRightPoint(bounds),
        };
    }

    private static Vector3 GetFrontTopLeftPoint(this Bounds bounds)
    {
        return new Vector3()
        {
            x = bounds.center.x - bounds.extents.x,
            y = bounds.center.y + bounds.extents.y,
            z = bounds.center.z - bounds.extents.z,
        };
    }

    private static Vector3 GetFrontTopRightPoint(this Bounds bounds)
    {
        return new Vector3()
        {
            x = bounds.center.x + bounds.extents.x,
            y = bounds.center.y + bounds.extents.y,
            z = bounds.center.z - bounds.extents.z,
        };
    }

    private static Vector3 GetFrontBottomLeftPoint(this Bounds bounds)
    {
        return new Vector3()
        {
            x = bounds.center.x - bounds.extents.x,
            y = bounds.center.y - bounds.extents.y,
            z = bounds.center.z - bounds.extents.z,
        };
    }

    private static Vector3 GetFrontBottomRightPoint(this Bounds bounds)
    {
        return new Vector3()
        {
            x = bounds.center.x + bounds.extents.x,
            y = bounds.center.y - bounds.extents.y,
            z = bounds.center.z - bounds.extents.z,
        };
    }

    private static Vector3 GetBackTopLeftPoint(this Bounds bounds)
    {
        return new Vector3()
        {
            x = bounds.center.x - bounds.extents.x,
            y = bounds.center.y + bounds.extents.y,
            z = bounds.center.z + bounds.extents.z,
        };
    }

    private static Vector3 GetBackTopRightPoint(this Bounds bounds)
    {
        return new Vector3()
        {
            x = bounds.center.x + bounds.extents.x,
            y = bounds.center.y + bounds.extents.y,
            z = bounds.center.z + bounds.extents.z,
        };
    }

    private static Vector3 GetBackBottomLeftPoint(this Bounds bounds)
    {
        return new Vector3()
        {
            x = bounds.center.x - bounds.extents.x,
            y = bounds.center.y - bounds.extents.y,
            z = bounds.center.z + bounds.extents.z,
        };
    }

    private static Vector3 GetBackBottomRightPoint(this Bounds bounds)
    {
        return new Vector3()
        {
            x = bounds.center.x + bounds.extents.x,
            y = bounds.center.y - bounds.extents.y,
            z = bounds.center.z + bounds.extents.z,
        };
    }

    #endregion Get Point

    #endregion Extension
}