using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerGraphic.View.Labs.Lab1.Tabs
{
    public partial class VectorProductOfVectors : UserControl
    {
        private List<float> AVector { get; } = new List<float>() { 0f, 0f, 0f };

        private List<float> BVector { get; } = new List<float>() { 0f, 0f, 0f };

        private List<float> CVector { get; } = new List<float> { 0f, 0f, 0f };

        private Color RightInputColor { get; } = Color.White;
        private Color WrongtInputColor { get; } = Color.Red;

        public VectorProductOfVectors()
        {
            InitializeComponent();
        }

        private void UpdateCVector()
        {
            CVector[0] = AVector[1] * BVector[2] - AVector[2] * BVector[1];
            CVector[1] = AVector[0] * BVector[2] - AVector[2] * BVector[0];
            CVector[2] = AVector[0] * BVector[1] - AVector[1] * BVector[0];

            CXTextBox.Text = CVector[0].ToString();
            CYTextBox.Text = CVector[1].ToString();
            CZTextBox.Text = CVector[2].ToString();
        }

        private void SetVectorFromTextBox(List<float> vector, int index, TextBox textBox)
        {
            float inputValue;
            if (float.TryParse(textBox.Text, out inputValue))
            {
                textBox.BackColor = RightInputColor;
                vector[index] = inputValue;
                UpdateCVector();
            }
            else
            {
                textBox.BackColor = WrongtInputColor;
            }
        }

        private void ClearErrorFromTextBox(List<float> vector, int index, TextBox textBox)
        {
            if (textBox.BackColor == RightInputColor)
            {
                return;
            }

            textBox.BackColor = RightInputColor;
            textBox.Text = vector[index].ToString();
        }

        private void AXTextBox_TextChanged(object sender, EventArgs e)
        {
            SetVectorFromTextBox(AVector, 0, AXTextBox);
        }

        private void AYTextBox_TextChanged(object sender, EventArgs e)
        {
            SetVectorFromTextBox(AVector, 1, AYTextBox);
        }

        private void AZTextBox_TextChanged(object sender, EventArgs e)
        {
            SetVectorFromTextBox(AVector, 2, AZTextBox);
        }

        private void BXTextBox_TextChanged(object sender, EventArgs e)
        {
            SetVectorFromTextBox(BVector, 0, BXTextBox);
        }

        private void BYTextBox_TextChanged(object sender, EventArgs e)
        {
            SetVectorFromTextBox(BVector, 1, BYTextBox);
        }

        private void BZTextBox_TextChanged(object sender, EventArgs e)
        {
            SetVectorFromTextBox(BVector, 2, BZTextBox);
        }

        private void AXTextBox_Leave(object sender, EventArgs e)
        {
            ClearErrorFromTextBox(AVector, 0, AXTextBox);
        }

        private void AYTextBox_Leave(object sender, EventArgs e)
        {
            ClearErrorFromTextBox(AVector, 1, AYTextBox);
        }

        private void AZTextBox_Leave(object sender, EventArgs e)
        {
            ClearErrorFromTextBox(AVector, 2, AZTextBox);
        }

        private void BXTextBox_Leave(object sender, EventArgs e)
        {
            ClearErrorFromTextBox(BVector, 0, BXTextBox);
        }

        private void BYTextBox_Leave(object sender, EventArgs e)
        {
            ClearErrorFromTextBox(BVector, 1, BYTextBox);
        }

        private void BZTextBox_Leave(object sender, EventArgs e)
        {
            ClearErrorFromTextBox(BVector, 2, BZTextBox);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
