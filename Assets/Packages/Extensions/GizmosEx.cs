using UnityEngine;

public static class GizmosEx
{
    public static void DrawCross(Vector3 center, float lineLength)
    {
        Vector3 from = center;
        Vector3 to   = center;
        float halfLength = lineLength / 2f;

        from.x = from.x - halfLength;
        to.x   = to.x   + halfLength;

        Gizmos.DrawLine(from, to);

        from = center;
        to   = center;

        from.y = from.y - halfLength;
        to.y   = to.y   + halfLength;

        Gizmos.DrawLine(from, to);
    }

    public static void DrawArrow(Vector3 from, Vector3 direction, float headAngle = 15)
    {
        Gizmos.DrawRay(from, direction);

        float headLength = Vector3.Distance(from, from + direction) / 3;

        Vector3 up    = Quaternion.LookRotation(direction) * Quaternion.Euler(0,  headAngle, 0) * Vector3.back;
        Vector3 down  = Quaternion.LookRotation(direction) * Quaternion.Euler(0, -headAngle, 0) * Vector3.back;
        Vector3 left  = Quaternion.LookRotation(direction) * Quaternion.Euler(-headAngle, 0, 0) * Vector3.back;
        Vector3 right = Quaternion.LookRotation(direction) * Quaternion.Euler( headAngle, 0, 0) * Vector3.back;

        Gizmos.DrawRay(from + direction, right * headLength);
        Gizmos.DrawRay(from + direction, left  * headLength);
        Gizmos.DrawRay(from + direction, up    * headLength);
        Gizmos.DrawRay(from + direction, down  * headLength);
    }
}