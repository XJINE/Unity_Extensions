using UnityEngine;

public static class BoundsEx
{
    #region Extension

    public static bool Contains(this Bounds bounds1, Bounds bounds2)
    {
        return bounds1.Contains(bounds2.min) && bounds1.Contains(bounds2.max);
    }

    public static Vector3 GetClosestCorner(this Bounds bounds, Vector3 point)
    {
        // NOTE:
        // Calc a midpoint and check the value is greater or not.

        Vector3 min = bounds.min;
        Vector3 max = bounds.max;

        return new Vector3()
        {
            x = (min.x + max.x) / 2 < point.x ? max.x : min.x,
            y = (min.y + max.y) / 2 < point.y ? max.y : min.y,
            z = (min.z + max.z) / 2 < point.z ? max.z : min.z,
        };
    }

    public static Vector3 GetClosestEdge(this Bounds bounds, Vector3 point)
    {
        Vector3 closestCorner = GetClosestCorner(bounds, point);

        if (Mathf.Abs(closestCorner.x - point.x) < Mathf.Abs(closestCorner.y - point.y))
        {
            return new Vector3(closestCorner.x, point.y, point.z);
        }
        else
        {
            return new Vector3(point.x, closestCorner.y, point.z);
        }
    }

    #endregion Extension
}