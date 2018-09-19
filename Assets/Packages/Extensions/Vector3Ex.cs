using UnityEngine;

public static class Vector3Ex
{
    #region Field

    public static readonly Vector3 Back    = new Vector3(0, 0, -1);
    public static readonly Vector3 Down    = new Vector3(0, -1, 0);
    public static readonly Vector3 Forward = new Vector3(0, 0, 1);
    public static readonly Vector3 Left    = new Vector3(-1, 0, 0);
    public static readonly Vector3 One     = new Vector3(1, 1, 1);
    public static readonly Vector3 Right   = new Vector3(1, 0, 0);
    public static readonly Vector3 Up      = new Vector3(0, 1, 0);
    public static readonly Vector3 Zero    = new Vector3(0, 0, 0);

    #endregion Field

    #region Method

    public static Vector3 Random(float min, float max)
    {
        return new Vector3()
        {
            x = UnityEngine.Random.Range(min, max),
            y = UnityEngine.Random.Range(min, max),
            z = UnityEngine.Random.Range(min, max),
        };
    }

    public static Vector3 Random(int min, int max)
    {
        return new Vector3()
        {
            x = UnityEngine.Random.Range(min, max),
            y = UnityEngine.Random.Range(min, max),
            z = UnityEngine.Random.Range(min, max),
        };
    }

    public static Vector3 Random(Vector3 min, Vector3 max)
    {
        return new Vector3()
        {
            x = UnityEngine.Random.Range(min.x, max.x),
            y = UnityEngine.Random.Range(min.y, max.y),
            z = UnityEngine.Random.Range(min.z, max.z),
        };
    }

    #endregion Method
}