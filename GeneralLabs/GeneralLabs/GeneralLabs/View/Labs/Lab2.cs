using System.Windows.Forms;

namespace GeneralLabs.View.Labs
{
    public partial class Lab2 : Form
    {
        public int xn, yn, xk, yk;

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
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            IsMousePressed = true;
            if (CDARadioButton.Checked == true)
            {
                xn = e.X; yn = e.Y;
            }
            else
                MessageBox.Show("Вы не выбрали алгоритм вывода фигуры!");
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            IsMousePressed = false;
            if (IsInTimeMode)
            {
                return;
            }
            //numberNodes – переменная, задающая количество узлов для 
            //аппроксимации отрезка 
            //xOutput – x-координата очередного узла 
            //yOutput – y-координата очередного узла
            int index, numberNodes;
            double xOutput, yOutput, dx, dy;
            //Объявляем объект "myPen", задающий цвет и толщину пера
            Pen myPen = new Pen(Color.Black, 1);
            //Объявляем объект "g" класса Graphics и предоставляем   
            //ему возможность рисования на pictureBox1:
            Graphics g = Graphics.FromHwnd(PictureBox.Handle);
            //реализация обычного алгоритма ЦДА
            xk = e.X;
            yk = e.Y;
            dx = xk - xn;
            dy = yk - yn;
            numberNodes = 200;
            xOutput = xn;
            yOutput = yn;
            for (index = 1; index <= numberNodes; index++)
            {
                // Рисуем прямоугольник
                g.DrawRectangle(myPen, (int)xOutput, (int)yOutput, 2, 2);

                // Рисуем закрашенный прямоугольник: 
                // Объявляем объект "redBrush", задающий цвет кисти 
                // SolidBrush redBrush = new SolidBrush(Color.Red);  
                // Рисуем закрашенный прямоугольник 
                // g.FillRectangle(redBrush, (int)xOutput, (int)yOutput, 2, 2);

                xOutput = xOutput + dx / numberNodes;
                yOutput = yOutput + dy / numberNodes;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Bitmap myBitmap = new Bitmap(PictureBox.Height, PictureBox.Width);
            //Задаем цвет пикселя по схеме RGB (от 0 до 255 для каждого цвета)
            Color newPixelColor = Color.FromArgb(247, 249, 239);
            for (int x = 0; x < myBitmap.Width; x++)
            {
                for (int y = 0; y < myBitmap.Height; y++)
                {
                    myBitmap.SetPixel(x, y, newPixelColor);
                }
            }
            PictureBox.Image = myBitmap;
            //  pictureBox1.Image = null; 
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!IsInTimeMode || CDARadioButton.Checked == false || IsMousePressed == false)
            {
                return;
            }

            Pen myPen = new Pen(Color.Black, 1);
            Graphics g = Graphics.FromHwnd(PictureBox.Handle);

            g.DrawRectangle(myPen, e.X, e.Y, 2, 2);
        }
    }
}
