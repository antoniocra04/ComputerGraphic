namespace GeneralLabs.Model
{
    public class Vector3 : IEquatable<Vector3>, ICloneable
    {
        public Point3 Start { get; set; }

        public Point3 End { get; set; }

        public Pen Pen { get; set; }

        public Vector3()
        {
            Start = new Point3();
            End = new Point3();
            Pen = new Pen(Color.Black, 1);
        }

        public Vector3(Point3 start, Point3 end)
        {
            Start = start;
            End = end;
            Pen = new Pen(Color.Black, 1);
        }

        public Vector3(Point3 start, Point3 end, Pen pen)
        {
            Start = start;
            End = end;
            Pen = pen;
        }

        public Vector3(float x1, float y1, float z1, float x2, float y2, float z2)
        {
            Start = new Point3(x1, y1, z1);
            End = new Point3(x2, y2, z2);
            Pen = new Pen(Color.Black, 1);
        }

        public Vector3(float x1, float y1, float z1, float x2, float y2, float z2, Pen pen)
        {
            Start = new Point3(x1, y1, z1);
            End = new Point3(x2, y2, z2);
            Pen = pen;
        }

        public Vector3 Transform(TransformMatrix matrix)
        {
            return new Vector3(Start.Transform(matrix), End.Transform(matrix), Pen);
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
