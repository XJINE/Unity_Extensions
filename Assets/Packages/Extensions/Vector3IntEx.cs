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
}