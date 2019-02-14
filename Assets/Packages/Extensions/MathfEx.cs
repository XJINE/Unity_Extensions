public static class MathfEx
{
    public static int SignOrZero(float value)
    {
        return value > 0 ? 1 : value < 0 ? -1 : 0;
    }

    protected bool PointIsInsideCircle
    (float pointX, float pointY, float circleX, float circleY, float circleRadius)
    {
        return Mathf.Pow((pointX - circleX), 2)
             + Mathf.Pow((pointY - circleY), 2)
             < Mathf.Pow(circleRadius, 2);
    }

    protected bool PointIsInsideRectWithSize
    (float pointX, float pointY, float rectX, float rectY, float rectWidth, float rectHeight, bool includeEdge = true)
    {
        float halfWidth = rectWidth / 2;
        float halfHeight = rectHeight / 2;

        return PointIsInsideRectWithMinMax(pointX, pointY,
                                   rectX - halfWidth,
                                   rectY - halfHeight,
                                   rectX + halfWidth,
                                   rectY + halfHeight,
                                   includeEdge);
    }

    protected bool PointIsInsideRectWithMinMax
    (float pointX, float pointY, float minX, float minY, float maxX, float maxY, bool includeEdge = true)
    {
        return includeEdge ? minX <= pointX && minY <= pointY && pointX <= maxX && pointY <= maxY
                           : minX < pointX && minY < pointY && pointX < maxX && pointY < maxY;
    }
}