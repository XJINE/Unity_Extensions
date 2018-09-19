using UnityEngine;

public static class RayEx
{
    public static Ray CreateFromToRay(Vector3 from, Vector3 to)
    {
        return new Ray(from, to - from);
    }
}