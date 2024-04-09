using System.Timers;
using ComputerGraphic.Model;

namespace ComputerGraphic.View.Labs.Lab3.Tabs
{
    public partial class Lab3_Task10 : UserControl
    {
        int _interval;

        Bitmap Bitmap { get; set; }

        List<Vector2> Craters { get; set; }

        TransformMatrix MatrixToCenter
        {
            get
            {
                var matrix = new TransformMatrix();
                matrix.M = Width / 2;
                matrix.N = Height / 2;
                return matrix;
            }
        }

        TransformMatrix MatrixToRocketAxis
        {
            get
            {
                var matrix = new TransformMatrix();
                matrix.M = Width / 2 + AxisRadius * Math.Cos(RocketFi);
                matrix.N = Height / 2 + AxisRadius * Math.Sin(RocketFi);
                return matrix;
            }
        }

        TransformMatrix MatrixScale
        {
            get
            {
                var matrix = new TransformMatrix();
                matrix.A = (double)PlanetRadius / InitPlanetRadius;
                matrix.D = (double)PlanetRadius / InitPlanetRadius;
                return matrix;
            }
        }

        TransformMatrix MatrixScaleRocket
        {
            get
            {
                var matrix = MatrixScale.Copy();
                matrix.A *= (1 + Math.Sin(RocketFi)) / 2 * 1.5 + 0.5;
                matrix.D *= (1 + Math.Sin(RocketFi)) / 2 * 1.5 + 0.5;
                return matrix;
            }
        }

        TransformMatrix MatrixRotateRocket
        {
            get
            {
                var matrix = new TransformMatrix();
                matrix.A = Math.Cos(RocketFi);
                matrix.B = Math.Sin(RocketFi);
                matrix.C = -Math.Sin(RocketFi);
                matrix.D = Math.Cos(RocketFi);
                return matrix;
            }
        }

        double rocketFi { get; set; } = 0;

        double deltaRocketFi { get; set; } = 0.5;

        double RocketFi
        {
            get
            {
                return rocketFi / 180.0 * Math.PI;
            }
        }

        TransformMatrix MatrixToUFOAxis
        {
            get
            {
                var matrix = new TransformMatrix();
                matrix.M = Width / 2 + AxisRadius * Math.Cos(UFOFi);
                matrix.N = Height / 2 + AxisRadius * Math.Sin(UFOFi);
                return matrix;
            }
        }

        TransformMatrix MatrixScaleUFO
        {
            get
            {
                var matrix = MatrixScale.Copy();
                matrix.A *= (1 + Math.Sin(UFOFi)) / 2 * 1.5 + 0.5;
                matrix.D *= (1 + Math.Sin(UFOFi)) / 2 * 1.5 + 0.5;
                return matrix;
            }
        }

        TransformMatrix MatrixRotateUFO
        {
            get
            {
                var matrix = new TransformMatrix();
                matrix.A = Math.Cos(UFOFi);
                matrix.B = Math.Sin(UFOFi);
                matrix.C = -Math.Sin(UFOFi);
                matrix.D = Math.Cos(UFOFi);
                return matrix;
            }
        }

        double ufoFi { get; set; } = 180;

        double deltaUFOFi { get; set; } = 0.75;

        double UFOFi
        {
            get
            {
                return ufoFi / 180.0 * Math.PI;
            }
        }

        int InitWidth { get; set; }

        int InitHeight { get; set; }

        int Width
        {
            get
            {
                return PictureBox.Width;
            }
        }
        int Height
        {
            get
            {
                return PictureBox.Height;
            }
        }

        int InitPlanetRadius { get; set; }

        int PlanetRadius
        {
            get
            {
                return Height > Width ? Width / 5 : Height / 5;
            }
        }

        int AxisRadius
        {
            get
            {
                return Height > Width ? Width / 3 : Height / 3;
            }
        }

        int Interval
        {
            get => _interval;
            set
            {
                _interval = value;
                Timer.Interval = value;
            }
        }

        Rocket Rocket { get; set; } = new Rocket();

        UFO UFO { get; set; } = new UFO();

