using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerGraphic.View.Labs.Lab4.Tabs
{
    public partial class Graphic : UserControl
    {
        public Graphic()
        {
            InitializeComponent();
            Thread.Sleep(100);
        }

        //куб
        private double[,] cube = new double[49, 4];
        //матрица преобразования
        private double[,] matrixPreobr = new double[4, 4];
        //оси
        private double[,] osi = new double[4, 4];

        //отвечают за перенос по x y z
        private double l, m, n;
        // отражение
        private double a = 1, b = 1, c = 1, a1 = 1, b1 = 1, c1 = 1;
        //изменение масштаба
        private double mas = 2;

        private double angleX = 0;
        private double angleY = 0;
        private double angleZ = 0;
        double FiX
        {
            get
            {
                return angleX / 180 * Math.PI;
            }
        }
        double FiY
        {
            get
            {
                return angleY / 180 * Math.PI;
            }
        }

        double FiZ
        {
            get
            {
                return angleZ / 180 * Math.PI;
            }
        }

        public void Clear()
        {
            pictureBox1.Image = null;
        }

      
        private void Init_cube()
        {
            int k = 0;
            for (int x = -3; x <= 3; x++)
            {
                for (int y = -3; y <= 3; y++)
                {
                    double z = Math.Pow((double)x, 2) - Math.Pow((double)y, 2) - 100;
                    cube[k, 0] = x; cube[k, 1] = y; cube[k, 2] = z; cube[k, 3] = 1;
                    k++;
                }
            }
        }

        private void Init_MatrPreobr(double l1, double m1, double n1)
        {
            matrixPreobr[0, 0] = a * a1; matrixPreobr[0, 1] = 0; matrixPreobr[0, 2] = 0; matrixPreobr[0, 3] = 0;
            matrixPreobr[1, 0] = 0; matrixPreobr[1, 1] = b * b1; matrixPreobr[1, 2] = 0; matrixPreobr[1, 3] = 0;
            matrixPreobr[2, 0] = 0; matrixPreobr[2, 1] = 0; matrixPreobr[2, 2] = c * c1; matrixPreobr[2, 3] = 0;
            matrixPreobr[3, 0] = l1; matrixPreobr[3, 1] = m1; matrixPreobr[3, 2] = n1; matrixPreobr[3, 3] = 1;
        }

        private void Init_MatrRotateOX()
        {
            matrixPreobr[0, 0] = 1; matrixPreobr[0, 1] = 0; matrixPreobr[0, 2] = 0; matrixPreobr[0, 3] = 0;
            matrixPreobr[1, 0] = 0; matrixPreobr[1, 1] = Math.Cos(FiX); matrixPreobr[1, 2] = Math.Sin(FiX); matrixPreobr[1, 3] = 0;
            matrixPreobr[2, 0] = 0; matrixPreobr[2, 1] = -Math.Sin(FiX); matrixPreobr[2, 2] = Math.Cos(FiX); matrixPreobr[2, 3] = 0;
            matrixPreobr[3, 0] = 0; matrixPreobr[3, 1] = 0; matrixPreobr[3, 2] = 0; matrixPreobr[3, 3] = 1;
        }

        private void Init_MatrRotateOY()
        {
            matrixPreobr[0, 0] = Math.Cos(FiY); matrixPreobr[0, 1] = 0; matrixPreobr[0, 2] = -Math.Sin(FiY); matrixPreobr[0, 3] = 0;
            matrixPreobr[1, 0] = 0; matrixPreobr[1, 1] = 1; matrixPreobr[1, 2] = 0; matrixPreobr[1, 3] = 0;
            matrixPreobr[2, 0] = Math.Sin(FiY); matrixPreobr[2, 1] = 0; matrixPreobr[2, 2] = Math.Cos(FiY); matrixPreobr[2, 3] = 0;
            matrixPreobr[3, 0] = 0; matrixPreobr[3, 1] = 0; matrixPreobr[3, 2] = 0; matrixPreobr[3, 3] = 1;
        }

        private void Init_MatrRotateOZ()
        {
            matrixPreobr[0, 0] = Math.Cos(FiZ); matrixPreobr[0, 1] = Math.Sin(FiZ); matrixPreobr[0, 2] = 0; matrixPreobr[0, 3] = 0;
            matrixPreobr[1, 0] = -Math.Sin(FiZ); matrixPreobr[1, 1] = Math.Cos(FiZ); matrixPreobr[1, 2] = 0; matrixPreobr[1, 3] = 0;
            matrixPreobr[2, 0] = 0; matrixPreobr[2, 1] = 0; matrixPreobr[2, 2] = 1; matrixPreobr[2, 3] = 0;
            matrixPreobr[3, 0] = 0; matrixPreobr[3, 1] = 0; matrixPreobr[3, 2] = 0; matrixPreobr[3, 3] = 1;
        }

        private void Init_Osi()
        {
            osi[0, 0] = -200; osi[0, 1] = 0; osi[0, 2] = 1;
            osi[1, 0] = 200; osi[1, 1] = 0; osi[1, 2] = 1;
            osi[2, 0] = 0; osi[2, 1] = 200; osi[2, 2] = 1;
            osi[3, 0] = 0; osi[3, 1] = -200; osi[3, 2] = 1;
        }

        //умножение матриц
        private double[,] Multiply_matr(double[,] a, double[,] b)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);

            double[,] r = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    r[i, j] = 0;
                    for (int ii = 0; ii < m; ii++)
                    {
                        r[i, j] += a[i, ii] * b[ii, j];
                    }
                }
            }
            return r;
        }

        //вывод куба на экран
        private void Draw_Cube()
        {

            /*Init_cube(); //инициализация матрицы тела
            Init_MatrRotateOX();
            double[,] cube1 = Multiply_matr(cube, matrixPreobr);
            Init_MatrRotateOY();
            double[,] cube2 = Multiply_matr(cube1, matrixPreobr);
            Init_MatrRotateOZ();
            double[,] cube3 = Multiply_matr(cube2, matrixPreobr);
            Init_MatrPreobr(l, m, n); //инициализация матрицы преобразования
            double[,] cube4 = Multiply_matr(cube3, matrixPreobr); //перемножение матриц

            Pen myPen = new Pen(Color.Blue, 2);// цвет линии и ширина

            //создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);

            g.DrawLine(myPen, (int)cube4[0, 0], (int)cube4[0, 1], (int)cube4[1, 0], (int)cube4[1, 1]);
            g.DrawLine(myPen, (int)cube4[1, 0], (int)cube4[1, 1], (int)cube4[2, 0], (int)cube4[2, 1]);
            g.DrawLine(myPen, (int)cube4[2, 0], (int)cube4[2, 1], (int)cube4[3, 0], (int)cube4[3, 1]);
            g.DrawLine(myPen, (int)cube4[3, 0], (int)cube4[3, 1], (int)cube4[0, 0], (int)cube4[0, 1]);
            g.DrawLine(myPen, (int)cube4[0, 0], (int)cube4[0, 1], (int)cube4[4, 0], (int)cube4[4, 1]);
            g.DrawLine(myPen, (int)cube4[4, 0], (int)cube4[4, 1], (int)cube4[5, 0], (int)cube4[5, 1]);
            g.DrawLine(myPen, (int)cube4[5, 0], (int)cube4[5, 1], (int)cube4[1, 0], (int)cube4[1, 1]);
            g.DrawLine(myPen, (int)cube4[5, 0], (int)cube4[5, 1], (int)cube4[6, 0], (int)cube4[6, 1]);
            g.DrawLine(myPen, (int)cube4[6, 0], (int)cube4[6, 1], (int)cube4[2, 0], (int)cube4[2, 1]);
            g.DrawLine(myPen, (int)cube4[6, 0], (int)cube4[6, 1], (int)cube4[7, 0], (int)cube4[7, 1]);
            g.DrawLine(myPen, (int)cube4[7, 0], (int)cube4[7, 1], (int)cube4[4, 0], (int)cube4[4, 1]);
            g.DrawLine(myPen, (int)cube4[7, 0], (int)cube4[7, 1], (int)cube4[3, 0], (int)cube4[3, 1]);   


            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            myPen.Dispose(); //освобождвем ресурсы, связанные с Pen*/
            Init_cube(); //инициализация матрицы тела
            Init_MatrRotateOX();
            double[,] shape1 = Multiply_matr(cube, matrixPreobr);
            Init_MatrRotateOY();
            double[,] shape2 = Multiply_matr(shape1, matrixPreobr);
            Init_MatrRotateOZ();
            double[,] shape3 = Multiply_matr(shape2, matrixPreobr);
            Init_MatrPreobr(l, m, n); //инициализация матрицы преобразования
            double[,] shape4 = Multiply_matr(shape3, matrixPreobr); //перемножение матриц

            Pen myPen = new Pen(Color.Blue, 2); // цвет линии и ширина

            //создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);

            // Draw the points and connect them based on your desired logic
            for (int i = 0; i < 49; i++)
            {
                for (int j = i + 1; j < 49; j++)
                {
                    // Example: Drawing lines between points (i, j) where j = i + 1 or neighboring points
                    // You may want to add a more specific condition for connecting the points
                    if (j == i + 1 || (i % 7 != 6 && j == i + 7))
                    {
                        g.DrawLine(myPen, (int)shape4[i, 0], (int)shape4[i, 1], (int)shape4[j, 0], (int)shape4[j, 1]);
                    }
                }
            }

            g.Dispose(); // освобождаем все ресурсы, связанные с отрисовкой
            myPen.Dispose(); //освобождвем ресурсы, связанные с Pen

        }

        //вывод квадратика в центре pictureBox
        private void button2_Click(object sender, EventArgs e)
        {
            //середина pictureBox
            l = pictureBox1.Width / 2;
            m = pictureBox1.Height / 2;
            n = 1;
            //вывод куба в середине
            Draw_Cube();
        }

        //вывод осей
        private void Draw_Osi()
        {
            Pen myPen = new Pen(Color.DimGray, 1);// цвет линии и ширина

            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            g.DrawLine(myPen, 300, (int)pictureBox1.Height, 300, 0);
            g.DrawLine(myPen, 0, 200, (int)pictureBox1.Width, 200);

        }

        /*//вывод осей на экран
        private void Draw_osi()
        {
            Init_Osi();
            Init_MatrPreobr(pictureBox1.Width / 2, pictureBox1.Height / 2, 0);
            double[,] osi1 = Multiply_matr(osi, matrixPreobr);
            Pen myPen = new Pen(Color.Red, 1);// цвет линии и ширина
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            // рисуем ось ОХ
            g.DrawLine(myPen, (int)osi1[0, 0], (int)osi1[0, 1], (int)osi1[1, 0], (int)osi1[1,
            1]);
            // рисуем ось ОУ
            g.DrawLine(myPen, (int)osi1[2, 0], (int)osi1[2, 1], (int)osi1[3, 0], (int)osi1[3,
            1]);
            g.Dispose();
            myPen.Dispose();
        }*/

        //вывод осей в центре pictureBox
        private void button1_Click(object sender, EventArgs e)
        {
            l = pictureBox1.Width / 2;
            m = pictureBox1.Height / 2;
            Draw_Osi();
        }

        //сдвиг вправо
        private void button4_Click(object sender, EventArgs e)
        {
            l += 5; //изменение соответствующего элемента матрицы сдвига
            Clear();
            pictureBox1.Refresh();
            Draw_Osi();
            Draw_Cube(); //вывод квадратика
        }

        //сдвиг влево
        private void button5_Click(object sender, EventArgs e)
        {
            l -= 5; //изменение соответствующего элемента матрицы сдвига
            Clear();
            pictureBox1.Refresh();
            Draw_Osi();
            Draw_Cube(); //вывод квадратика
        }

        //сдвиг вверх
        private void button6_Click(object sender, EventArgs e)
        {
            m -= 5;
            Clear();
            pictureBox1.Refresh();
            Draw_Osi();
            Draw_Cube();
        }

        //сдвиг вниз
        private void button7_Click(object sender, EventArgs e)
        {
            m += 5;
            Clear();
            pictureBox1.Refresh();
            Draw_Osi();
            Draw_Cube();
        }

        //очистка
        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
            Draw_Osi();
        }

        //поворот по X
        private void button8_Click(object sender, EventArgs e)
        {
            angleX += 1;
            Clear();
            pictureBox1.Refresh();
            Draw_Osi();
            Draw_Cube();
        }

        //поворот по X
        private void button9_Click(object sender, EventArgs e)
        {
            angleX += -1;
            Clear();
            pictureBox1.Refresh();
            Draw_Osi();
            Draw_Cube();
        }

        //поворот по Y
        private void button10_Click(object sender, EventArgs e)
        {
            angleY += 1;
            Clear();
            pictureBox1.Refresh();
            Draw_Osi();
            Draw_Cube();
        }

        //поворот по Y
        private void button11_Click(object sender, EventArgs e)
        {
            angleY += -1;
            Clear();
            pictureBox1.Refresh();
            Draw_Osi();
            Draw_Cube();
        }

        //поворот по Z
        private void button12_Click(object sender, EventArgs e)
        {
            angleZ += 1;
            Clear();
            pictureBox1.Refresh();
            Draw_Osi();
            Draw_Cube();
        }

        private void button22_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Start();
        }

        private void button22_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            angleZ++;
            Clear();
            pictureBox1.Refresh();
            Draw_Osi();
            Draw_Cube();
            Thread.Sleep(100);
        }


        //поворот по Z
        private void button13_Click(object sender, EventArgs e)
        {
            angleZ += -1;
            Clear();
            pictureBox1.Refresh();
            Draw_Osi();
            Draw_Cube();
        }

        //отображение XOY
        private void button14_Click(object sender, EventArgs e)
        {
            c1 *= -1;
            Clear();
            pictureBox1.Refresh();
            Draw_Osi();
            Draw_Cube();
        }

        //отображение XOZ
        private void button15_Click(object sender, EventArgs e)
        {
            b1 *= -1;
            Clear();
            pictureBox1.Refresh();
            Draw_Osi();
            Draw_Cube();
        }

        //сдвиг вперёд
        private void button16_Click(object sender, EventArgs e)
        {
            n += 5;
            Clear();
            pictureBox1.Refresh();
            Draw_Osi();
            Draw_Cube();
        }

        //сдвиг назад
        private void button17_Click(object sender, EventArgs e)
        {
            n -= 5;
            Clear();
            pictureBox1.Refresh();
            Draw_Osi();
            Draw_Cube();
        }

        //изменение масштаба по x+
        private void button18_Click(object sender, EventArgs e)
        {
            a += mas;
            Clear();
            pictureBox1.Refresh();
            Draw_Osi();
            Draw_Cube();
        }

        //изменение масштаба по x-
        private void button19_Click(object sender, EventArgs e)
        {
            a -= mas;
            Clear();
            pictureBox1.Refresh();
            Draw_Osi();
            Draw_Cube();
        }

        //изменение масштаба по y+
        private void button20_Click(object sender, EventArgs e)
        {
            b += mas;
            Clear();
            pictureBox1.Refresh();
            Draw_Osi();
            Draw_Cube();
        }

        //изменение масштаба по y-
        private void button21_Click(object sender, EventArgs e)
        {
            b -= mas;
            Clear();
            pictureBox1.Refresh();
            Draw_Osi();
            Draw_Cube();
        }

        //изменение масштаба по z+
        private void button22_Click(object sender, EventArgs e)
        {
            c += mas;
            Clear();
            pictureBox1.Refresh();
            Draw_Osi();
            Draw_Cube();
        }

        //изменение масштаба по z-
        private void button23_Click(object sender, EventArgs e)
        {
            c -= mas;
            Clear();
            pictureBox1.Refresh();
            Draw_Osi();
            Draw_Cube();
        }

        //отображение YOZ
        private void button24_Click(object sender, EventArgs e)
        {
            a1 *= -1;
            Clear();
            pictureBox1.Refresh();
            Draw_Osi();
            Draw_Cube();
        }
    }
}
