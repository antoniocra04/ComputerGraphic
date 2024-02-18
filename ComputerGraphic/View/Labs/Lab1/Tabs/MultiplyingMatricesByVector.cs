using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ComputerGraphic.View.Labs.Lab1.Tabs
{
    public partial class MultiplyingMatricesByVector : UserControl
    {
        const int MaxN = 10;
        int n = 3;
        System.Windows.Forms.TextBox[,] MatrText = null;
        double[,] Matr1 = new double[MaxN, MaxN];
        double[,] Matr2 = new double[MaxN, MaxN];
        double[] Matr3 = new double[MaxN];
        bool f1;
        int dx = 40, dy = 20; 
        InputMatrixForm inputMatrixForm = null;

        public MultiplyingMatricesByVector()
        {
            InitializeComponent();
        }

        private void Clear_MatrText()
        {
            // Обнуление ячеек MatrText
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < n; j++)
                    MatrText[i, j].Text = "0";
        }

        private void matrixButton_Click(object sender, EventArgs e)
        {
            // 1. Чтение размерности матрицы
            if (matrixTextbox.Text == "") return;
            n = int.Parse(matrixTextbox.Text);
            // 2. Обнуление ячейки MatrText
            Clear_MatrText();
            // 3. Настройка свойств ячеек матрицы MatrText
            // с привязкой к значению n и форме Form2
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < n; j++)
                {
                    // 3.1. Порядок табуляции
                    MatrText[i, j].TabIndex = i * n + j + 1;
                    // 3.2. Сделать ячейку видимой
                    MatrText[i, j].Visible = true;
                }
            // 4. Корректировка размеров формы
            inputMatrixForm.Width = 10 + n * dx + 20;
            inputMatrixForm.Height = 10 + n * dy + inputMatrixForm.InputMatrixOkButton.Height + 50;
            // 5. Корректировка позиции и размеров кнопки на форме Form2
            inputMatrixForm.InputMatrixOkButton.Left = 10;
            inputMatrixForm.InputMatrixOkButton.Top = 10 + n * dy + 10;
            inputMatrixForm.InputMatrixOkButton.Width = inputMatrixForm.Width - 30;
            // 6. Вызов формы Form2
            if (inputMatrixForm.ShowDialog() == DialogResult.OK)
            {
                // 7. Перенос строк из формы Form2 в матрицу Matr1
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < n; j++)
                        if (MatrText[i, j].Text != "")
                            Matr1[i, j] = Double.Parse(MatrText[i, j].Text);
                        else
                            Matr1[i, j] = 0;
                // 8. Данные в матрицу Matr1 внесены
                f1 = true;
                label2.Text = "true";
            }
        }

        private void matrixTextbox_Leave(object sender, EventArgs e)
        {
            int nn;
            nn = Int16.Parse(matrixTextbox.Text);
            if (nn != n)
            {
                f1 = false;
                label2.Text = "false";
            }
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            // 1.Проверка, введены ли данные в обеих матрицах
            if (!((f1 == true))) return;
            // 2. Вычисление произведения матриц. Результат в Matr3
            int[] array2 = { int.Parse(xTextbox.Text), int.Parse(yTextbox.Text), int.Parse(zTextbox.Text) };
            for (int i = 0; i < n; i++)
                for (int j = 0; j < 3; j++)
                {
                    Matr3[i] += Matr1[j, i] * array2[j];
                }

            for(int i = 0; i < n; ++i)
            {
                resultLabel.Text += Matr3[i].ToString() + "\n";
            }
        }

        private void MultiplyingMatricesByVector_Load(object sender, EventArgs e)
        {
            matrixTextbox.Text = "";
            f1 = false;
            label2.Text = "false";
            int i, j;
            // 1. Выделение памяти для формы inputMatrixForm
            inputMatrixForm = new InputMatrixForm();
            // 2. Выделение памяти под самую матрицу
            MatrText = new System.Windows.Forms.TextBox[MaxN, MaxN];
            // 3. Выделение памяти для каждой ячейки матрицы и ее настройка
            for (i = 0; i < 3; i++)
                for (j = 0; j < MaxN; j++)
                {
                    // 3.1. Выделить память
                    MatrText[i, j] = new System.Windows.Forms.TextBox();
                    // 3.2. Обнулить эту ячейку
                    MatrText[i, j].Text = "0";
                    // 3.3. Установить позицию ячейки в форме Form2
                    MatrText[i, j].Location = new System.Drawing.Point(10 + i *
                    dx, 10 + j * dy);
                    // 3.4. Установить размер ячейки
                    MatrText[i, j].Size = new System.Drawing.Size(dx, dy);
                    // 3.5. Пока что спрятать ячейку
                    MatrText[i, j].Visible = false;
                    // 3.6. Добавить MatrText[i,j] в форму form2
                    inputMatrixForm.Controls.Add(MatrText[i, j]);
                }
        }
    }
}