        public Lab3_Task10()
        {
            InitializeComponent();
            Interval = 50;
        }

        public static void DrawCircle(Graphics g, Pen pen,
                                  float centerX, float centerY, float radius)
        {
            g.DrawEllipse(pen, centerX - radius, centerY - radius,
                          radius + radius, radius + radius);
        }

        public static void FillCircle(Graphics g, Brush brush,
                                  float centerX, float centerY, float radius)
        {
            g.FillEllipse(brush, centerX - radius, centerY - radius,
                          radius + radius, radius + radius);
        }

        private bool CheckDistance(Point2 point)
        {
            foreach (var crater in Craters)
            {
                if (point.Distance(crater.A) < PlanetRadius / 3.0)
                {
                    return true;
                }
            }
            return false;
        }

        private void CreateRandomCraters()
        {
            var koef = 1.2;
            Craters = new List<Vector2>();
            var random = new Random();
            var craterAmount = random.Next(8, 12);
            for (int i = 0; i < craterAmount; i++)
            {
                var randomX = random.NextDouble() - 0.5;
                var randomY = random.NextDouble() - 0.5;
                var A = new Point2(
                    koef * PlanetRadius * randomX,
                    koef * PlanetRadius * randomY);

                while (CheckDistance(A))
                {
                    randomX = random.NextDouble() - 0.5;
                    randomY = random.NextDouble() - 0.5;
                    A.X = koef * PlanetRadius * randomX;
                    A.Y = koef * PlanetRadius * randomY;
                }

                var B = new Point2(
                    PlanetRadius / 2 * (0.7 - Math.Abs(randomX)),
                    PlanetRadius / 2 * (0.7 - Math.Abs(randomY)));

                Craters.Add(new Vector2(A, B));
            }
        }

        private List<Vector2> GetScaledCraters()
        {
            var craters = new List<Vector2>();
            foreach (var c in Craters)
            {
                craters.Add(c.Transform(MatrixScale));
            }
            return craters;
        }

        private void DrawScene()
        {
            var g = Graphics.FromImage(Bitmap);
            var backgroundBrush = new SolidBrush(Color.FromArgb(128, 119, 184));
            var planetPen = new Pen(Color.FromArgb(255, 154, 69, 69), 5);
            var craterPen = new Pen(Color.FromArgb(255, 128, 57, 57), 4);
            var planetBrush = new SolidBrush(Color.IndianRed);
            var craterBrush = new SolidBrush(Color.FromArgb(255, 154, 69, 69));
            var center = new Point2().Transform(MatrixToCenter);

            if (Craters == null)
            {
                CreateRandomCraters();
            }

            g.FillRectangle(backgroundBrush, 0, 0, Width, Height);

            DrawCircle(g, planetPen, (float)center.X, (float)center.Y, PlanetRadius);
            FillCircle(g, planetBrush, (float)center.X, (float)center.Y, PlanetRadius);

            var scaledCraters = GetScaledCraters();
            foreach (var craters in scaledCraters)
            {
                craters.A = craters.A.Transform(MatrixToCenter);
                g.DrawEllipse(
                    craterPen,
                    (int)((int)craters.A.X - (int)craters.B.X),
                    (int)((int)craters.A.Y - (int)craters.B.Y),
                    (int)craters.B.X, (int)craters.B.Y);
                g.FillEllipse(
                    craterBrush,
                    (int)((int)craters.A.X - (int)craters.B.X),
                    (int)((int)craters.A.Y - (int)craters.B.Y),
                    (int)craters.B.X, (int)craters.B.Y);
            }

            g.Dispose();

            PictureBox.Image = Bitmap;
        }

