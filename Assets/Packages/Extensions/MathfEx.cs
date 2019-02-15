using UnityEngine;

public static class MathfEx
{
    public static int SignOrZero(float value)
    {
        return value > 0 ? 1 : value < 0 ? -1 : 0;
    }
}