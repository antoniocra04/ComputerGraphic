using GeneralLabs.Model;
using System.Drawing;

namespace GeneralLabs.View.Labs
{
    public partial class Lab4 : Form
    {
        Bitmap Bitmap { get; set; }
        new int Width => PictureBox.Width;
        new int Height => PictureBox.Height;

        /// <summary>
        /// Вдоль оси OZ на плоскость XOY.
        /// </summary>
        TransformMatrix OrthographicXOYMatrix
        {
            get
            {
                var matrix = new TransformMatrix();
                matrix.I = 0;
                return matrix;
            }
        }

        TransformMatrix CenterMatrix
        {
            get
            {
                var matrix = new TransformMatrix();
                matrix.L = Width / 2f;
                matrix.M = Height / 2f;
                matrix.N = 0;
                return matrix;
            }
        }

        TransformMatrix RotateXMatrix
        {
            get
            {
                var matrix = new TransformMatrix();
                matrix.E = (float)Math.Cos(Fi);
                matrix.F = (float)Math.Sin(Fi);
                matrix.H = (float)-Math.Sin(Fi);
                matrix.I = (float)Math.Cos(Fi);
                return matrix;
            }
        }

        TransformMatrix RotateYMatrix
        {
            get
            {
                var matrix = new TransformMatrix();
                matrix.A = (float)Math.Cos(Fi);
                matrix.C = (float)-Math.Sin(Fi);
                matrix.G = (float)Math.Sin(Fi);
                matrix.I = (float)Math.Cos(Fi);
                return matrix;
            }
        }

        TransformMatrix RotateZMatrix
        {
            get
            {
                var matrix = new TransformMatrix();
                matrix.A = (float)Math.Cos(Fi);
                matrix.B = (float)Math.Sin(Fi);
                matrix.D = (float)-Math.Sin(Fi);
                matrix.E = (float)Math.Cos(Fi);
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

        int fi { get; set; } = 0;

        double Fi => (double)(fi / 180f * Math.PI);

        Cube Cube { get; set; } = new Cube();

        int Interval { get; set; } = 50;

        public Lab4()
        {
            InitializeComponent();
        }

        TransformMatrix GetScaleMatrix(float scale)
        {
            var matrix = new TransformMatrix();
            matrix.A = scale;
            matrix.E = scale;
            matrix.I = scale;
            return matrix;
        }

        void DrawCube()
        {
            var pen = new Pen(Color.Black, 5);
            var cube = Cube.Transform(GetScaleMatrix(50)).Transform(RotateXMatrix).Transform(RotateYMatrix).Transform(RotateZMatrix);
            cube = cube.Transform(OrthographicXOYMatrix);
            cube = cube.Transform(CenterMatrix);

            var g = Graphics.FromImage(Bitmap);

            foreach (var vector in cube.Vectors)
            {
                var start = new PointF(vector.Start.X, vector.Start.Y);
                var end = new PointF(vector.End.X, vector.End.Y);
                g.DrawLine(pen, start, end);
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

            var osi = Osi.Transform(GetScaleMatrix(100)).Transform(OrthographicXOYMatrix).Transform(CenterMatrix);

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
            Bitmap.Dispose();
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
            //fi = (fi + 1) % 360;
            Draw();
        }
    }
}
