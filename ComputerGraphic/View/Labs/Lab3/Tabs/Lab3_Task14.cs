using ComputerGraphic.Model;
using System.Drawing.Drawing2D;

namespace ComputerGraphic.View.Labs.Lab3.Tabs
{
    public partial class Lab3_Task14 : UserControl
    {
        Bitmap Bitmap { get; set; }

        List<DynamicLabel> Labels { get; set; } = new List<DynamicLabel>();

        int _interval;

        int Interval
        {
            get => _interval;
            set
            {
                _interval = value;
                Timer.Interval = value;
            }
        }
        int Width
        {
            get
            {
                return PictureBox.Width;
            }
        }
        int Height
        {
            get
            {
                return PictureBox.Height;
            }
        }

        int TriggerRadius { get; set; } = 20;

        int FontSize { get; set; } = 12;

        int Fi { get; set; } = 0;

        public Lab3_Task14()
        {
            InitializeComponent();
            Interval = 2;
        }

        public Bitmap Superimpose(Bitmap bitmap, int x, int y, double speed)
        {
            Graphics g = Graphics.FromImage(Bitmap);
            g.CompositingMode = CompositingMode.SourceOver;
            g.TranslateTransform(x, y);
            g.RotateTransform((float)(Fi * speed));
            bitmap.MakeTransparent();
            g.FillEllipse(new SolidBrush(Color.LightGray), -10, -10, 20, 20);
            g.DrawImage(bitmap, -bitmap.Width / 2, -bitmap.Height / 2);
            g.Dispose();
            
            return Bitmap;
        }

        void DrawLabels()
        {
            /*var labels = new List<DynamicLabel>();

            foreach(var label in Labels)
            {
                labels.Add(label);
            }*/

            foreach (var label in Labels)
            {
                var font = new Font("Arial", label.FontSize, FontStyle.Regular);

                var pe = Graphics.FromImage(Bitmap);
                var width = pe.MeasureString(label.Text, font);
                pe.Dispose();
                var bitmap = new Bitmap((int)width.Width, (int)font.GetHeight());
                var g = Graphics.FromImage(bitmap);
                var temp = "";

                for (var i = 0; i <  label.Text.Length; i++)
                {
                    var brush = new SolidBrush(label.Colors[i]);

                    if (temp != string.Empty)
                    {
                        g.DrawString(label.Text[i].ToString(), font, brush, g.MeasureString(temp, font).Width - label.FontSize / 2, 0);
                    }
                    else
                    {
                        g.DrawString(label.Text[i].ToString(), font, brush, 0, 0);
                        
                    }
                    
                    temp += label.Text[i];
                }

                
                
                g.Dispose();
                Superimpose(bitmap, (int)label.Point.X, (int)label.Point.Y, label.Speed);
                bitmap.Dispose();
            }

            
            PictureBox.Image = Bitmap;
        }

        private void ClearImage()
        {
            if (Bitmap != null)
            {
                Bitmap.Dispose();
            }
            Bitmap = new Bitmap(Width, Height);
            PictureBox.Image = Bitmap;
        }

        private void Repaint()
        {
            ClearImage();
            ClearEmptyLabels();
            DrawLabels();
        }

        private void ClearEmptyLabels()
        {
            var labels = new List<DynamicLabel>();

            foreach (var label in Labels)
            {
                if (label.Text != string.Empty)
                {
                    labels.Add(label);
                }
            }
            Labels.Clear();
            Labels = labels;
        }

        private void Lab3_Task14_Load(object sender, EventArgs e)
        {
            Repaint();
            Timer.Start();
        }

        private void Lab3_Task14_Resize(object sender, EventArgs e)
        {
            //Repaint();
        }

        private void PictureBox_DoubleClick(object sender, EventArgs e)
        {
            var mouse = e as MouseEventArgs;
            var popup = new DynamicLabelPopUp();
            var result = popup.ShowDialog();

            if (result == DialogResult.OK)
            {
                var label = popup.DynamicLabel;
                label.Point = new Point2(mouse.X, mouse.Y);
                Labels.Add(label);
            }

            popup.Dispose();
            Repaint();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            var mouse = e as MouseEventArgs;
            var labels = new List<DynamicLabel>();

            foreach(var label in Labels)
            {
                labels.Add(label);
            }

            for (var i = 0; i < labels.Count; i++)
            {
                if (Math.Abs(labels[i].Point.X - mouse.X) < TriggerRadius && Math.Abs(labels[i].Point.Y - mouse.Y) < TriggerRadius)
                {
                    var popup = new DynamicLabelPopUp();
                    popup.DynamicLabel = labels[i].Copy();
                    var result = popup.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        labels[i] = popup.DynamicLabel;
                    }

                    popup.Dispose();
                }
            }

            Labels.Clear();
            Labels = labels;

            Repaint();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Fi = (Fi + 1) % 360;
            Repaint();
        }
    }
}
