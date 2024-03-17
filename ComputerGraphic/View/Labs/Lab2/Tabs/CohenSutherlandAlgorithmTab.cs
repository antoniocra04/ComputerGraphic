using ComputerGraphic.Model;

namespace ComputerGraphic.View.Labs.Lab2.Tabs
{
    public partial class CohenSutherlandAlgorithmTab : UserControl
    {
        private List<Vector> Vectors { get; set; } = new List<Vector>();

        private List<Vector> ScaledVectors { get; set; } = new List<Vector>();

        private int xn, yn, xk, yk;

        private int defaultWidth;
        private int defaultHeight;

        private Bitmap Bitmap { get; set; }
        private Stack<bool> ResizingStack { get; set; } = new Stack<bool>();

        private bool IsAnimationMode { get; set; } = false;

        private int DelayTime { get; set; } = 250;

        public CohenSutherlandAlgorithmTab()
        {
            InitializeComponent();
        }

        private async void DrawCutOffWindow()
        {
            var width = Bitmap.Width;
            var height = Bitmap.Height;
            var leftUpX = width / 3;
            var leftUpY = height / 3;
            var brushSize = 4;
            var steps = 50;
            var color = Color.Gray;
            FillArea(leftUpX, leftUpY, leftUpX * 2, leftUpY * 2, Color.LightGreen);

            for (var i = 1; i <= steps; i += 2)
            {
                if (i == steps / 2)
                {
                    i--;
                }
                CDA(leftUpX, height * i / steps, leftUpX, height * (i + 1) / steps, color, brushSize);
                CDA(leftUpX * 2, height * i / steps, leftUpX * 2, height * (i + 1) / steps, color, brushSize);
                CDA(width * i / steps, leftUpY, width * (i + 1) / steps, leftUpY, color, brushSize);
                CDA(width * i / steps, leftUpY * 2, width * (i + 1) / steps, leftUpY * 2, color, brushSize);
            }

            color = Color.Black;
            DrawFrame();
            DrawVectors();
        }

        private void DrawFrame()
        {
            var width = Bitmap.Width;
            var height = Bitmap.Height;
            var leftUpX = width / 3;
            var leftUpY = height / 3;
            var brushSize = 4;
            var color = Color.Black;
            CDA(leftUpX, leftUpY, leftUpX * 2, leftUpY, color, brushSize);
            CDA(leftUpX, leftUpY, leftUpX, leftUpY * 2, color, brushSize);
            CDA(leftUpX * 2, leftUpY * 2, leftUpX * 2, leftUpY, color, brushSize);
            CDA(leftUpX * 2, leftUpY * 2, leftUpX, leftUpY * 2, color, brushSize);
        }

        private void DrawVectors()
        {
            ScaledVectors = new List<Vector>();

            foreach (var vector in Vectors)
            {
                ScaledVectors.Add(
                    vector.GetScaled(
                        (double)PictureBox.Width / defaultWidth,
                        (double)PictureBox.Height / defaultHeight));
            }

            if (IsAnimationMode)
            {
                foreach (var vector in ScaledVectors)
                {
                    CDA(vector, Color.Black);
                }
            }
        }

        private void CDA(int xStart, int yStart, int xEnd, int yEnd, Color color, int brushSize = 3)
        {
            int index, numberNodes;
            double xOutput, yOutput, dx, dy;
            xn = xStart;
            yn = yStart;
            xk = xEnd;
            yk = yEnd;
            dx = xk - xn;
            dy = yk - yn;
            numberNodes = 200;
            xOutput = xn;
            yOutput = yn;
            SolidBrush brush = new SolidBrush(color);
            Graphics g = Graphics.FromImage(Bitmap);

            for (index = 1; index <= numberNodes; index++)
            {
                g.FillRectangle(brush, (int)xOutput, (int)yOutput, brushSize, brushSize);
                xOutput = xOutput + dx / numberNodes;
                yOutput = yOutput + dy / numberNodes;
            }
            PictureBox.Image = Bitmap;
        }

