using ComputerGraphic.Model;
using System.Reflection;

namespace ComputerGraphic.View.Labs.Lab4.Tabs
{
    public partial class Lab4_Task2_1 : UserControl
    {
        private float xLocation = 0;
        private float yLocation = 0;
        private float zLocation = 0;
        private float xRotation = 20;
        private float yRotation = 20;
        private float zRotation = 0;
        private float xScale = 1;
        private float yScale = 1;
        private float zScale = 1;

        Bitmap Bitmap { get; set; }
        new int Width => PictureBox.Width;
        new int Height => PictureBox.Height;

        /// <summary>
        /// Вдоль оси OZ на плоскость XOY.
        /// </summary>
        TransformMatrix3 DimetricXOYMatrix
        {
            get
            {
                var matrix = new TransformMatrix3();

                var alpha = 22.208f / 180f * MathF.PI;
                var beta = 20.705f / 180f * MathF.PI;

                matrix.A = MathF.Cos(alpha);
                matrix.B = MathF.Sin(alpha) * MathF.Sin(beta);
                matrix.E = MathF.Cos(beta);
                matrix.G = MathF.Sin(alpha);
                matrix.H = -MathF.Cos(alpha) * MathF.Sin(beta);
                matrix.I = 0;
                return matrix;
            }
        }

        TransformMatrix3 CenterMatrix
        {
            get
            {
                var matrix = new TransformMatrix3();
                matrix.L = Width / 2f;
                matrix.M = Height / 2f;
                matrix.N = 0;
                return matrix;
            }
        }

        TransformMatrix3 XOYDisplayMatrix
        {
            get
            {
                var matrix = new TransformMatrix3();
                matrix.I = -1;
                return matrix;
            }
        }

        TransformMatrix3 YOZDisplayMatrix
        {
            get
            {
                var matrix = new TransformMatrix3();
                matrix.A = -1;
                return matrix;
            }
        }

        TransformMatrix3 XOZDisplayMatrix
        {
            get
            {
                var matrix = new TransformMatrix3();
                matrix.E = -1;
                return matrix;
            }
        }

        Model3 Osi
        {
            get
            {
                var osi = new Model3();
                osi.Points.Add(new Point3(0, 0, 0));
                osi.Points.Add(new Point3(1, 0, 0));
                osi.Points.Add(new Point3(0, 1, 0));
                osi.Points.Add(new Point3(0, 0, 1));
                osi.Vectors.Add(new Model3.VectorIndexed(0, 1));
                osi.Vectors.Add(new Model3.VectorIndexed(0, 2));
                osi.Vectors.Add(new Model3.VectorIndexed(0, 3));
                return osi;
            }
        }

        Figure Cube { get; set; } = new Figure();

        int Interval { get; set; } = 50;

        public Lab4_Task2_1()
        {
            InitializeComponent();
        }

        TransformMatrix3 GetScaleMatrix(float scale)
        {
            var matrix = new TransformMatrix3();
            matrix.A = scale;
            matrix.E = scale;
            matrix.I = scale;
            return matrix;
        }

        TransformMatrix3 GetScaleMatrix(float x, float y, float z)
        {
            var matrix = new TransformMatrix3();
            matrix.A = x;
            matrix.E = y;
            matrix.I = z;
            return matrix;
        }

        TransformMatrix3 GetLocationMatrix(float x, float y, float z)
        {
            var matrix = new TransformMatrix3();
            matrix.L = x;
            matrix.M = y;
            matrix.N = z;
            return matrix;
        }

        TransformMatrix3 GetRotateXMatrix(float fi)
        {
            var rad = fi / 180 * MathF.PI;
            var matrix = new TransformMatrix3();
            matrix.E = MathF.Cos(rad);
            matrix.F = MathF.Sin(rad);
            matrix.H = -MathF.Sin(rad);
            matrix.I = MathF.Cos(rad);
            return matrix;
        }

        TransformMatrix3 GetRotateYMatrix(float fi)
        {
            var rad = fi / 180 * MathF.PI;
            var matrix = new TransformMatrix3();
            matrix.A = MathF.Cos(rad);
            matrix.C = -MathF.Sin(rad);
            matrix.G = MathF.Sin(rad);
            matrix.I = MathF.Cos(rad);
            return matrix;
        }

        TransformMatrix3 GetRotateZMatrix(float fi)
        {
            var rad = fi / 180 * MathF.PI;
            var matrix = new TransformMatrix3();
            matrix.A = MathF.Cos(rad);
            matrix.B = MathF.Sin(rad);
            matrix.D = -MathF.Sin(rad);
            matrix.E = MathF.Cos(rad);
            return matrix;
        }

        void DrawCube()
        {
            var pen = new Pen(Color.Black, 5);
            var cube = Cube.Transform(GetScaleMatrix(50));

            cube = cube.Transform(GetLocationMatrix(0, 0, 0));
            cube = cube.Transform(DimetricXOYMatrix).Transform(CenterMatrix);

            var g = Graphics.FromImage(Bitmap);

            foreach (var vector in cube.Vectors)
            {
                var start = new PointF(vector.Start.X, vector.Start.Y);
                var end = new PointF(vector.End.X, vector.End.Y);
                g.DrawLine(vector.Pen, start, end);
            }

            g.Dispose();
            PictureBox.Image = Bitmap;
        }

        void DrawOsi()
        {
            var penSize = 2;
            var xPen = new Pen(Color.Red, penSize);
            var yPen = new Pen(Color.Green, penSize);
            var zPen = new Pen(Color.Blue, penSize);

            var osi = Osi.Transform(GetScaleMatrix(100)).Transform(DimetricXOYMatrix).Transform(CenterMatrix);

            var g = Graphics.FromImage(Bitmap);

            g.DrawLine(
                xPen,
                new PointF(osi.Points[osi.Vectors[0][0]].X, osi.Points[osi.Vectors[0][0]].Y),
                new PointF(osi.Points[osi.Vectors[0][1]].X, osi.Points[osi.Vectors[0][1]].Y));

            g.DrawLine(
                yPen,
                new PointF(osi.Points[osi.Vectors[1][0]].X, osi.Points[osi.Vectors[1][0]].Y),
                new PointF(osi.Points[osi.Vectors[1][1]].X, osi.Points[osi.Vectors[1][1]].Y));

            g.DrawLine(
                zPen,
                new PointF(osi.Points[osi.Vectors[2][0]].X, osi.Points[osi.Vectors[2][0]].Y),
                new PointF(osi.Points[osi.Vectors[2][1]].X, osi.Points[osi.Vectors[2][1]].Y));

            g.Dispose();
            PictureBox.Image = Bitmap;
        }

        void Draw()
        {
            Clear();
            DrawOsi();
            DrawCube();
        }

        void Clear()
        {
            Bitmap?.Dispose();
            Bitmap = new Bitmap(Width, Height);
            PictureBox.Image = Bitmap;
        }

        private void Lab4_Load(object sender, EventArgs e)
        {

            Bitmap = new Bitmap(Width, Height);
            Draw();
            Timer.Interval = Interval;
            Timer.Enabled = true;
        }

        private void Lab4_Resize(object sender, EventArgs e)
        {
            Draw();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
