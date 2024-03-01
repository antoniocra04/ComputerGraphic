using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace ComputerGraphic.View.Labs.Lab1.Tabs
{

    public partial class SM : UserControl
    {
        double a, b, cos, result;

        private List<double> AVector { get; } = new List<double>() { 0f, 0f, 0f };

        private List<double> BVector { get; } = new List<double>() { 0f, 0f, 0f };

        private Color RightInputColor { get; } = Color.White;
        private Color WrongtInputColor { get; } = Color.Red;


        public SM()
        {
            InitializeComponent();
        }

        private void UpdateCVector()
        {
            a = Math.Sqrt(Math.Pow(AVector[0], 2) + Math.Pow(AVector[1], 2) + Math.Pow(AVector[2], 2));
            b = Math.Sqrt(Math.Pow(BVector[0], 2) + Math.Pow(BVector[1], 2) + Math.Pow(BVector[2], 2));
            cos = AVector[0] * BVector[0] + AVector[1] * BVector[1] + AVector[2] * BVector[2];
            result = a * b * cos;

            resultTextBox.Text = result.ToString();
        }

        private void SetVectorFromTextBox(List<double> vector, int index, TextBox textBox)
        {
            double inputValue;
            if (double.TryParse(textBox.Text, out inputValue))
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

        private void ClearErrorFromTextBox(List<double> vector, int index, TextBox textBox)
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
            SetVectorFromTextBox(AVector, 0, aXTextBox);
        }

        private void AYTextBox_TextChanged(object sender, EventArgs e)
        {
            SetVectorFromTextBox(AVector, 1, aYTextBox);
        }

        private void AZTextBox_TextChanged(object sender, EventArgs e)
        {
            SetVectorFromTextBox(AVector, 2, aZTextBox);
        }

        private void BXTextBox_TextChanged(object sender, EventArgs e)
        {
            SetVectorFromTextBox(BVector, 0, bXTextBox);
        }

        private void BYTextBox_TextChanged(object sender, EventArgs e)
        {
            SetVectorFromTextBox(BVector, 1, bYTextBox);
        }

        private void BZTextBox_TextChanged(object sender, EventArgs e)
        {
            SetVectorFromTextBox(BVector, 2, bZTextBox);
        }

        private void AXTextBox_Leave(object sender, EventArgs e)
        {
            ClearErrorFromTextBox(AVector, 0, aXTextBox);
        }

        private void AYTextBox_Leave(object sender, EventArgs e)
        {
            ClearErrorFromTextBox(AVector, 1, aYTextBox);
        }

        private void AZTextBox_Leave(object sender, EventArgs e)
        {
            ClearErrorFromTextBox(AVector, 2, aZTextBox);
        }

        private void BXTextBox_Leave(object sender, EventArgs e)
        {
            ClearErrorFromTextBox(BVector, 0, bXTextBox);
        }

        private void BYTextBox_Leave(object sender, EventArgs e)
        {
            ClearErrorFromTextBox(BVector, 1, bYTextBox);
        }

        private void BZTextBox_Leave(object sender, EventArgs e)
        {
            ClearErrorFromTextBox(BVector, 2, bZTextBox);
        }

        private void SM_Load(object sender, EventArgs e)
        {
          
        }

        
    }
}