        private void CDA(Model.Point start, Model.Point end, Color color, int brushSize = 3)
        {
            CDA(
                start.X,
                start.Y,
                end.X,
                end.Y,
                color,
                brushSize);
        }

        private void CDA(Vector vector, Color color, int brushSize = 3)
        {
            CDA(
                vector.Start,
                vector.End,
                color,
                brushSize);
        }

        private void CSA(Vector vector)
        {
            var startPoint = GetCSACode(vector.Start);
            var endPoint = GetCSACode(vector.End);

            if (startPoint == 0b0000 && endPoint == 0b0000)
            {
                CDA(vector, Color.Blue);
            }
            else if ((startPoint & endPoint) != 0b0000)
            {
                CDA(vector, Color.IndianRed);
            }
            else
            {
                FindIntersection(vector);
                DrawFrame();
            }
        }

        private async void CSA()
        {
            foreach (var vector in ScaledVectors)
            {
                if (IsAnimationMode)
                {
                    await Task.Delay(DelayTime);
                    if (ResizingStack.Count > 0)
                    {
                        return;
                    }
                }

                CSA(vector);
            }
        }

        private byte GetCSACode(Model.Point point)
        {
            var width = Bitmap.Width;
            var height = Bitmap.Height;
            var top = height / 3 * 2;
            var left = width / 3;
            var right = width / 3 * 2;
            var bottom = height / 3;

            byte result = 0b0000;

            if (point.Y > top)
            {
                result |= 0b1000;
            }
            else if (point.Y >= bottom)
            {
                result |= 0b0000;
            }
            else
            {
                result |= 0b0100;
            }

            if (point.X > right)
            {
                result |= 0b0010;
            }
            else if (point.X >= left)
            {
                result |= 0b0000;
            }
            else
            {
                result |= 0b0001;
            }

            return result;
        }

