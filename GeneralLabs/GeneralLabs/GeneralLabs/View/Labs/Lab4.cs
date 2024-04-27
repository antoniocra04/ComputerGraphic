using GeneralLabs.Model;

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

        int fi { get; set; } = 0;

        double Fi => (double)(fi / 180f * Math.PI);

        Cube Cube { get; set; } = new Cube();

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

            PictureBox.Image = Bitmap;
        }

        void Draw()
        {
            Clear();
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
            Timer.Enabled = true;
        }

        private void Lab4_Resize(object sender, EventArgs e)
        {
            Draw();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            fi = (fi + 1) % 360;
            Draw();
        }
    }
}
