using Tao.OpenGl;
using Tao.FreeGlut;

namespace ComputerGraphic.View.Labs.Lab4.Tabs
{
    public partial class OpenGLPrimitives : UserControl
    {
        public Color MaterialColor { get; set; } = Color.White;

        public float AngleX { get; set; } = 0f;
        public float AngleY { get; set; } = 0f;
        public float AngleZ { get; set; } = 0f;

        public int CurrentObject { get; set; } = 1;


        public float Speed { get; set; } = 1f;

        public OpenGLPrimitives()
        {
            InitializeComponent();
            Glut.glutInit();
            Glut.glutInitWindowSize(500, 500);
            Glut.glutCreateWindow("Primitives");

        }

        private void showSolid(int obj)
        {
            switch (obj)
            {
                case 1:
                    Glut.glutSolidCone(0.2, 0.75, 16, 8);
                    break; // Конус
                case 2:
                    Glut.glutSolidCube(0.75);
                    break; // Куб
                case 3:
                    Glut.glutSolidCylinder(0.2, 0.75, 16, 16); break;//Цилиндр 
                case 4:
                    Gl.glScaled(0.5, 0.5, 0.5); Glut.glutSolidDodecahedron();
                    break; // Додекаэдр
                case 5:
                    Glut.glutSolidIcosahedron();
                    break; // Икосаэдр
                case 6:
                    Glut.glutSolidOctahedron();
                    break; // Октаэдр
                case 7:
                    Glut.glutSolidRhombicDodecahedron();
                    break; // Ромбический додекаэдр
                case 8:
                    double[] offset = { 0.0 };
                    Glut.glutSolidSierpinskiSponge(7, offset, 1);
                    break; // Фрактал Губка Серпиского
                case 9:
                    Glut.glutSolidSphere(0.75, 16, 16);
                    break; // Сфера
                case 10:
                    Glut.glutSolidTeapot(0.5);
                    break; // Чайник
                case 11:
                    Gl.glRotated(180, 0, 1, 0);
                    Glut.glutSolidTetrahedron();
                    break; // Тетраэдр
                case 12:
                    Glut.glutSolidTorus(0.15, 0.65, 16, 16);
                    break; // Тор
            }
        }
        private void draw(int obj)
        {
            // Очистка буфера цвета и буфера глубины
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT | Gl.GL_ACCUM_BUFFER_BIT);
            // Матрица проецирования
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glRotated(-30, 1, 0, 0);
            // Поворачиваем по 3 углам
            Gl.glRotated(AngleX, 1, 0, 0);
            Gl.glRotated(AngleY, 0, 1, 0);
            Gl.glRotated(AngleZ, 0, 0, 1);
            // Видовая матрица
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            if (radioButton1.Checked) // radioButton1.Checked
            {
                // Белый цвет
                Gl.glColor3f(1, 1, 1);
                // Выводим glut-примитив в виде каркаса
                switch (obj)
                {
                    case 1:
                        Glut.glutWireCone(0.2, 0.75, 16, 8);
                        break; // Конус
                    case 2:
                        Glut.glutWireCube(0.75);
                        break; // Куб
                    case 3:
                        Glut.glutWireCylinder(0.2, 0.75, 16, 16);
                        break; // Цилиндр
                    case 4:
                        Gl.glScaled(0.5, 0.5, 0.5);
                        Glut.glutWireDodecahedron();
                        break; // Додекаэдр
                    case 5:
                        Glut.glutWireIcosahedron();
                        break; // Икосаэдр
                    case 6:
                        Glut.glutWireOctahedron();
                        break; // Октаэдр
                    case 7:
                        Glut.glutWireRhombicDodecahedron();
                        break; // Ромбический додекаэдр
                    case 8:
                        double[] offset = { 0, 0, 0 };
                        Glut.glutWireSierpinskiSponge(7, offset, 1);
                        break; // Фрактал Губка Серпиского
                    case 9:
                        Glut.glutWireSphere(0.75, 16, 16);
                        break; // Сфера
                    case 10:
                        Glut.glutWireTeapot(0.5);
                        break; // Чайник
                    case 11:
                        Gl.glRotated(180, 0, 1, 0);
                        Glut.glutWireTetrahedron();
                        break; // Тетраэдр
                    case 12:
                        Glut.glutWireTorus(0.15, 0.65, 16, 16);
                        break; // Тор
                }
            }
            else if (radioButton2.Checked) // radioButton2.Checked
            {                 // Модель освещенности с одним источником цвета
                float[] light_position = 
                    { 
                    (float)numericUpDown2.Value, 
                    (float)numericUpDown3.Value, 
                    (float)numericUpDown4.Value, 
                    0 }; // Координаты источника света
                float[] lghtClr = { 1, 1, 1, 0 };
                // Источник излучает белый цвет
                float[] mtClr = { MaterialColor.R / 256f, MaterialColor.G / 256f, MaterialColor.B / 256f, 0 }; // Материал нашего цвета
                Gl.glPolygonMode(Gl.GL_FRONT, Gl.GL_FILL); // Заливка полигонов
                Gl.glShadeModel(Gl.GL_SMOOTH); // Вывод с интерполяцией цветов
                Gl.glEnable(Gl.GL_LIGHTING); // Будем рассчитывать освещенность
                Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, light_position);
                Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_AMBIENT, lghtClr); // Рассеивание
                Gl.glEnable(Gl.GL_LIGHT0);
                // Включаем в уравнение освещенности источник GL_LIGHT0                 
                // Диффузионная компонента цвета материала
                Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_DIFFUSE, mtClr);
                // Выводим тонированный glut-примитив
                showSolid(obj);
                Gl.glDisable(Gl.GL_LIGHTING);
                // Будем рассчитывать освещенность

                Gl.glMatrixMode(Gl.GL_PROJECTION);
                Gl.glLoadIdentity();
                Gl.glViewport(0, 0, 500, 500);
                Glu.gluPerspective(40, 500 / 500, 1, 100);
                Gl.glMatrixMode(Gl.GL_MODELVIEW);
            }
            Glu.gluLookAt(0, 0, 0, 0, 0, 0, 0, 0, 0);
            Glut.glutSwapBuffers();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CurrentObject = 1;
            draw(CurrentObject);
            // Конус
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CurrentObject = 2;
            draw(CurrentObject); // Куб
        }
        private void button3_Click(object sender, EventArgs e)
        {
            CurrentObject = 3;
            draw(CurrentObject); // Цилиндр
        }
        private void button4_Click(object sender, EventArgs e)
        {
            CurrentObject = 4;
            draw(CurrentObject); // Додекаэдр
        }
        private void button5_Click(object sender, EventArgs e)
        {
            CurrentObject = 5;
            draw(CurrentObject); // Икосаэдр
        }
        private void button6_Click(object sender, EventArgs e)
        {
            CurrentObject = 6;
            draw(CurrentObject); // Октаэдр
        }
        private void button7_Click(object sender, EventArgs e)
        {
            CurrentObject = 7;
            draw(CurrentObject); // Ромбический додекаэдр
        }
        private void button8_Click(object sender, EventArgs e)
        {
            CurrentObject = 8;
            draw(CurrentObject); // Фрактал Губка Серпиского
        }
        private void button9_Click(object sender, EventArgs e)
        {
            CurrentObject = 9;
            draw(CurrentObject); // Сфера
        }
        private void button10_Click(object sender, EventArgs e)
        {
            CurrentObject = 10;
            draw(CurrentObject); // Чайник
        }
        private void button11_Click(object sender, EventArgs e)
        {
            CurrentObject = 11;
            draw(CurrentObject); // Тетраэдр
        }
        private void button12_Click(object sender, EventArgs e)
        {
            CurrentObject = 12;
            draw(CurrentObject); // Тор
        }
        private void Primitives_Load(object sender, EventArgs e)
        {
            // Черный цвет фона
            Gl.glClearColor(0, 0, 0, 1);
            // Активизируем тест глубины
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            draw(CurrentObject);
            timer1.Start();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                MaterialColor = colorDialog1.Color;
                draw(CurrentObject);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                AngleX = (AngleX + Speed) % 360;
            }
            if (checkBox2.Checked)
            {
                AngleY = (AngleY + Speed) % 360;
            }
            if (checkBox3.Checked)
            {
                AngleZ = (AngleZ + Speed) % 360;
            }

            draw(CurrentObject);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            draw(CurrentObject);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Speed = (float)numericUpDown1.Value / 10f;
        }
    }
}
