namespace ComputerGraphic.Model
{
    public class Vector2
    {
        public Point2 A {  get; set; }
        public Point2 B { get; set; }

        public Vector2()
        {
            A = new Point2();
            B = new Point2();
        }

        public Vector2(Point2 a, Point2 b)
        {
            A = a;
            B = b;
        }

        public Vector2(double x1, double y1, double x2, double y2)
        {
            A = new Point2(x1, y1);
            B = new Point2(x2, y2);
        }

        public Vector2 Copy()
        {
            return new Vector2(A.Copy(), B.Copy());
        }

        public Vector2 Transform(TransformMatrix matrix)
        {
            var vector = Copy();

            vector.A = vector.A.Transform(matrix);
            vector.B = vector.B.Transform(matrix);

            return vector;
        }

        public double Distance()
        {
            return A.Distance(B);
        }
    }
}
