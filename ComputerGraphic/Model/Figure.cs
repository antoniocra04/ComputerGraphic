namespace ComputerGraphic.Model
{
    public class Figure
    {
        public List<Point3> Points { get; set; } = new List<Point3>();
        public List<Edge> Edges { get; set; } = new List<Edge>();

        public Point3 Barycenter
        {
            get
            {
                var barycenter = new Point3();

                if (Points.Count == 0)
                {
                    throw new Exception();
                }

                foreach (var point in Points)
                {
                    barycenter.X += point.X;
                    barycenter.Y += point.Y;
                    barycenter.Z += point.Z;
                }

                barycenter.X /= Points.Count;
                barycenter.Y /= Points.Count;
                barycenter.Z /= Points.Count;

                return barycenter;
            }
        }

        public Figure()
        {
            var figurePen = new Pen(Color.Black, 5);
            var xPen = new Pen(Color.Red, 2);
            var yPen = new Pen(Color.Green, 2);
            var zPen = new Pen(Color.Blue, 2);

            //Vectors.Add(new Vector3(0, 0, 0, 1, 0, 0, xPen));
            //Vectors.Add(new Vector3(0, 0, 0, 0, 1, 0, yPen));
            //Vectors.Add(new Vector3(0, 0, 0, 0, 0, 1, zPen));

            Points.Add(new Point3(0, 1, 0));
            Points.Add(new Point3(0, -1, 0));
            Points.Add(new Point3(1, 0, 0));
            Points.Add(new Point3(-0.7f, 0, 0.7f));
            Points.Add(new Point3(-0.7f, 0, -0.7f));

            Edges.Add(new Edge(
                Points[0],
                Points[2],
                Points[3]));

            Edges.Add(new Edge(
                Points[0],
                Points[3],
                Points[4]));

            Edges.Add(new Edge(
                Points[0],
                Points[4],
                Points[2]));


            Edges.Add(new Edge(
                Points[1],
                Points[2],
                Points[3]));

            Edges.Add(new Edge(
                Points[1],
                Points[3],
                Points[4]));

            Edges.Add(new Edge(
                Points[1],
                Points[4],
                Points[2]));
        }

        public Figure(List<Point3> points, List<Edge> edges)
        {
            Points = points;
            Edges = edges;
        }

        public Figure Transform(TransformMatrix3 matrix)
        {
            var edges = new List<Edge>();
            var points = new List<Point3>();

            foreach (var edge in Edges)
            {
                edges.Add(edge.Transform(matrix));
            }


            foreach (var point in Points)
            {
                points.Add(point.Transform(matrix));
            }

            return new Figure(points, edges);
        }
    }
}
