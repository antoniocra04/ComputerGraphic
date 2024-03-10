using System.Drawing;
using System.Windows.Forms;

namespace GeneralLabs.View.Labs
{
    public partial class Lab2 : Form
    {
        private int xn, yn, xk, yk;
        private Bitmap Bitmap { get; set; }
        public Color currentBorderColor { get; set; } = Color.Black;

        public Color FillColor { get; set; } = Color.Green;

        public int BrushSize { get; set; } = 2;

        public bool IsMousePressed { get; set; } = false;

        public bool IsInTimeMode
        {
            get
            {
                return InTimeRadioButton.Checked;
            }
        }

        public Lab2()
        {
            InitializeComponent();
            Bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            PictureBox.DrawToBitmap(Bitmap, PictureBox.ClientRectangle);
            BrushSizeComboBox.SelectedIndex = BrushSize - 1;
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            IsMousePressed = true;
            if (CDARadioButton.Checked)
            {
                xn = e.X; yn = e.Y;
            }

        }

        private void CDA(int xStart, int yStart, int xEnd, int yEnd)
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
            SolidBrush brush = new SolidBrush(currentBorderColor);
            Graphics g = Graphics.FromImage(Bitmap);

            for (index = 1; index <= numberNodes; index++)
            {
                g.FillRectangle(brush, (int)xOutput, (int)yOutput, BrushSize, BrushSize);
                xOutput = xOutput + dx / numberNodes;
                yOutput = yOutput + dy / numberNodes;
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            IsMousePressed = false;
            if (FillRadioButton.Checked)
            {
                FloodFill(e.X, e.Y);
                PictureBox.Image = Bitmap;
                return;
            }
            if (IsInTimeMode)
            {
                return;
            }
            xk = e.X;
            yk = e.Y;
            CDA(xn, yn, xk, yk);
            PictureBox.Image = Bitmap;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Задаем цвет пикселя по схеме RGB (от 0 до 255 для каждого цвета)
            Color newPixelColor = Color.FromArgb(240, 240, 240);
            for (int x = 0; x < Bitmap.Width; x++)
            {
                for (int y = 0; y < Bitmap.Height; y++)
                {
                    Bitmap.SetPixel(x, y, newPixelColor);
                }
            }
            PictureBox.Image = Bitmap;
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!IsInTimeMode || CDARadioButton.Checked == false || IsMousePressed == false)
            {
                return;
            }

            SolidBrush brush = new SolidBrush(currentBorderColor);
            //Pen myPen = new Pen(currentBorderColor, 1);
            //Graphics g = Graphics.FromHwnd(PictureBox.Handle);
            //g.DrawRectangle(myPen, e.X, e.Y, 2, 2);
            //g.FillRectangle(brush, e.X, e.Y, 2, 2);
            //Bitmap.SetPixel(e.X, e.Y, currentBorderColor);
            Graphics g = Graphics.FromImage(Bitmap);
            g.FillRectangle(brush, e.X, e.Y, BrushSize, BrushSize);
            PictureBox.Image = Bitmap;
        }

        private void PickColorButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = BorderColorDialog.ShowDialog();
            if (dialogResult == DialogResult.OK && CDARadioButton.Checked)
            {
                currentBorderColor = BorderColorDialog.Color;
            }
        }

        private void Lab2_Resize(object sender, EventArgs e)
        {
            Bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            PictureBox.DrawToBitmap(Bitmap, PictureBox.ClientRectangle);
        }

        private void FloodFill(int x1, int y1)
        {
            if (x1 >= Bitmap.Width || x1 < 0 || y1 >= Bitmap.Height || y1 < 0)
            {
                return;
            }
            // получаем цвет текущего пикселя с координатами x1, y1
            Color oldPixelColor = Bitmap.GetPixel(x1, y1);
            // сравнение цветов происходит в формате RGB 
            // для этого используем метод ToArgb объекта Color
            if ((oldPixelColor.ToArgb() != currentBorderColor.ToArgb()) && (oldPixelColor.ToArgb() != FillColor.ToArgb()))
            {
                //перекрашиваем пиксель
                Bitmap.SetPixel(x1, y1, FillColor);
                //вызываем метод для 4-х соседних пикселей
                FloodFill(x1 + 1, y1);
                FloodFill(x1 - 1, y1);
                FloodFill(x1, y1 + 1);
                FloodFill(x1, y1 - 1);
            }
            else
            {
                //выходим из метода
                return;
            }
        }

        private void BrushSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BrushSize = BrushSizeComboBox.SelectedIndex + 1;
        }

        private void FillColorButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = FillColorDialog.ShowDialog();
            if (dialogResult == DialogResult.OK && FillRadioButton.Checked)
            {
                FillColor = FillColorDialog.Color;
            }
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            //отключаем кнопки
            //button1.Enabled = false;             
            //button2.Enabled = false;  
            //создаем новый экземпляр Bitmap размером с элемент 
            //pictureBox1 (myBitmap)             
            //на нем выводим попиксельно отрезок
            Bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            using (Graphics g = Graphics.FromHwnd(PictureBox.Handle))
            {
                if (CDARadioButton.Checked == true)
                {
                    //рисуем прямоугольник
                    CDA(10, 10, 10, 110);
                    CDA(10, 10, 110, 10);
                    CDA(10, 110, 110, 110);
                    CDA(110, 10, 110, 110);
                    //рисуем треугольник
                    CDA(150, 10, 150, 200);
                    CDA(200, 50, 150, 200);
                    CDA(150, 10, 200, 150);
                }
                else
                {
                    if (FillRadioButton.Checked == true)
                    {
                        Bitmap = PictureBox.Image as Bitmap;
                        //получаем растр созданного рисунка в mybitmap
                        //Bitmap = PictureBox.Image as Bitmap;
                        // задаем координаты затравки
                        xn = 155;
                        yn = 40;
                        // вызываем рекурсивную процедуру заливки с затравкой
                        FloodFill(xn, yn);
                    }
                }
                //передаем полученный растр mybitmap в элемент pictureBox
                PictureBox.Image = Bitmap;
                // обновляем pictureBox и активируем кнопки
                PictureBox.Refresh();
                //button1.Enabled = true;                   
                //button2.Enabled = true;               
            }
        }
    }
}
