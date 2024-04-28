using GeneralLabs.View.Labs;

namespace GeneralLabs
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Lab2 = new Lab2();
            Lab2.ShowDialog();
        }

        private void Lab3Button_Click(object sender, EventArgs e)
        {
            var Lab3 = new Lab3();
            Lab3.ShowDialog();
        }

        private void Lab4Button_Click(object sender, EventArgs e)
        {
            var Lab4 = new Lab4();
            Lab4.ShowDialog();
        }
    }
}
