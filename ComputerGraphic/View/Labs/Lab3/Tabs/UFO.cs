using ComputerGraphic.Model;
using static System.Windows.Forms.LinkLabel;

namespace ComputerGraphic.View.Labs.Lab3.Tabs
{
    public struct UFO
    {
        public Point2 Center { get; set; }
        public List<Point2> Windows { get; set; }
        public List<Vector2> Lines { get; set; }

        public double BodyRadius { get; set; }
        public double PortholeRadius { get; set; }
        public double WindowRadius { get; set; }
        public UFO() 
        {
            Center = new Point2();
            Windows = new List<Point2>();

            for (var i = 0; i < 8; i++)
            {
                Windows.Add(new Point2(20 * Math.Cos(Math.PI * i / 4), 20 * Math.Sin(Math.PI * i / 4)));
            }

            Lines = new List<Vector2>();
            Lines.Add(new Vector2(0, -35, 0, -50));
            Lines.Add(new Vector2(10, -25, 10, -40));
            Lines.Add(new Vector2(-10, -25, -10, -40));

            BodyRadius = 25;
            PortholeRadius = 10;
            WindowRadius = 2;
        }

        public UFO(
            Point2 center, 
            List<Point2> windows, 
            List<Vector2> lines,
            double bodyRadius, 
            double portholeRadius, 
            double windowRadius)
        {
            Center = center;
            Windows = windows;
            Lines = lines;
            BodyRadius = bodyRadius;
            PortholeRadius = portholeRadius;
            WindowRadius = windowRadius;
        }

        public UFO Transform(TransformMatrix matrix, double scaleRadius)
        {
            var center = Center.Transform(matrix);
            var windows = new List<Point2>();

            foreach (var window in Windows)
            {
                windows.Add(window.Transform(matrix));
            }

            var lines = new List<Vector2>();

            foreach (var line in Lines)
            {
                lines.Add(line.Transform(matrix));
            }

            var bodyRadius = BodyRadius * scaleRadius;
            var portholeRadius = PortholeRadius * scaleRadius;
            var windowRadius = WindowRadius * scaleRadius;

            return new UFO(center, windows, lines, bodyRadius, portholeRadius, windowRadius);
        }
    }
}
