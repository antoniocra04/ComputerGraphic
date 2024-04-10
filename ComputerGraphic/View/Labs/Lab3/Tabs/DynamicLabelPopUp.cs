using static System.Net.Mime.MediaTypeNames;

namespace ComputerGraphic.View.Labs.Lab3.Tabs
{
    public partial class DynamicLabelPopUp : Form
    {
        private DynamicLabel _dynamicLabel;

        public DynamicLabel DynamicLabel
        {
            get => _dynamicLabel;
            set
            {
                _dynamicLabel = value;
                TextBox.Text = DynamicLabel.Text;
                NumericUpDown.Value = DynamicLabel.FontSize;
                TrackBar.Value = (int)DynamicLabel.Speed;
                RandomRadioButton.Checked = DynamicLabel.IsRandomColor;
                OneColorRadioButton.Checked = !DynamicLabel.IsRandomColor;
                ColorButton.Enabled = !DynamicLabel.IsRandomColor;
            }
        }

        public DynamicLabelPopUp()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            var oldLenght = DynamicLabel.Text.Length;
            DynamicLabel.Text = TextBox.Text;
            if (oldLenght != DynamicLabel.Text.Length)
            {
                if (OneColorRadioButton.Checked)
                {
                    DynamicLabel.SetColors(ColorDialog.Color);
                }
                else
                {
                    DynamicLabel.SetRandomColors();
                }
            }
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            DynamicLabel.FontSize = (int)NumericUpDown.Value;
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            DynamicLabel.Speed = TrackBar.Value;
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            var result = ColorDialog.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                return;
            }
            DynamicLabel.SetColors(ColorDialog.Color);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void DynamicLabelPopUp_Load(object sender, EventArgs e)
        {
            if (DynamicLabel == null)
            {
                DynamicLabel = new DynamicLabel();
            }

            if (OneColorRadioButton.Checked)
            {
                ColorDialog.Color = DynamicLabel.Colors[0];
            }
        }

        private void OneColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (OneColorRadioButton.Checked)
            {
                DynamicLabel.IsRandomColor = false;
                ColorButton.Enabled = true;
            }
            else
            {
                DynamicLabel.IsRandomColor = true;
                ColorButton.Enabled = false;
            }
        }
    }
}
