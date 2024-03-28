namespace ComputerGraphic.View.Labs.Lab2.Tabs
{
    public partial class PolygonColoringAlgorithm : UserControl
    {
        List<Point> Points;

        private int xn, yn, xk, yk;
        private Bitmap Bitmap { get; set; }

        private int defaultWidth;
        private int defaultHeight;

        public Color BorderColor { get; set; } = Color.Black;

        public Color FillColor { get; set; } = Color.AliceBlue;

        public int BrushSize { get; set; } = 3;

        public int EdgeNumber = 3;

        bool IsCanceled = false;

        public bool IsAnimationMode
        {
            get
            {
                return AnimationModeСheckBox.Checked;
            }
        }

        public PolygonColoringAlgorithm()
        {
            InitializeComponent();
            Bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            PictureBox.DrawToBitmap(Bitmap, PictureBox.ClientRectangle);
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            xn = e.X;
            yn = e.Y;

            //MessageBox.Show($"Point into figure is {IsPointIntoFigure(e.X, e.Y)}");
        }

        private Point GetCenter()
        {
            var width = PictureBox.Width;
            var height = PictureBox.Height;
            return new Point(width / 2, height / 2);
        }

        private Point Sum(Point first, Point second)
        {
            return new Point(first.X + second.X, first.Y + second.Y);
        }

        private Point[] GetTriangle()
        {
            var center = GetCenter();
            var side = PictureBox.Width < PictureBox.Height ? PictureBox.Width / 3 : PictureBox.Height / 3;

            System.Drawing.Point[] points =
                {
                    Sum(center, new Point(0, -side)),
                    Sum(center, new Point(-side, side)),
                    Sum(center, new Point(side, side))
                };
            Points = new List<Point>(points);
            return points;
        }

        private Point[] GetCube()
        {
            var center = GetCenter();
            var side = PictureBox.Width < PictureBox.Height ? PictureBox.Width / 3 : PictureBox.Height / 3;

            System.Drawing.Point[] points =
                {
                    Sum(center, new Point(-side, -side)),
                    Sum(center, new Point(side, -side)),
                    Sum(center, new Point(side, side)),
                    Sum(center, new Point(-side, side))
                };
            Points = new List<Point>(points);
            return points;
        }

        private Point[] GetPentagon()
        {
            var center = GetCenter();
            var side = PictureBox.Width < PictureBox.Height ? PictureBox.Width / 4 : PictureBox.Height / 4;

            System.Drawing.Point[] points =
                {
                    Sum(center, new Point((int)(-side * 1.5), (int)(-side * 0.5))),
                    Sum(center, new Point(0, (int)(-side * 1.5))),
                    Sum(center, new Point((int)(side * 1.5), (int)(-side * 0.5))),
                    Sum(center, new Point(side, side)),
                    Sum(center, new Point(-side, side))
                };
            Points = new List<Point>(points);
            return points;
        }

        private Point[] GetHexagon()
        {
            var center = GetCenter();
            var side = PictureBox.Width < PictureBox.Height ? PictureBox.Width / 3 : PictureBox.Height / 3;

            System.Drawing.Point[] points =
                {
                    Sum(center, new Point(-side, -side / 2)),
                    Sum(center, new Point(0, -side)),
                    Sum(center, new Point(side, -side / 2)),
                    Sum(center, new Point(side, side / 2)),
                    Sum(center, new Point(0, side)),
                    Sum(center, new Point(-side, side / 2))
                };
            Points = new List<Point>(points);
            return points;
        }

        private Point[] GetHeptagon()
        {
            var center = GetCenter();
            var side = PictureBox.Width < PictureBox.Height ? PictureBox.Width / 4 : PictureBox.Height / 4;

            System.Drawing.Point[] points =
                {
                    Sum(center, new Point(-side, -side)),
                    Sum(center, new Point(0, (int)(-side * 1.5))),
                    Sum(center, new Point(side, -side)),
                    Sum(center, new Point((int)(side * 1.25), 0)),
                    Sum(center, new Point((int)(side / 1.5), side)),
                    Sum(center, new Point((int)(-side / 1.5), side)),
                    Sum(center, new Point((int)(-side * 1.25), 0))
                };
            Points = new List<Point>(points);
            return points;
        }

        private Point[] GetOctagon()
        {
            var center = GetCenter();
            var side = PictureBox.Width < PictureBox.Height ? PictureBox.Width / 3 : PictureBox.Height / 3;

            var coef = 2.5;

            System.Drawing.Point[] points =
                {
                    Sum(center, new Point((int)(-side / coef), -side)),
                    Sum(center, new Point((int)(side / coef), -side)),
                    Sum(center, new Point(side, (int)(-side / coef))),
                    Sum(center, new Point(side, (int)(side / coef))),
                    Sum(center, new Point((int)(side / coef), side)),
                    Sum(center, new Point((int)(-side / coef), side)),
                    Sum(center, new Point(-side, (int)(side / coef))),
                    Sum(center, new Point(-side, (int)(-side / coef)))
                };
            Points = new List<Point>(points);
            return points;
        }


        private void DrawPolygon(int brushSize = 3)
        {
            Pen pen = new Pen(BorderColor, brushSize);
            Graphics g = Graphics.FromImage(Bitmap);

            Point[] figure;

            switch (NumericUpDown.Value)
            {
                case 3:
                    figure = GetTriangle();
                    break;
                case 4:
                    figure = GetCube();
                    break;
                case 5:
                    figure = GetPentagon();
                    break;
                case 6:
                    figure = GetHexagon();
                    break;
                case 7:
                    figure = GetHeptagon();
                    break;
                case 8:
                    figure = GetOctagon();
                    break;
                default:
                    figure = GetTriangle();
                    break;
            }

            g.DrawPolygon(pen, figure);
            PictureBox.Image = Bitmap;
        }

        private void DeleteVectors()
        {
            Bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            DrawPolygon();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DeleteVectors();
        }

        private void ChangeEnables()
        {
            StartButton.Enabled = !StartButton.Enabled;
            ClearButton.Enabled = !ClearButton.Enabled;
            CancelButton.Enabled = !CancelButton.Enabled;
            AnimationModeСheckBox.Enabled = !AnimationModeСheckBox.Enabled;
            NumericUpDown.Enabled = !NumericUpDown.Enabled;
        }

        private async void XYAlgorithm()
        {
            ChangeEnables();
            DeleteVectors();
            var minY = Points[0].Y;
            var maxY = Points[0].Y;
            foreach (var point in Points)
            {
                if (point.Y < minY)
                {
                    minY = point.Y;
                }

                if (point.Y > maxY)
                {
                    maxY = point.Y;
                }
            }

            for (var y = minY; y < maxY; y++)
            {
                if (IsCanceled)
                {
                    DeleteVectors();
                    ChangeEnables();
                    IsCanceled = false;
                    return;
                }
                var intersections = new List<Point>();
                var iterationPoint = Points[0];
                for (var p = 1; p <= Points.Count; p++)
                {
                    Point point;
                    if (p == Points.Count)
                    {
                        point = Points[0];
                    }
                    else
                    {
                        point = Points[p];
                    }

                    double x;

                    if (point.X == iterationPoint.X)
                    {
                        x = point.X;
                    }
                    else
                    {
                        var m = (point.Y - iterationPoint.Y) / (double)(point.X - iterationPoint.X);
                        x = iterationPoint.X + (1.0 / m) * (y - iterationPoint.Y);
                    }

                    

                    if (
                        ((iterationPoint.Y <= y && y <= point.Y) ||
                        (point.Y <= y && y <= iterationPoint.Y)) &&
                        ((iterationPoint.X <= x && x <= point.X) ||
                        (point.X <= x && x <= iterationPoint.X)))
                    {
                        var newPoint = new Point((int)x, y);

                        if (!intersections.Contains(newPoint))
                        {
                            intersections.Add(newPoint);
                        }
                    }

                    

                    iterationPoint = point;
                }

                for (var i = 0; i < intersections.Count; i++)
                {
                    for (var j = 0; j < intersections.Count - 1; j++)
                    {
                        if (intersections[j].X > intersections[j + 1].X)
                        {
                            var temp = intersections[j];
                            intersections[j] = intersections[j + 1];
                            intersections[j + 1] = temp;
                        }
                    }
                }

                for (var i = 0; i < intersections.Count; i += 2)
                {
                    if (i + 1 == intersections.Count)
                    {
                        break;
                    }
                    for (var x = intersections[i].X; x < intersections[i + 1].X; x++)
                    {
                        Bitmap.SetPixel(x, y, Color.LimeGreen);
                        PictureBox.Image = Bitmap;

                    }
                    if (IsAnimationMode)
                    {
                        await Task.Delay(10);
                    }
                }
            }
            DrawPolygon();
            ChangeEnables();
        }

        private void PolygonColoringAlgorithm_Resize(object sender, EventArgs e)
        {
            Bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            DrawPolygon();
        }

        private void PolygonColoringAlgorithm_Load(object sender, EventArgs e)
        {
            defaultWidth = PictureBox.Width;
            defaultHeight = PictureBox.Height;
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            DeleteVectors();
            var random = new Random();
            EdgeNumber = random.Next(3, 8);
            DrawPolygon();
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            DeleteVectors();
            DrawPolygon();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            XYAlgorithm();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            IsCanceled = true;
        }
    }
}
