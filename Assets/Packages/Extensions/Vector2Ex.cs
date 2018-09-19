using UnityEngine;

public static class Vector2Ex
{
    #region Field

    public static readonly Vector2 Down  = new Vector2(0, -1);
    public static readonly Vector2 Left  = new Vector2(-1, 0);
    public static readonly Vector2 One   = new Vector2(1, 1);
    public static readonly Vector2 Right = new Vector2(1, 0);
    public static readonly Vector2 Up    = new Vector2(0, 1);
    public static readonly Vector2 Zero  = new Vector2(0, 0);

    #endregion Field

    #region Method

    public static Vector2 Random(float min, float max)
    {
        return new Vector2()
        {
            x = UnityEngine.Random.Range(min, max),
            y = UnityEngine.Random.Range(min, max)
        };
    }

    public static Vector2 Random(int min, int max)
    {
        return new Vector2()
        {
            x = UnityEngine.Random.Range(min, max),
            y = UnityEngine.Random.Range(min, max)
        };
    }

    public static Vector2 Random(Vector2 min, Vector2 max)
    {
        return new Vector2()
        {
            x = UnityEngine.Random.Range(min.x, max.x),
            y = UnityEngine.Random.Range(min.y, max.y),
        };
    }

    #endregion Method
}