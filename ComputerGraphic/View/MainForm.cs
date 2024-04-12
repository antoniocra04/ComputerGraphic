using ComputerGraphic.View.Labs.Lab1;
using ComputerGraphic.View.Labs.Lab2;
using ComputerGraphic.View.Labs.Lab3;

namespace ComputerGraphic
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Lab1Button_Click(object sender, EventArgs e)
        {
            var lab = new Lab1();
            lab.ShowDialog();
        }

        private void Lab2Button_Click(object sender, EventArgs e)
        {
            var lab = new Lab2();
            lab.ShowDialog();
        }

        private void Lab3Button_Click(object sender, EventArgs e)
        {
            var lab = new Lab3();
            lab.ShowDialog();
        }
    }
}