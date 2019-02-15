namespace UnityEngine
{
    public struct Circle
    {
        // REFERENCE:
        // https://github.com/Unity-Technologies/UnityCsReference/blob/master/Runtime/Export/Rect.cs

        #region Field

        public Vector2 position;
        public float   radius;

        #endregion Field

        #region Constructor

        public Circle(Vector2 position, float radius)
        {
            this.position = position;
            this.radius = radius;
        }

        #endregion Constructor

        #region Method

        public bool Contains(Vector2 point)
        {
            return Mathf.Pow(point.x - this.position.x, 2)
                 + Mathf.Pow(point.y - this.position.y, 2)
                <= Mathf.Pow(this.radius, 2);
        }

        public bool Overlaps(Circle other)
        {
            return Mathf.Pow(this.position.x - other.position.x, 2)
                 + Mathf.Pow(this.position.y - other.position.y, 2)
                <= Mathf.Pow(this.radius + other.radius, 2);
        }

        public override string ToString()
        {
            return string.Format("(x:{0:F2}, y:{1:F2}, radius:{2:F2})",
                                 this.position.x, this.position.y, this.radius);
        }

        #endregion Method
    }
}