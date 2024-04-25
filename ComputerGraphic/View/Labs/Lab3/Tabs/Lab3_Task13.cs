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
    public partial class Lab3_Task13 : UserControl
    {

        public Lab3_Task13()
        {
            InitializeComponent();
            InitializeTrain();
            InitializeBackground();

            // Настройка интервала таймера на 50 миллисекунд (20 раз в секунду)
            AnimationTimer.Interval = 50;
            AnimationTimer.Start();
        }

        private int trainPosition = 0;
        private int backgroundPosition = 0;

        private const int TrainWidth = 200;
        private const int TrainHeight = 100;
        private const int WindowWidth = 30;
        private const int WindowHeight = 50;
        private const int ShatonWidth = 20;
        private const int ShatonHeight = 10;
        private const int ShatonSpeed = 2; // Скорость движения шатунов

        private Rectangle trainRect;
        private Rectangle[] windowRects;
        private Rectangle[] shatonRects;

        private Bitmap[] treeImages;
        private Rectangle[] treeRects;


        private void InitializeTrain()
        {
            // Инициализация пассажирского вагона
            trainRect = new Rectangle(50, ClientSize.Height / 2 - TrainHeight / 2, TrainWidth, TrainHeight);

            // Инициализация окон в вагоне
            int numWindows = TrainWidth / (WindowWidth + 10); // 10 - отступ между окнами
            windowRects = new Rectangle[numWindows];
            int windowX = trainRect.X + 10; // Начальное положение окон
            for (int i = 0; i < numWindows; i++)
            {
                windowRects[i] = new Rectangle(windowX, trainRect.Y + 20, WindowWidth, WindowHeight);
                windowX += WindowWidth + 10; // Перемещаемся к следующему окну
            }

            // Инициализация шатунов внутри вагона
            int numShatons = TrainWidth / (ShatonWidth + 10); // 10 - отступ между шатунами
            shatonRects = new Rectangle[numShatons];
            int shatonX = trainRect.X + 20; // Начальное положение шатунов
            for (int i = 0; i < numShatons; i++)
            {
                shatonRects[i] = new Rectangle(shatonX, trainRect.Y + TrainHeight - 20, ShatonWidth, ShatonHeight);
                shatonX += ShatonWidth + 10; // Перемещаемся к следующему шатуну
            }
        }

        private void InitializeBackground()
        {
            // Загрузка изображений деревьев
            Bitmap tree1 = new Bitmap("C:\\Users\\a1eks\\Desktop\\tree1.png"); //изображение tree1.png
            Bitmap tree2 = new Bitmap("C:\\Users\\a1eks\\Desktop\\tree2.png"); //изображение tree2.png

            // Инициализация массива изображений деревьев
            treeImages = new Bitmap[] { tree1, tree2 };

            // Инициализация позиций деревьев на фоне
            int numTrees = ClientSize.Width / 200; // Предположим, что каждое дерево имеет ширину 200 пикселей
            treeRects = new Rectangle[numTrees];
            int treeX = 0; // Начальная позиция деревьев
            for (int i = 0; i < numTrees; i++)
            {
                int randomTreeIndex = new Random().Next(0, treeImages.Length); // Случайный выбор изображения дерева
                int treeHeight = treeImages[randomTreeIndex].Height;
                int treeY = ClientSize.Height - treeHeight - 50; // Позиция дерева по вертикали
                treeRects[i] = new Rectangle(treeX, treeY, treeImages[randomTreeIndex].Width, treeHeight);
                treeX += treeImages[randomTreeIndex].Width + new Random().Next(100, 200); // Добавляем случайный отступ между деревьями
            }
        }

        private void Timer_Tick(object sender)
        {
            MoveTrain();
            MoveBackground();
            Invalidate();
        }

        private void MoveTrain()
        {
            // Движение поезда
            trainPosition -= 5; // Измените значение скорости движения поезда по вашему усмотрению

            // Проверка, если поезд вышел за пределы экрана, чтобы переместить его обратно в начало
            if (trainPosition + TrainWidth <= 0)
            {
                trainPosition = ClientSize.Width;
            }

            // Движение шатунов
            for (int i = 0; i < shatonRects.Length; i++)
            {
                shatonRects[i].Y -= ShatonSpeed; // Движение шатуна вверх

                // Если шатун вышел за пределы верхней границы вагона, переместить его вниз
                if (shatonRects[i].Y + ShatonHeight < trainRect.Y)
                {
                    shatonRects[i].Y = trainRect.Y + TrainHeight - 20; // 20 - отступ от нижней границы вагона
                }
            }
        }

        private Random random = new Random();

        private void MoveBackground()
        {
            for (int i = 0; i < treeRects.Length; i++)
            {
                // Перемещение дерева за пределы экрана слева
                if (treeRects[i].X + treeRects[i].Width < 0)
                {
                    // Позиционирование дерева за пределами экрана справа
                    treeRects[i].X = ClientSize.Width + random.Next(100, 200);
                    // Позиция дерева по вертикали
                    int randomTreeIndex = random.Next(0, treeImages.Length);
                    int treeHeight = treeImages[randomTreeIndex].Height;
                    treeRects[i].Y = ClientSize.Height - treeHeight - 50; // 50 - отступ от нижней границы окна
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawTrain(e.Graphics);
            DrawBackground(e.Graphics);
        }

        private void DrawTrain(Graphics g)
        {
            // Отрисовка поезда
            g.FillRectangle(Brushes.Blue, trainRect);

            // Отрисовка окон в вагоне
            foreach (Rectangle windowRect in windowRects)
            {
                g.FillRectangle(Brushes.White, windowRect);
            }

            // Отрисовка шатунов внутри вагона
            foreach (Rectangle shatonRect in shatonRects)
            {
                g.FillRectangle(Brushes.Gray, shatonRect);
            }
        }

        private void DrawBackground(Graphics g)
        {
            for (int i = 0; i < treeRects.Length; i++)
            {
                int randomTreeIndex = random.Next(0, treeImages.Length);
                Bitmap treeImage = treeImages[randomTreeIndex];
                g.DrawImage(treeImage, treeRects[i]);
            }
        }
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // Перемещение поезда и заднего фона
            MoveTrain();
            MoveBackground();

            pictureBox.Invalidate(); // Перерисовываем PictureBox при каждом тике таймера
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Рисование поезда
            DrawTrain(g);

            // Рисование заднего фона
            DrawBackground(g);
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
