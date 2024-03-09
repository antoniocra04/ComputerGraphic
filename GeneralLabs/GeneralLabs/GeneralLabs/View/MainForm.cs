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
    }
}
