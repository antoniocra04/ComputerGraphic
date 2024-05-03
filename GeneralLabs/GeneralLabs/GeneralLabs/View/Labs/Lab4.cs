using GeneralLabs.Model;
using System.Drawing;

namespace GeneralLabs.View.Labs
{
    public partial class Lab4 : Form
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

        TransformMatrix XOYDisplayMatrix
        {
            get
            {
                var matrix = new TransformMatrix();
                matrix.I = -1;
                return matrix;
            }
        }

        TransformMatrix YOZDisplayMatrix
        {
            get
            {
                var matrix = new TransformMatrix();
                matrix.A = -1;
                return matrix;
            }
        }

        TransformMatrix XOZDisplayMatrix
        {
            get
            {
                var matrix = new TransformMatrix();
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

        int fi { get; set; } = 0;

        float Fi => fi / 180f * MathF.PI;

        Cube Cube { get; set; } = new Cube();

        int Interval { get; set; } = 50;

        bool XOYDisplay { get; set; } = false;
        bool YOZDisplay { get; set; } = false;
        bool XOZDisplay { get; set; } = false;

        float XLocation
        {
            get => xLocation;
            set
            {
                xLocation = value;
                XLocationTextBox.Text = XLocation.ToString();
            }
        }
        float YLocation
        {
            get => yLocation;
            set
            {
                yLocation = value;
                YLocationTextBox.Text = YLocation.ToString();
            }
        }
        float ZLocation
        {
            get => zLocation;
            set
            {
                zLocation = value;
                ZLocationTextBox.Text = ZLocation.ToString();
            }
        }
        float XRotation
        {
            get => xRotation;
            set
            {
                xRotation = value;
                XRotationTextBox.Text = XRotation.ToString();
            }
        }
        float YRotation
        {
            get => yRotation;
            set
            {
                yRotation = value;
                YRotationTextBox.Text = YRotation.ToString();
            }
        }
        float ZRotation
        {
            get => zRotation;
            set
            {
                zRotation = value;
                ZRotationTextBox.Text = ZRotation.ToString();
            }
        }
        float XScale
        {
            get => xScale;
            set
            {
                xScale = value;
                XScaleTextBox.Text = XScale.ToString();
            }
        }
        float YScale
        {
            get => yScale;
            set
            {
                yScale = value;
                YScaleTextBox.Text = YScale.ToString();
            }
        }
        float ZScale
        {
            get => zScale;
            set
            {
                zScale = value;
                ZScaleTextBox.Text = ZScale.ToString();
            }
        }

        float MoveSpeed { get; set; } = 1f;
        float RotateSpeed { get; set; } = 1f;
        float ScaleSpeed { get; set; } = 1f;
        bool IsMoveX { get; set; } = false;
        bool IsMoveY { get; set; } = false;
        bool IsMoveZ { get; set; } = false;
        bool IsRotateX { get; set; } = false;
        bool IsRotateY { get; set; } = false;
        bool IsRotateZ { get; set; } = false;
        bool IsScaleX { get; set; } = false;
        bool IsScaleY { get; set; } = false;
        bool IsScaleZ { get; set; } = false;


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

        TransformMatrix GetScaleMatrix(float x, float y, float z)
        {
            var matrix = new TransformMatrix();
            matrix.A = x;
            matrix.E = y;
            matrix.I = z;
            return matrix;
        }

        TransformMatrix GetLocationMatrix(float x, float y, float z)
        {
            var matrix = new TransformMatrix();
            matrix.L = x;
            matrix.M = y;
            matrix.N = z;
            return matrix;
        }

        TransformMatrix GetRotateXMatrix(float fi)
        {
            var rad = fi / 180 * MathF.PI;
            var matrix = new TransformMatrix();
            matrix.E = MathF.Cos(rad);
            matrix.F = MathF.Sin(rad);
            matrix.H = -MathF.Sin(rad);
            matrix.I = MathF.Cos(rad);
            return matrix;
        }

        TransformMatrix GetRotateYMatrix(float fi)
        {
            var rad = fi / 180 * MathF.PI;
            var matrix = new TransformMatrix();
            matrix.A = MathF.Cos(rad);
            matrix.C = -MathF.Sin(rad);
            matrix.G = MathF.Sin(rad);
            matrix.I = MathF.Cos(rad);
            return matrix;
        }

        TransformMatrix GetRotateZMatrix(float fi)
        {
            var rad = fi / 180 * MathF.PI;
            var matrix = new TransformMatrix();
            matrix.A = MathF.Cos(rad);
            matrix.B = MathF.Sin(rad);
            matrix.D = -MathF.Sin(rad);
            matrix.E = MathF.Cos(rad);
            return matrix;
        }

        void DrawCube()
        {
            var pen = new Pen(Color.Black, 5);
            var cube = Cube.Transform(GetScaleMatrix(50)).Transform(GetScaleMatrix(XScale, YScale, ZScale));
            cube = cube.Transform(GetRotateXMatrix(XRotation)).Transform(GetRotateYMatrix(YRotation)).Transform(GetRotateZMatrix(ZRotation));

            if (XOYDisplay)
            {
                cube = cube.Transform(XOYDisplayMatrix);
            }
            if (YOZDisplay)
            {
                cube = cube.Transform(YOZDisplayMatrix);
            }
            if (XOZDisplay)
            {
                cube = cube.Transform(XOZDisplayMatrix);
            }

            cube = cube.Transform(GetLocationMatrix(XLocation, YLocation, ZLocation));
            cube = cube.Transform(OrthographicXOYMatrix).Transform(CenterMatrix);

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
            XLocation = 0;
            YLocation = 0;
            ZLocation = 0;
            XRotation = 20;
            YRotation = 20;
            ZRotation = 0;
            XScale = 1;
            YScale = 1;
            ZScale = 1;

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
            if (IsMoveX)
            {
                XLocation += IsXLNeg.Checked ? -MoveSpeed : MoveSpeed;
            }
            if (IsMoveY)
            {
                YLocation += IsYLNeg.Checked ? -MoveSpeed : MoveSpeed;
            }
            if (IsMoveZ)
            {
                ZLocation += IsZLNeg.Checked ? -MoveSpeed : MoveSpeed;

            }
            if (IsRotateX)
            {
                XRotation += IsXRNeg.Checked ? -RotateSpeed : RotateSpeed;
            }
            if (IsRotateY)
            {
                YRotation += IsYRNeg.Checked ? -RotateSpeed : RotateSpeed;
            }
            if (IsRotateZ)
            {
                ZRotation += IsZRNeg.Checked ? -RotateSpeed : RotateSpeed;
            }
            if (IsScaleX)
            {
                XScale += IsXSNeg.Checked ? -ScaleSpeed : ScaleSpeed;
            }
            if (IsScaleY)
            {
                YScale += IsYSNeg.Checked ? -ScaleSpeed : ScaleSpeed;
            }
            if (IsScaleZ)
            {
                ZScale += IsZSNeg.Checked ? -ScaleSpeed : ScaleSpeed;
            }
            Draw();
        }

        private void XLocationTextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;

            try
            {
                XLocation = float.Parse(textBox.Text);
                textBox.BackColor = Color.White;
            }
            catch
            {
                textBox.BackColor = Color.LightPink;
            }
        }

        private void YLocationTextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;

            try
            {
                YLocation = float.Parse(textBox.Text);
                textBox.BackColor = Color.White;
            }
            catch
            {
                textBox.BackColor = Color.LightPink;
            }
        }