        private void DrawRocket()
        {
            var brushRed = new SolidBrush(Color.FromArgb(199, 23, 0));
            var brushFire = new SolidBrush(Color.FromArgb(246, 129, 39));
            var brushWhite = new SolidBrush(Color.FromArgb(211, 200, 198));
            var brushBlue = new SolidBrush(Color.FromArgb(121, 196, 249));
            var g = Graphics.FromImage(Bitmap);
            var rocket = Rocket.Transform(MatrixScaleRocket, MatrixScaleRocket.A).Transform(MatrixRotateRocket, 1).Transform(MatrixToRocketAxis, 1);

            var body = new PointF[4];
            for (int i = 0; i < 4; i++)
            {
                body[i] = new PointF((float)rocket.Body[i].X, (float)rocket.Body[i].Y);
            }

            var bow = new PointF[3];
            for (int i = 0; i < 3; i++)
            {
                bow[i] = new PointF((float)rocket.Bow[i].X, (float)rocket.Bow[i].Y);
            }

            var leftWing = new PointF[3];
            for (int i = 0; i < 3; i++)
            {
                leftWing[i] = new PointF((float)rocket.LeftWing[i].X, (float)rocket.LeftWing[i].Y);
            }

            var rightWing = new PointF[3];
            for (int i = 0; i < 3; i++)
            {
                rightWing[i] = new PointF((float)rocket.RightWing[i].X, (float)rocket.RightWing[i].Y);
            }

            var fire = new PointF[7];
            for (int i = 0; i < 7; i++)
            {
                fire[i] = new PointF((float)rocket.Fire[i].X, (float)rocket.Fire[i].Y);
            }

            g.FillPolygon(brushWhite, body);
            g.FillPolygon(brushRed, bow);
            g.FillPolygon(brushRed, leftWing);
            g.FillPolygon(brushRed, rightWing);
            g.FillPolygon(brushFire, fire);
            FillCircle(g, brushBlue, (float)rocket.Porthole.X, (float)rocket.Porthole.Y, (float)rocket.PortholeRadius);

            g.Dispose();
            PictureBox.Image = Bitmap;
        }

        void DrawUFO()
        {
            var bodyBrush = new SolidBrush(Color.FromArgb(79, 86, 98));
            var bodyPorthole = new SolidBrush(Color.FromArgb(159, 230, 197));
            var ufo = new UFO().Transform(MatrixScaleUFO, MatrixScaleUFO.A).Transform(MatrixRotateUFO, 1).Transform(MatrixToUFOAxis, 1);
            var g = Graphics.FromImage(Bitmap);


            FillCircle(g, bodyBrush, (float)ufo.Center.X, (float)ufo.Center.Y, (float)ufo.BodyRadius);
            FillCircle(g, bodyPorthole, (float)ufo.Center.X, (float)ufo.Center.Y, (float)ufo.PortholeRadius);
            foreach (var window in ufo.Windows)
            {
                FillCircle(g, bodyPorthole, (float) window.X, (float) window.Y, (float) ufo.WindowRadius);
            }

            foreach(var line in ufo.Lines)
            {
                g.DrawLine(new Pen(Color.Black, 4), (int)line.A.X, (int)line.A.Y, (int)line.B.X, (int)line.B.Y);
            }

            g.Dispose();
            PictureBox.Image = Bitmap;
        }

        private void ClearImage()
        {
            if (Bitmap != null)
            {
                Bitmap.Dispose();
            }
            Bitmap = new Bitmap(Width, Height);
            PictureBox.Image = Bitmap;
        }

        private void Repaint()
        {
            ClearImage();
            DrawScene();
            DrawRocket();
            DrawUFO();
        }

        private void Lab3_Task10_Load(object sender, EventArgs e)
        {
            InitWidth = Width;
            InitHeight = Height;
            InitPlanetRadius = PlanetRadius;
            Repaint();
            Timer.Enabled = true;
        }

        private void Lab3_Task10_Resize(object sender, EventArgs e)
        {
            if (InitWidth > 0 && InitHeight > 0)
            {
                Repaint();
            }
        }

        private void IntervalTrackBar_Scroll(object sender, EventArgs e)
        {
            deltaRocketFi = IntervalTrackBar.Value / 100.0;
            deltaUFOFi = IntervalTrackBar.Value / 100.0 / 0.5 * 0.75;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            rocketFi = (rocketFi - deltaRocketFi) % 360;
            ufoFi = (ufoFi + deltaUFOFi) % 360;
            Repaint();
        }
    }
}
