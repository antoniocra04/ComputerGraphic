using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerGraphic.View.Labs.Lab3.Tabs
{
    public partial class _13 : UserControl
    {
        double[,] relsa = new double[4, 3];
        double[,] shpala = new double[4, 3];
        double[,] shpala1 = new double[4, 3];
        double[,] train = new double[4, 3];
        double[,] vagon = new double[4, 3];
        double[,] connect = new double[4, 3];
        double[,] shatun = new double[2, 3];
        double[,] matr_sdv = new double[3, 3]; // матрица преобразования

        double[,] crtree = new double[3, 3];
        double[,] crtree1 = new double[3, 3];
        double[,] leg = new double[4, 3];
        double[,] leg1 = new double[4, 3];
        double[,] cleg = new double[4, 3];
        double[,] cleg1 = new double[4, 3];
        double[,] little_leg = new double[4, 3];

        double shpalaX;
        double treeX;
        double shatunY;
        double shatunS = 1;

        double k, l, a, b, c, d; // элементы матрицы преобразования
        double center1, center2;
        double p1, p2, p3;
        //Обнуление матрицы преобразования
        private void Clear_matr_preob()
        {
            k = l = b = c = 0;
            a = d = 1;

        }

        private void ClearImage()
        {
            if (myBitmap != null)
            {
                myBitmap.Dispose();
            }
            myBitmap = new Bitmap(Width, Height);
            PictureBox.Image = myBitmap;
        }


        Bitmap myBitmap;

        void Init_crtree()
        {
            crtree[0, 0] = 0; crtree[0, 1] = 0; crtree[0, 2] = 1;
            crtree[1, 0] = -15; crtree[1, 1] = 20; crtree[1, 2] = 1;
            crtree[2, 0] = 15; crtree[2, 1] = 20; crtree[2, 2] = 1;
        }

        void Init_leg()
        {
            leg[0, 0] = -2; leg[0, 1] = 20; leg[0, 2] = 1;
            leg[1, 0] = -2; leg[1, 1] = 40; leg[1, 2] = 1;
            leg[2, 0] = 2; leg[2, 1] = 40; leg[2, 2] = 1;
            leg[3, 0] = 2; leg[3, 1] = 20; leg[3, 2] = 1;
        }

        void Init_cleg()
        {
            cleg[0, 0] = -2; cleg[0, 1] = 20; cleg[0, 2] = 1;
            cleg[1, 0] = -2; cleg[1, 1] = 40; cleg[1, 2] = 1;
            cleg[2, 0] = 2; cleg[2, 1] = 40; cleg[2, 2] = 1;
            cleg[3, 0] = 2; cleg[3, 1] = 20; cleg[3, 2] = 1;
        }

        void Init_little_leg()
        {
            little_leg[0, 0] = -1; little_leg[0, 1] = 10; little_leg[0, 2] = 1;
            little_leg[1, 0] = -1; little_leg[1, 1] = 15; little_leg[1, 2] = 1;
            little_leg[2, 0] = 1; little_leg[2, 1] = 15; little_leg[2, 2] = 1;
            little_leg[3, 0] = 1; little_leg[3, 1] = 10; little_leg[3, 2] = 1;
        }

        void Init_relsa()
        {
            relsa[0, 0] = -300; relsa[0, 1] = -7; relsa[0, 2] = 1;
            relsa[1, 0] = -300; relsa[1, 1] = 0; relsa[1, 2] = 1;
            relsa[2, 0] = +200; relsa[2, 1] = 0; relsa[2, 2] = 1;
            relsa[3, 0] = +200; relsa[3, 1] = -7; relsa[3, 2] = 1;
        }

        void Init_shatun()
        {
            shatun[0, 0] = -20; shatun[0, 1] = 0; shatun[0, 2] = 1;
            shatun[1, 0] = +90; shatun[1, 1] = 0; shatun[1, 2] = 1;
        }

        void Init_train()
        {
            train[0, 0] = -50; train[0, 1] = -105; train[0, 2] = 1;
            train[1, 0] = -50; train[1, 1] = -30; train[1, 2] = 1;
            train[2, 0] = +125; train[2, 1] = -30; train[2, 2] = 1;
            train[3, 0] = +125; train[3, 1] = -105; train[3, 2] = 1;
        }

        void Init_connect()
        {
            connect[0, 0] = -69; connect[0, 1] = -40; connect[0, 2] = 1;
            connect[1, 0] = -69; connect[1, 1] = -35; connect[1, 2] = 1;
            connect[2, 0] = -51; connect[2, 1] = -35; connect[2, 2] = 1;
            connect[3, 0] = -51; connect[3, 1] = -40; connect[3, 2] = 1;
        }
        void Init_vagon()
        {
            vagon[0, 0] = -250; vagon[0, 1] = -105; vagon[0, 2] = 1;
            vagon[1, 0] = -250; vagon[1, 1] = -30; vagon[1, 2] = 1;
            vagon[2, 0] = -70; vagon[2, 1] = -30; vagon[2, 2] = 1;
            vagon[3, 0] = -70; vagon[3, 1] = -105; vagon[3, 2] = 1;
        }

        void Init_shpala()
        {
            shpala[0, 0] = -15; shpala[0, 1] = 0; shpala[0, 2] = 1;
            shpala[1, 0] = -15; shpala[1, 1] = +7; shpala[1, 2] = 1;
            shpala[2, 0] = +15; shpala[2, 1] = +7; shpala[2, 2] = 1;
            shpala[3, 0] = +15; shpala[3, 1] = 0; shpala[3, 2] = 1;
        }

        private void Init_matr_preob(double k1, double l1, double a1, double b1, double c1, double d1)
        {
            matr_sdv[0, 0] = a1; matr_sdv[0, 1] = b1; matr_sdv[0, 2] = 0;
            matr_sdv[1, 0] = c1; matr_sdv[1, 1] = d1; matr_sdv[1, 2] = 0;
            matr_sdv[2, 0] = k1; matr_sdv[2, 1] = l1; matr_sdv[2, 2] = 1;
        }

        public _13()
        {
            InitializeComponent();
            myBitmap = new Bitmap(PictureBox.Width + 200, PictureBox.Height);
            Generate();
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

        private void Draw_relsa()
        {


            Init_matr_preob(k, l, a, b, c, d); //инициализация матрицы преобразования

            relsa = Multiply_matr(relsa, matr_sdv); //перемножение матриц

            Pen myPen = new Pen(Color.Gray, 2);// цвет линии и ширина

            //создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromImage(myBitmap);

            // рисуем 1 сторону квадрата
            g.DrawLine(myPen, (int)relsa[0, 0], (int)relsa[0, 1], (int)relsa[1, 0], (int)relsa[1, 1]);
            // рисуем 2 сторону квадрата
            g.DrawLine(myPen, (int)relsa[1, 0], (int)relsa[1, 1], (int)relsa[2, 0], (int)relsa[2, 1]);
            // рисуем 3 сторону квадрата
            g.DrawLine(myPen, (int)relsa[2, 0], (int)relsa[2, 1], (int)relsa[3, 0], (int)relsa[3, 1]);
            // рисуем 4 сторону квадрата
            g.DrawLine(myPen, (int)relsa[3, 0], (int)relsa[3, 1], (int)relsa[0, 0], (int)relsa[0, 1]);

            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            myPen.Dispose(); //освобождвем ресурсы, связанные с Pen
            PictureBox.Image = myBitmap;
        }

        private void Draw_train()
        {
            Init_matr_preob(k, l, a, b, c, d); //инициализация матрицы преобразования

            train = Multiply_matr(train, matr_sdv); //перемножение матриц

            Pen myPen = new Pen(Color.Red, 2);// цвет линии и ширина

            //создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromImage(myBitmap);

            // рисуем 1 сторону квадрата
            g.DrawLine(myPen, (int)train[0, 0], (int)train[0, 1], (int)train[1, 0], (int)train[1, 1]);
            // рисуем 2 сторону квадрата
            g.DrawLine(myPen, (int)train[1, 0], (int)train[1, 1], (int)train[2, 0], (int)train[2, 1]);
            // рисуем 3 сторону квадрата
            g.DrawLine(myPen, (int)train[2, 0], (int)train[2, 1], (int)train[3, 0], (int)train[3, 1]);
            // рисуем 4 сторону квадрата
            g.DrawLine(myPen, (int)train[3, 0], (int)train[3, 1], (int)train[0, 0], (int)train[0, 1]);

            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            myPen.Dispose(); //освобождвем ресурсы, связанные с Pen
            PictureBox.Image = myBitmap;
        }

        private void Draw_vagon()
        {
            Init_matr_preob(k, l, a, b, c, d); //инициализация матрицы преобразования

            vagon = Multiply_matr(vagon, matr_sdv); //перемножение матриц

            Pen myPen = new Pen(Color.Crimson, 2);// цвет линии и ширина

            //создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromImage(myBitmap);

            // рисуем 1 сторону квадрата
            g.DrawLine(myPen, (int)vagon[0, 0], (int)vagon[0, 1], (int)vagon[1, 0], (int)vagon[1, 1]);
            // рисуем 2 сторону vagon
            g.DrawLine(myPen, (int)vagon[1, 0], (int)vagon[1, 1], (int)vagon[2, 0], (int)vagon[2, 1]);
            // рисуем 3 сторону квадрата
            g.DrawLine(myPen, (int)vagon[2, 0], (int)vagon[2, 1], (int)vagon[3, 0], (int)vagon[3, 1]);
            // рисуем 4 сторону квадрата
            g.DrawLine(myPen, (int)vagon[3, 0], (int)vagon[3, 1], (int)vagon[0, 0], (int)vagon[0, 1]);

            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            myPen.Dispose(); //освобождвем ресурсы, связанные с Pen
            PictureBox.Image = myBitmap;
        }

        private void Draw_connect()
        {
            Init_matr_preob(k, l, a, b, c, d); //инициализация connect преобразования

            connect = Multiply_matr(connect, matr_sdv); //перемножение матриц

            Pen myPen = new Pen(Color.Silver, 2);// цвет линии и ширина

            //создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromImage(myBitmap);

            // рисуем 1 сторону квадрата
            g.DrawLine(myPen, (int)connect[0, 0], (int)connect[0, 1], (int)connect[1, 0], (int)connect[1, 1]);
            // рисуем 2 сторону vagon
            g.DrawLine(myPen, (int)connect[1, 0], (int)connect[1, 1], (int)connect[2, 0], (int)connect[2, 1]);
            // рисуем 3 сторону квадрата
            g.DrawLine(myPen, (int)connect[2, 0], (int)connect[2, 1], (int)connect[3, 0], (int)connect[3, 1]);
            // рисуем 4 сторону квадрата
            g.DrawLine(myPen, (int)connect[3, 0], (int)connect[3, 1], (int)connect[0, 0], (int)connect[0, 1]);

            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            myPen.Dispose(); //освобождвем ресурсы, связанные с Pen
            PictureBox.Image = myBitmap;
        }

        private void Draw_shpala()
        {
            Init_matr_preob(k, l, a, b, c, d); //инициализация матрицы преобразования

            shpala1 = Multiply_matr(shpala1, matr_sdv); //перемножение матриц

            Pen myPen = new Pen(Color.Brown, 2);// цвет линии и ширина

            //создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromImage(myBitmap);

            // рисуем 1 сторону квадрата
            g.DrawLine(myPen, (int)shpala1[0, 0], (int)shpala1[0, 1], (int)shpala1[1, 0], (int)shpala1[1, 1]);
            // рисуем 2 сторону квадрата
            g.DrawLine(myPen, (int)shpala1[1, 0], (int)shpala1[1, 1], (int)shpala1[2, 0], (int)shpala1[2, 1]);
            // рисуем 3 сторону квадрата
            g.DrawLine(myPen, (int)shpala1[2, 0], (int)shpala1[2, 1], (int)shpala1[3, 0], (int)shpala1[3, 1]);
            // рисуем 4 сторону квадрата
            g.DrawLine(myPen, (int)shpala1[3, 0], (int)shpala1[3, 1], (int)shpala1[0, 0], (int)shpala1[0, 1]);

            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            myPen.Dispose(); //освобождвем ресурсы, связанные с Pen
            PictureBox.Image = myBitmap;
        }

        private void Draw_Wheel()
        {
            Pen myPen = new Pen(Color.Silver, 2);// цвет линии и ширина

            //создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromImage(myBitmap);

            // Указываем центр и радиус планеты
            int centerX = (int)center1;
            int centerY = (int)center2;
            int radius = 11;

            // Рисуем планету
            g.DrawEllipse(myPen, centerX - radius, centerY - radius, 2 * radius, 2 * radius);

            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            myPen.Dispose(); //освобождвем ресурсы, связанные с Pen
            PictureBox.Image = myBitmap;

        }

        private void Draw_Shatun()
        {
            Init_matr_preob(k, l, a, b, c, d); //инициализация матрицы преобразования

            shatun = Multiply_matr(shatun, matr_sdv); //перемножение матриц

            Pen myPen = new Pen(Color.Black, 2);// цвет линии и ширина

            //создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromImage(myBitmap);

            g.DrawLine(myPen, (int)shatun[0, 0], (int)shatun[0, 1], (int)shatun[1, 0], (int)shatun[1, 1]);

            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            myPen.Dispose(); //освобождвем ресурсы, связанные с Pen
            PictureBox.Image = myBitmap;

        }

        private void Draw_CrTree()
        {
            Init_matr_preob(k, l, a, b, c, d); //инициализация матрицы преобразования

            crtree = Multiply_matr(crtree, matr_sdv); //перемножение матриц
            cleg = Multiply_matr(cleg, matr_sdv);
            Pen myPen = new Pen(Color.DarkGreen, 2);// цвет линии и ширина
            Pen myPen2 = new Pen(Color.Brown, 2);
            //создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromImage(myBitmap);

            // рисуем 1 сторону квадрата
            g.DrawLine(myPen2, (int)cleg[0, 0], (int)cleg[0, 1], (int)cleg[1, 0], (int)cleg[1, 1]);
            // рисуем 2 сторону квадрата
            g.DrawLine(myPen2, (int)cleg[1, 0], (int)cleg[1, 1], (int)cleg[2, 0], (int)cleg[2, 1]);
            // рисуем 3 сторону квадрата
            g.DrawLine(myPen2, (int)cleg[2, 0], (int)cleg[2, 1], (int)cleg[3, 0], (int)cleg[3, 1]);
            // рисуем 4 сторону квадрата
            g.DrawLine(myPen2, (int)cleg[3, 0], (int)cleg[3, 1], (int)cleg[0, 0], (int)cleg[0, 1]);

            g.DrawLine(myPen, (int)crtree[0, 0], (int)crtree[0, 1], (int)crtree[1, 0], (int)crtree[1, 1]);
            g.DrawLine(myPen, (int)crtree[1, 0], (int)crtree[1, 1], (int)crtree[2, 0], (int)crtree[2, 1]);
            g.DrawLine(myPen, (int)crtree[2, 0], (int)crtree[2, 1], (int)crtree[0, 0], (int)crtree[0, 1]);

            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            myPen.Dispose(); //освобождвем ресурсы, связанные с Pen
            myPen2.Dispose();
            PictureBox.Image = myBitmap;
        }

        private void Draw_Tree()
        {
            Init_matr_preob(k, l, a, b, c, d);

            leg = Multiply_matr(leg, matr_sdv);
            Pen myPen = new Pen(Color.Green, 2);
            Pen myPen2 = new Pen(Color.Brown, 2);
            Graphics g = Graphics.FromImage(myBitmap);

            // рисуем 1 сторону квадрата
            g.DrawLine(myPen2, (int)leg[0, 0], (int)leg[0, 1], (int)leg[1, 0], (int)leg[1, 1]);
            // рисуем 2 сторону квадрата
            g.DrawLine(myPen2, (int)leg[1, 0], (int)leg[1, 1], (int)leg[2, 0], (int)leg[2, 1]);
            // рисуем 3 сторону квадрата
            g.DrawLine(myPen2, (int)leg[2, 0], (int)leg[2, 1], (int)leg[3, 0], (int)leg[3, 1]);
            // рисуем 4 сторону квадрата
            g.DrawLine(myPen2, (int)leg[3, 0], (int)leg[3, 1], (int)leg[0, 0], (int)leg[0, 1]);

            // Указываем центр и радиус
            int centerX = (int)center1;
            int centerY = (int)center2;
            int radius = 20;

            // Рисуем планету
            g.DrawEllipse(myPen, centerX - radius, centerY - radius, 2 * radius, 2 * radius);

            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            myPen.Dispose(); //освобождвем ресурсы, связанные с Pen
            myPen2.Dispose();
            PictureBox.Image = myBitmap;
        }

        private void Draw_Kust()
        {
            Init_matr_preob(k, l, a, b, c, d);

            little_leg = Multiply_matr(little_leg, matr_sdv);
            Pen myPen = new Pen(Color.Green, 2);
            Pen myPen2 = new Pen(Color.Brown, 2);
            Graphics g = Graphics.FromImage(myBitmap);

            // рисуем 1 сторону квадрата
            g.DrawLine(myPen2, (int)little_leg[0, 0], (int)little_leg[0, 1], (int)little_leg[1, 0], (int)little_leg[1, 1]);
            // рисуем 2 сторону квадрата
            g.DrawLine(myPen2, (int)little_leg[1, 0], (int)little_leg[1, 1], (int)little_leg[2, 0], (int)little_leg[2, 1]);
            // рисуем 3 сторону квадрата
            g.DrawLine(myPen2, (int)little_leg[2, 0], (int)little_leg[2, 1], (int)little_leg[3, 0], (int)little_leg[3, 1]);
            // рисуем 4 сторону квадрата
            g.DrawLine(myPen2, (int)little_leg[3, 0], (int)little_leg[3, 1], (int)little_leg[0, 0], (int)little_leg[0, 1]);

            // Указываем центр и радиус
            int centerX = (int)center1;
            int centerY = (int)center2;
            int radius = 20;

            // Рисуем планету
            g.DrawEllipse(myPen, centerX - radius, centerY - radius, 2 * radius, 2 * radius);

            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            myPen.Dispose(); //освобождвем ресурсы, связанные с Pen
            myPen2.Dispose();
            PictureBox.Image = myBitmap;
        }

        //Создание сцены
        private void Generate()
        {
            Clear_matr_preob();

            Init_crtree();

            Init_leg();

            Init_cleg();

            Init_little_leg();

            Init_relsa();

            Init_train();

            Init_shatun();

            Init_vagon();

            Init_connect();

            Init_shpala();

            shpala1 = shpala;

            k = myBitmap.Width / 2;
            l = myBitmap.Height / 2 + 200;

            center1 = k - 210;
            center2 = l - 20;

            for (int i = 0; i < 3; i++)
            {
                Draw_Wheel();
                center1 += 50;
                center2 = l - 20;
            }

            center1 = k - 15;

            for (int i = 0; i < 3; i++)
            {
                Draw_Wheel();
                center1 += 50;
                center2 = l - 20;
            }

            Draw_relsa();

            Draw_connect();

            Draw_train();

            Draw_vagon();

            k = myBitmap.Width / 2 - 250;
            l = myBitmap.Height / 2 + 200;

            for (int i = 0; i < 5; i++)
            {
                Draw_shpala();
                k = 100;
                l = 0;
            }

            k = myBitmap.Width / 2 - 200;
            l = myBitmap.Height / 2 + 180;

            Draw_Shatun();

            k = myBitmap.Width / 2;
            l = myBitmap.Height / 2;

            Draw_CrTree();

            k = myBitmap.Width / 2 + 100;
            l = myBitmap.Height / 2;
            center1 = k;
            center2 = l;
            Draw_Tree();

            k = myBitmap.Width / 2 - 100;
            l = myBitmap.Height / 2 + 40;
            center1 = k;
            center2 = l - 10;
            Draw_Kust();

            k = -180;
            l = +10;
            Draw_CrTree();

            Timer.Start();
        }



        private void Timer_Tick(object sender, EventArgs e)
        {
            ClearImage();
            Clear_matr_preob();

            k = myBitmap.Width / 2 - 65;
            l = myBitmap.Height / 2 + 176;

            center1 = k - 210;
            center2 = l - 20;

            for (int i = 0; i < 3; i++)
            {
                Draw_Wheel();
                center1 += 50;
                center2 = l - 20;
            }

            center1 = k - 12;

            for (int i = 0; i < 3; i++)
            {
                Draw_Wheel();
                center1 += 50;
                center2 = l - 20;
            }

            Clear_matr_preob(); //1

            Draw_relsa();

            Draw_connect();

            Draw_train();

            Draw_vagon();

            shpala1 = shpala;
            shpalaX++;
            if (shpalaX == 100)
            {
                shpalaX = 0;
            }

            k = myBitmap.Width / 2 - 350 + shpalaX;
            l = myBitmap.Height / 2 + 176;

            for (int i = 0; i < 5; i++)
            {
                Draw_shpala();
                k = 100;
                l = 0;
            }

            Clear_matr_preob(); //2

            treeX++;
            if (treeX == 300)
            {
                treeX = 0;
            }

            //lk

            Init_cleg();
            Init_crtree();

            k = myBitmap.Width / 2 - 700 + treeX;
            l = myBitmap.Height / 2;

            Draw_CrTree();

            Init_leg();

            k = myBitmap.Width / 2 - 600 + treeX;
            l = myBitmap.Height / 2;
            center1 = k;
            center2 = l;

            Draw_Tree();

            Init_little_leg();

            k = myBitmap.Width / 2 - 500 + treeX;
            l = myBitmap.Height / 2;
            center1 = k;
            center2 = l - 10;
            Draw_Kust();

            //lk

            Init_cleg();
            Init_crtree();

            k = myBitmap.Width / 2 - 400 + treeX;
            l = myBitmap.Height / 2;

            Draw_CrTree();

            Init_leg();

            k = myBitmap.Width / 2 - 300 + treeX;
            l = myBitmap.Height / 2;
            center1 = k;
            center2 = l;

            Draw_Tree();

            Init_little_leg();

            k = myBitmap.Width / 2 - 200 + treeX;
            l = myBitmap.Height / 2;
            center1 = k;
            center2 = l - 10;
            Draw_Kust();

            //lk

            Init_cleg();
            Init_crtree();

            k = myBitmap.Width / 2 - 100 + treeX;
            l = myBitmap.Height / 2;

            Draw_CrTree();

            Init_leg();

            k = myBitmap.Width / 2 + treeX;
            l = myBitmap.Height / 2;
            center1 = k;
            center2 = l;

            Draw_Tree();

            Init_little_leg();

            k = myBitmap.Width / 2 + 100 + treeX;
            l = myBitmap.Height / 2;
            center1 = k;
            center2 = l - 10;
            Draw_Kust();

            Clear_matr_preob();

            shatunY++;
            if (shatunY == 10)
            {
                shatunY = 0;
                shatunS *= -1;
            }
            l = shatunS;

            Draw_Shatun();
        }

        private void TUSUR_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            Bitmap tusur = new Bitmap("C:\\Users\\a1eks\\Desktop\\tusur.jpg");

            Graphics g = PictureBox.CreateGraphics();

            Font font = new Font("Arial", 20);
            Brush brush = new SolidBrush(Color.Black);

            g.DrawString("60 лет ТУСУР", font, brush, new Point(50, 50));
            g.DrawImage(tusur, new Point(70, 100));
            g.Dispose();
        }
    }
}