        private void ZLocationTextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;

            try
            {
                ZLocation = float.Parse(textBox.Text);
                textBox.BackColor = Color.White;
            }
            catch
            {
                textBox.BackColor = Color.LightPink;
            }
        }

        private void XRotationTextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;

            try
            {
                XRotation = float.Parse(textBox.Text);
                textBox.BackColor = Color.White;
            }
            catch
            {
                textBox.BackColor = Color.LightPink;
            }
        }

        private void YRotationTextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;

            try
            {
                YRotation = float.Parse(textBox.Text);
                textBox.BackColor = Color.White;
            }
            catch
            {
                textBox.BackColor = Color.LightPink;
            }
        }

        private void ZRotationTextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;

            try
            {
                ZRotation = float.Parse(textBox.Text);
                textBox.BackColor = Color.White;
            }
            catch
            {
                textBox.BackColor = Color.LightPink;
            }
        }

        private void XScaleTextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;

            try
            {
                XScale = float.Parse(textBox.Text);
                textBox.BackColor = Color.White;
            }
            catch
            {
                textBox.BackColor = Color.LightPink;
            }
        }

        private void YScaleTextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;

            try
            {
                YScale = float.Parse(textBox.Text);
                textBox.BackColor = Color.White;
            }
            catch
            {
                textBox.BackColor = Color.LightPink;
            }
        }

        private void ZScaleTextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;

            try
            {
                ZScale = float.Parse(textBox.Text);
                textBox.BackColor = Color.White;
            }
            catch
            {
                textBox.BackColor = Color.LightPink;
            }
        }

        private void OXButton_Click(object sender, EventArgs e)
        {
            XOYDisplay = !XOYDisplay;
        }

        private void OYButton_Click(object sender, EventArgs e)
        {
            YOZDisplay = !YOZDisplay;
        }

        private void OZButton_Click(object sender, EventArgs e)
        {
            XOZDisplay = !XOZDisplay;
        }

        private void XYLButton_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void XYLButton_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            IsMoveX = true;
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            IsMoveX = false;
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            IsMoveY = true;
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            IsMoveY = false;
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            IsMoveZ = true;
        }

        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            IsMoveZ = false;
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            IsRotateX = true;
        }

        private void label4_MouseUp(object sender, MouseEventArgs e)
        {
            IsRotateX = false;
        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            IsRotateY = true;
        }

        private void label5_MouseUp(object sender, MouseEventArgs e)
        {
            IsRotateY = false;
        }

        private void label6_MouseDown(object sender, MouseEventArgs e)
        {
            IsRotateZ = true;
        }

        private void label6_MouseUp(object sender, MouseEventArgs e)
        {
            IsRotateZ = false;
        }

        private void label7_MouseDown(object sender, MouseEventArgs e)
        {
            IsScaleX = true;
        }

        private void label7_MouseUp(object sender, MouseEventArgs e)
        {
            IsScaleX = false;
        }

        private void label8_MouseDown(object sender, MouseEventArgs e)
        {
            IsScaleY = true;
        }

        private void label8_MouseUp(object sender, MouseEventArgs e)
        {
            IsScaleY = false;
        }

        private void label9_MouseDown(object sender, MouseEventArgs e)
        {
            IsScaleZ = true;
        }

        private void label9_MouseUp(object sender, MouseEventArgs e)
        {
            IsScaleZ = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;

            try
            {
                MoveSpeed = float.Parse(textBox.Text);
                textBox.BackColor = Color.White;
            }
            catch
            {
                textBox.BackColor = Color.LightPink;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;

            try
            {
                RotateSpeed = float.Parse(textBox.Text);
                textBox.BackColor = Color.White;
            }
            catch
            {
                textBox.BackColor = Color.LightPink;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;

            try
            {
                ScaleSpeed = float.Parse(textBox.Text);
                textBox.BackColor = Color.White;
            }
            catch
            {
                textBox.BackColor = Color.LightPink;
            }
        }
    }
}
