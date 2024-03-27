using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ComputerGraphic.View.Labs.Lab2.Tabs
{
    public partial class UserControl1 : UserControl
    {
        private int CenterX, CenterY;

        public UserControl1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            CenterX = e.X;
            CenterY = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Pen myPen = new Pen(Color.Red, 1);
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);

            int radius = int.Parse(RadiusTextBox.Text);
            int x = 0;
            int y = radius;
      
            int dd = 1 - 2 * radius;
            int di = 0;

            while (y >= 0)
            {
                g.DrawRectangle(myPen, CenterX + x, CenterY + y, 1, 1);
                g.DrawRectangle(myPen, CenterX - x, CenterY + y, 1, 1);
                g.DrawRectangle(myPen, CenterX + x, CenterY - y, 1, 1);
                g.DrawRectangle(myPen, CenterX - x, CenterY - y, 1, 1);

                di = 2 * (dd + y) - 1;

                if (dd < 0 && di <= 0)
                {
                    x++;
                    dd += 2 * x + 1;
                    continue;
                }

                di = 2 * (dd - x) - 1;

                if (dd > 0 && di > 0)
                {
                    y--;
                    dd += 1 - 2 * y;
                    continue;
                }

                x++;
                dd += 2 * (x - y);
                y--;
            }

        
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

    }
}
