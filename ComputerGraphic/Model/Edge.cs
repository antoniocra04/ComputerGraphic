namespace ComputerGraphic.Model
{
    public class Edge
    {
        public List<Point3> Vertices { get; set; } = new List<Point3>();

        public List<Vector3> Vectors
        {
            get
            {
                var vectors = new List<Vector3>();

                for (int i = 0; i < Vertices.Count; i++)
                {
                    if (i == Vertices.Count - 1)
                    {
                        vectors.Add(new Vector3(Vertices[i], Vertices[0]));
                    }
                    else
                    {
                        vectors.Add(new Vector3(Vertices[i], Vertices[i + 1]));
                    }
                }

                return vectors;
            }
        }

        public Edge()
        {

        }

        public Edge(Point3 point1, Point3 point2, Point3 point3)
        {
            Vertices.Add(point1);
            Vertices.Add(point2);
            Vertices.Add(point3);
        }

        public Edge(Point3 point1, Point3 point2, Point3 point3, Point3 point4)
        {
            Vertices.Add(point1);
            Vertices.Add(point2);
            Vertices.Add(point3);
            Vertices.Add(point4);
        }

        public Edge Transform(TransformMatrix3 matrix)
        {
            var edge = new Edge();

            foreach (var vertice in Vertices)
            {
                edge.Vertices.Add(vertice.Transform(matrix));
            }

            return edge;
        }

        public bool IsVisibleFrom(Point3 barycenter, Point3 observer)
        {
            var x1 = Vertices[0].X - Vertices[1].X;
            var x2 = Vertices[2].X - Vertices[1].X;
            var y1 = Vertices[0].Y - Vertices[1].Y;
            var y2 = Vertices[2].Y - Vertices[1].Y;
            var z1 = Vertices[0].Z - Vertices[1].Z;
            var z2 = Vertices[2].Z - Vertices[1].Z;

            var a = y1 * z2 - y2 * z1;
            var b = z1 * x2 - z2 * x1;
            var c = x1 * y2 - x2 * y1;
            var d = -(a * Vertices[0].X + b * Vertices[0].Y + c * Vertices[0].Z);

            var m = -MathF.Sign(a * barycenter.X + b * barycenter.Y + c * barycenter.Z + d);

            a *= m;
            b *= m;
            c *= m;
            d *= m;

            return a * observer.X + b * observer.Y + c * observer.Z + d > 0;
        }
    }
}
