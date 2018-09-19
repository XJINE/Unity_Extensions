using UnityEngine;

public static class Vector3IntEx
{
    #region Field

    public static readonly Vector3Int Back    = new Vector3Int(0,  0, -1);
    public static readonly Vector3Int Down    = new Vector3Int(0, -1,  0);
    public static readonly Vector3Int Forward = new Vector3Int(0,  0,  1);
    public static readonly Vector3Int Left    = new Vector3Int(-1, 0,  0);
    public static readonly Vector3Int One     = new Vector3Int(1,  1,  1);
    public static readonly Vector3Int Right   = new Vector3Int(1,  0,  0);
    public static readonly Vector3Int Up      = new Vector3Int(0,  1,  0);
    public static readonly Vector3Int Zero    = new Vector3Int(0,  0,  0);

    #endregion Field

    #region Method

    public static Vector3Int Random(int min, int max)
    {
        return new Vector3Int()
        {
            x = UnityEngine.Random.Range(min, max),
            y = UnityEngine.Random.Range(min, max),
            z = UnityEngine.Random.Range(min, max),
        };
    }

    public static Vector3Int Random(Vector3Int min, Vector3Int max)
    {
        return new Vector3Int()
        {
            x = UnityEngine.Random.Range(min.x, max.x),
            y = UnityEngine.Random.Range(min.y, max.y),
            z = UnityEngine.Random.Range(min.z, max.z),
        };
    }

    #endregion Method
}