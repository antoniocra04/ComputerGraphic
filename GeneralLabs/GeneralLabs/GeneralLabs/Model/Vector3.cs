namespace GeneralLabs.Model
{
    public class Vector3 : IEquatable<Vector3>, ICloneable
    {
        public Point3 Start { get; set; }

        public Point3 End { get; set; }

        public Vector3()
        {
            Start = new Point3();
            End = new Point3();
        }

        public Vector3(Point3 start, Point3 end)
        {
            Start = start;
            End = end;
        }

        public Vector3 Transform(TransformMatrix matrix)
        {
            return new Vector3(Start.Transform(matrix), End.Transform(matrix));
        }

        public bool Equals(Vector3 other)
        {
            return Start.Equals(other.Start);
        }

        public object Clone()
        {
            return new Vector3((Point3)Start.Clone(), (Point3)End.Clone());
        }
    }
}
