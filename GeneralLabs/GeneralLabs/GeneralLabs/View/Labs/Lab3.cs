using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralLabs.View.Labs
{
    public partial class Lab3 : Form
    {
        private int[,] kv = new int[4, 3];
        private double[,] matr_sdv = new double[3, 3];
        private int[,] osi = new int[4, 3];
        Bitmap Bitmap { get; set; }
        int PBWidth, PBHeight;
        int k, l;
        int f = 0;
        int kdelta = 0;
        int ldelta = 0;
        int fdelta = 0;
        double xscale = 1;
        double yscale = 1;
        double xscaleDiff = 0;
        double yscaleDiff = 0;
        double xscaleDelta = 0.1;
        double yscaleDelta = 0.1;

        double xdisplay = 1;
        double ydisplay = 1;

        double Fi
        {
            get
            {
                return f / 180.0 * Math.PI;
            }
        }

        public Lab3()
        {
            InitializeComponent();
            timer1.Interval = 50;
        }

        private void Init_kvadrat()
        {
            // Общее задание
            //kv[0, 0] = -50; kv[0, 1] = 0; kv[0, 2] = 1;
            //kv[1, 0] = 0; kv[1, 1] = 50; kv[1, 2] = 1;
            //kv[2, 0] = 50; kv[2, 1] = 0; kv[2, 2] = 1;
            //kv[3, 0] = 0; kv[3, 1] = -50; kv[3, 2] = 1;

            // 17 вариант
            kv[0, 0] = -25; kv[0, 1] = -25; kv[0, 2] = 1;
            kv[1, 0] = 50; kv[1, 1] = -25; kv[1, 2] = 1;
            kv[2, 0] = 0; kv[2, 1] = 0; kv[2, 2] = 1;
            kv[3, 0] = -25; kv[3, 1] = 50; kv[3, 2] = 1;
        }

        private void Init_matr_preob(int k1, int l1)
        {
            matr_sdv[0, 0] = 1; matr_sdv[0, 1] = 0; matr_sdv[0, 2] = 0;
            matr_sdv[1, 0] = 0; matr_sdv[1, 1] = 1; matr_sdv[1, 2] = 0;
            matr_sdv[2, 0] = k1; matr_sdv[2, 1] = l1; matr_sdv[2, 2] = 1;
        }

        private void Init_matr_preob_scale(int k1, int l1)
        {
            matr_sdv[0, 0] = xscale * xdisplay; matr_sdv[0, 1] = 0; matr_sdv[0, 2] = 0;
            matr_sdv[1, 0] = 0; matr_sdv[1, 1] = yscale * ydisplay; matr_sdv[1, 2] = 0;
            matr_sdv[2, 0] = k1; matr_sdv[2, 1] = l1; matr_sdv[2, 2] = 1;
        }

        private void Init_matr_preob_rotate(int k1, int l1)
        {
            matr_sdv[0, 0] = Math.Cos(Fi); matr_sdv[0, 1] = Math.Sin(Fi); matr_sdv[0, 2] = 0;
            matr_sdv[1, 0] = -Math.Sin(Fi); matr_sdv[1, 1] = Math.Cos(Fi); matr_sdv[1, 2] = 0;
            matr_sdv[2, 0] = 0; matr_sdv[2, 1] = 0; matr_sdv[2, 2] = 1;
            // matr_sdv[2, 0] = (int)(-k1 * (Math.Cos(Fi) - 1)+ l1 * Math.Sin(Fi))
            // matr_sdv[2, 1] = (int)(-k1 * Math.Sin(Fi) - l1 * (Math.Cos(Fi) - 1))
        }

        private void Init_osi()
        {
            osi[0, 0] = -PBWidth / 2; osi[0, 1] = 0; osi[0, 2] = 1;
            osi[1, 0] = PBWidth / 2; osi[1, 1] = 0; osi[1, 2] = 1;
            osi[2, 0] = 0; osi[2, 1] = PBHeight / 2; osi[2, 2] = 1;
            osi[3, 0] = 0; osi[3, 1] = -PBHeight / 2; osi[3, 2] = 1;
        }

        private int[,] Multiply_matr(int[,] a, double[,] b)
        {
            int n = a.GetLength(0);
            int m = b.GetLength(1);
            int[,] r = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    r[i, j] = 0;

                    for (int ii = 0; ii < m; ii++)
                    {
                        r[i, j] += (int)(a[i, ii] * b[ii, j]);
                    }
                }
            }

            return r;
        }

        private void Draw_Kv()
        {
            Init_kvadrat();
            Init_matr_preob_rotate(k, l);
            int[,] kv1 = Multiply_matr(kv, matr_sdv);
            Init_matr_preob_scale(k, l);
            int[,] kv2 = Multiply_matr(kv1, matr_sdv);
            Pen myPen = new Pen(Color.Blue, 2);
            Graphics g = Graphics.FromImage(Bitmap);
            g.DrawLine(myPen, kv2[0, 0], kv2[0, 1], kv2[1, 0], kv2[1, 1]);
            g.DrawLine(myPen, kv2[1, 0], kv2[1, 1], kv2[2, 0], kv2[2, 1]);
            g.DrawLine(myPen, kv2[2, 0], kv2[2, 1], kv2[3, 0], kv2[3, 1]);
            g.DrawLine(myPen, kv2[3, 0], kv2[3, 1], kv2[0, 0], kv2[0, 1]);
            g.Dispose();
            myPen.Dispose();
            PictureBox.Image = Bitmap;
        }

        private void Draw_osi()
        {
            Init_osi();
            Init_matr_preob(PBWidth / 2, PBHeight / 2);
            int[,] osi1 = Multiply_matr(osi, matr_sdv);
            Pen myPen = new Pen(Color.Red, 1);
            Graphics g = Graphics.FromImage(Bitmap);
            g.DrawLine(myPen, osi1[0, 0], osi1[0, 1], osi1[1, 0], osi1[1, 1]);
            g.DrawLine(myPen, osi1[2, 0], osi1[2, 1], osi1[3, 0], osi1[3, 1]);
            g.Dispose();
            myPen.Dispose();
            PictureBox.Image = Bitmap;
        }

        private void ClearPictureBox()
        {
            Bitmap = new Bitmap(PBWidth, PBHeight);
            PictureBox.Image = Bitmap;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            k = PictureBox.Width / 2;
            l = PictureBox.Height / 2;
            Draw_Kv();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            k = PictureBox.Width / 2;
            l = PictureBox.Height / 2;
            Draw_osi();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            k += kdelta;
            l += ldelta;
            f += fdelta;
            ClearPictureBox();
            Draw_osi();
            Draw_Kv();
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            kdelta += 1;
            timer1.Start();
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            kdelta -= 1;
            timer1.Stop();
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            kdelta -= 1;
            timer1.Start();
        }

        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            kdelta += 1;
            timer1.Stop();
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            ldelta += 1;
            timer1.Start();
        }

        private void button6_MouseUp(object sender, MouseEventArgs e)
        {
            ldelta -= 1;
            timer1.Stop();
        }

        private void button7_MouseDown(object sender, MouseEventArgs e)
        {
            ldelta -= 1;
            timer1.Start();
        }

        private void button7_MouseUp(object sender, MouseEventArgs e)
        {
            ldelta += 1;
            timer1.Stop();
        }

        private void Lab3_Resize(object sender, EventArgs e)
        {
            PBWidth = PictureBox.Width;
            PBHeight = PictureBox.Height;
            ClearPictureBox();
            Draw_osi();
        }

        private void Lab3_Load(object sender, EventArgs e)
        {
            PBWidth = PictureBox.Width;
            PBHeight = PictureBox.Height;
            Bitmap = new Bitmap(PBWidth, PBHeight);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearPictureBox();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            l += -1;
            ClearPictureBox();
            Draw_osi();
            Draw_Kv();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            k += 1;
            ClearPictureBox();
            Draw_osi();
            Draw_Kv();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            l += 1;
            ClearPictureBox();
            Draw_osi();
            Draw_Kv();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            k += -1;
            ClearPictureBox();
            Draw_osi();
            Draw_Kv();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            f += 1;
            ClearPictureBox();
            Draw_osi();
            Draw_Kv();
        }

        private void button8_MouseDown(object sender, MouseEventArgs e)
        {
            fdelta += 1;
            timer1.Start();
        }

        private void button8_MouseUp(object sender, MouseEventArgs e)
        {
            fdelta += -1;
            timer1.Stop();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            f += -1;
            ClearPictureBox();
            Draw_osi();
            Draw_Kv();
        }

        private void button9_MouseDown(object sender, MouseEventArgs e)
        {
            fdelta += -1;
            timer1.Start();
        }

        private void button9_MouseUp(object sender, MouseEventArgs e)
        {
            fdelta += 1;
            timer1.Stop();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // OX
            xdisplay *= -1;
            ClearPictureBox();
            Draw_osi();
            Draw_Kv();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // OY
            ydisplay *= -1;
            ClearPictureBox();
            Draw_osi();
            Draw_Kv();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // X
            xscale += xscaleDelta;
            ClearPictureBox();
            Draw_osi();
            Draw_Kv();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Y
            yscale += yscaleDelta;
            ClearPictureBox();
            Draw_osi();
            Draw_Kv();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // x
            if (xscale - xscaleDelta > 0)
            {
                xscale -= xscaleDelta;
                ClearPictureBox();
                Draw_osi();
                Draw_Kv();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // y
            if (yscale - yscaleDelta > 0)
            {
                yscale -= yscaleDelta;
                ClearPictureBox();
                Draw_osi();
                Draw_Kv();
            }
        }
    }
}
