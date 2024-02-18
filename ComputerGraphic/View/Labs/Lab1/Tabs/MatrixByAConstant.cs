using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace ComputerGraphic.View.Labs.Lab1.Tabs
{
    public partial class MatrixByAConstant : UserControl
    {
        const int maxN = 5; //максимальная размерность матрицы
        int n = 3; //базовая размерность матрицы
        int Const = 1; //базовое значение константы
        TextBox[,] matrixText = null; //
        double[,] matrix1 = new double[maxN, maxN];//матрица чисел
        double[,] matrix2 = new double[maxN, maxN];//результат
        bool flag1 = false;//указывает о вводе данных в матрицу 1
        bool flag2 = false;
        int dx = 40, dy = 20;
        MatrixForm matrixForm = null; //экземпляр объект класса MatrixForm

        private void Clear_MatrixText()
        {
            //обнуление ячеек
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matrixText[i, j].Text = "0";
        }

        private void MatrixByAConstant_Load(object sender, EventArgs e)
        {
            nTextBox.Text = "";
            flag1 = false;
            flag2 = false;
            //
            LabelError1.Text = "Задайте размерность n";
            LabelError2.Text = "Задайте const";
            //
            //
            int i, j;
            matrixForm = new MatrixForm();
            matrixText = new TextBox[maxN, maxN];
            for (i = 0; i < maxN; i++)
                for (j = 0; j < maxN; j++)
                {
                    matrixText[i, j] = new TextBox();
                    matrixText[i, j].Text = "0";
                    matrixText[i, j].Location = new System.Drawing.Point(10 + i * dx, 10 + j * dy); //отрисовка матрицы
                    matrixText[i, j].Size = new System.Drawing.Size(dx, dy);
                    matrixText[i, j].Visible = false;
                    // Добавить MatrixText[i,j] в форму maxtrixForm
                    matrixForm.Controls.Add(matrixText[i, j]);
                }

        }

        public MatrixByAConstant()
        {
            InitializeComponent();
        }

        private void CreateMatrixButton_Click(object sender, EventArgs e)
        {
            //чтение размерности матрицы
            if (nTextBox.Text == "") return;
            n = int.Parse(nTextBox.Text);
            Clear_MatrixText();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    // Порядок табуляции
                    matrixText[i, j].TabIndex = i * n + j + 1;
                    // Сделать ячейку видимой
                    matrixText[i, j].Visible = true;
                }
            matrixForm.Width = 10 + n * dx + 20;
            matrixForm.Height = 10 + n * dy + matrixForm.OKButton.Height + 50;
            //корректировка кнопки
            matrixForm.OKButton.Left = 10;
            matrixForm.OKButton.Top = 10 + n * dy + 10;
            matrixForm.OKButton.Width = matrixForm.Width - 30;
            //Вызов формы с матрицей
            if (matrixForm.ShowDialog() == DialogResult.OK)
            {
                // Перенос строк из matrixForm в матрицу matrix1
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        if (matrixText[i, j].Text != "")
                            matrix1[i, j] = Double.Parse(matrixText[i, j].Text);
                        else
                            matrix1[i, j] = 0;
                // Данные в матрицу matrix1 внесены
                flag1 = true;
                LabelError1.Text = "Данные внесены";
            }
        }

        private void nTextBox_Leave(object sender, EventArgs e)
        {
            /*int newN;
            newN = Int16.Parse(nTextBox.Text);
            if (newN != n)
            {
                flag1 = false;
                LabelError1.Text = "Задайте размерность n";
                //
            }*/
        }

        private void constTextBox_Leave(object sender, EventArgs e)
        {
            /*int newConst;
            newConst = Int16.Parse(constTextBox.Text);
            if (newConst != Const)
            {
                flag2 = false;
                LabelError2.Text = "Задайте const";
                //
            }*/
        }

        private void nTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            if (constTextBox.Text == "") return;
            Const = int.Parse(constTextBox.Text);
            Clear_MatrixText();
            LabelError2.Text = "Данные внесены";
            flag2 = true; 
            // Проверка флагов
            //if (!(flag1 == true) && (flag2 == true)) return;
            // Вычисление произведения
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    matrix2[j, i] = 0;
                    for (int k = 0; k < n; k++)
                        matrix2[j, i] = matrix2[j, i] + matrix1[k, i] * Const;
                }
            // Внесение данных
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    // Порядок табуляции
                    matrixText[i, j].TabIndex = i * n + j + 1;
                    // Перевести число в строку
                    matrixText[i, j].Text = matrix2[i, j].ToString();
                }
            matrixForm.ShowDialog();
            if (matrixForm.ShowDialog() == DialogResult.OK)
            {
                Clear_MatrixText();
            }
        }
    }
}