        private void FindIntersection(Vector vector)
        {
            var width = Bitmap.Width;
            var height = Bitmap.Height;
            var top = height / 3 * 2;
            var left = width / 3;
            var right = width / 3 * 2;
            var bottom = height / 3;
            var start = vector.Start;
            var end = vector.End;
            var m = (double)(end.Y - start.Y) / (end.X - start.X);

            var bottomVector = new Vector(
                new Model.Point(
                    left,
                    bottom),
                new Model.Point(
                    right,
                    bottom));

            var topVector = new Vector(
                new Model.Point(
                    left,
                    top),
                new Model.Point(
                    right,
                    top));

            var leftVector = new Vector(
                new Model.Point(
                    left,
                    bottom),
                new Model.Point(
                    left,
                    top));

            var rightVector = new Vector(
                new Model.Point(
                    right,
                    bottom),
                new Model.Point(
                    right,
                    top));

            var leftIntersection = (int) (m * (left - start.X) + start.Y);
            var rightIntersection = (int)(m * (right - start.X) + start.Y);
            var topIntersection = (int) (start.X + (top - start.Y) / m);
            var bottomIntersection = (int) (start.X + (bottom - start.Y) / m);


            Vector visibleVector = vector.Clone();

            if (
                vector.Consider(left, leftIntersection) && 
                leftVector.Consider(left, leftIntersection) && 
                !(start.Equals(left, leftIntersection) || end.Equals(left, leftIntersection)))
            {
                if (end.X > start.X)
                {
                    CDA(start, new Model.Point(left, leftIntersection), Color.IndianRed);
                    var v = new Vector(new Model.Point(left, leftIntersection), end);
                    CSA(v);
                    return;
                }
                else
                {
                    CDA(new Model.Point(left, leftIntersection), end, Color.IndianRed);
                    var v = new Vector(start, new Model.Point(left, leftIntersection));
                    CSA(v);
                    return;
                }
            }

            if (
                vector.Consider(right, rightIntersection) && 
                rightVector.Consider(right, rightIntersection) &&
                !(start.Equals(right, rightIntersection) || end.Equals(right, rightIntersection)))
            {
                if (end.X > start.X)
                {
                    CDA(new Model.Point(right, rightIntersection), end, Color.IndianRed);
                    var v = new Vector(start, new Model.Point(right, rightIntersection));
                    CSA(v);
                    return;
                }
                else
                {
                    CDA(start, new Model.Point(right, rightIntersection), Color.IndianRed);
                    var v = new Vector(new Model.Point(right, rightIntersection), end);
                    CSA(v);
                    return;
                }
            }

            if (
                vector.Consider(topIntersection, top) && 
                topVector.Consider(topIntersection, top) &&
                !(start.Equals(topIntersection, top) || end.Equals(topIntersection, top)))
            {
                if (end.Y > start.Y)
                {
                    CDA(new Model.Point(topIntersection, top), end, Color.IndianRed);
                    var v = new Vector(start, new Model.Point(topIntersection, top));
                    CSA(v);
                    return;
                }
                else
                {
                    CDA(start, new Model.Point(topIntersection, top), Color.IndianRed);
                    var v = new Vector(new Model.Point(topIntersection, top), end);
                    CSA(v);
                    return;
                }
            }

            if (
                vector.Consider(bottomIntersection, bottom) && 
                bottomVector.Consider(bottomIntersection, bottom) &&
                !(start.Equals(bottomIntersection, bottom) || end.Equals(bottomIntersection, bottom)))
            {
                if (end.Y > start.Y)
                {
                    CDA(start, new Model.Point(bottomIntersection, bottom), Color.IndianRed);
                    var v = new Vector(new Model.Point(bottomIntersection, bottom), end);
                    CSA(v);
                    return;
                }
                else
                {
                    CDA(new Model.Point(bottomIntersection, bottom), end, Color.IndianRed);
                    var v = new Vector(start, new Model.Point(bottomIntersection, bottom));
                    CSA(v);
                    return;
                }
            }

            CDA(vector, Color.IndianRed);

            /*if (!visibleVector.Start.Equals(start))
            {
                var unvisibleVector = new Vector(start, visibleVector.Start);
                CDA(unvisibleVector, Color.IndianRed);
            }    

            if (!visibleVector.End.Equals(start))
            {
                var unvisibleVector = new Vector(visibleVector.End, end);
                CDA(unvisibleVector, Color.IndianRed);
            }
            
            CDA(visibleVector, Color.Blue);*/
            //MessageBox.Show(
            //    $"left: ({left}, {leftIntersection})\nright: ({right}, {rightIntersection})\ntop: ({topIntersection}, {top})\nbottom: ({bottomIntersection}, {bottom})");
        }

        private void FillArea(int xStart, int yStart, int xEnd, int yEnd, Color backgroundColor)
        {
            for (int x = xStart; x < xEnd; x++)
            {
                for (int y = yStart; y < yEnd; y++)
                {
                    Bitmap.SetPixel(x, y, backgroundColor);
                }
            }
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            xn = e.X; yn = e.Y;
        }

        private async void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            xk = e.X;
            yk = e.Y;
            var scaleX = PictureBox.Width / (double)defaultWidth;
            var scaleY = PictureBox.Height / (double)defaultHeight;

            Vectors.Add(new Vector(
                new Model.Point(
                    (int)(xn / scaleX),
                    (int)(yn / scaleY)), 
                new Model.Point(
                    (int)(xk / scaleX),
                    (int)(yk / scaleY))));

            DrawCutOffWindow();
            CSA();
        }

        private async void CohenSutherlandAlgorithmTab_Resize(object sender, EventArgs e)
        {
            Bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            DrawCutOffWindow();

            if (IsAnimationMode)
            {
                ResizingStack.Push(true);
                await Task.Delay(200);
                ResizingStack.Pop();
                if (ResizingStack.Count == 0)
                {
                    CSA();
                }
            }
            else
            {
                CSA();
            }
        }

        private void CohenSutherlandAlgorithmTab_Load(object sender, EventArgs e)
        {
            Bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            defaultWidth = PictureBox.Width;
            defaultHeight = PictureBox.Height;
            DrawCutOffWindow();
            //MessageBox.Show(GetSCACode(new Model.Point(PictureBox.Width / 3, PictureBox.Height / 3)).ToString());
        }
    }
}
