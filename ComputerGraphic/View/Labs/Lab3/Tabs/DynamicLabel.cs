using ComputerGraphic.Model;
using System;

namespace ComputerGraphic.View.Labs.Lab3.Tabs
{
    public class DynamicLabel
    {
        const int DefaultFontSize = 30;

        public Point2 Point { get; set; }
        public string Text { get; set; }
        public double Speed { get; set; }
        public List<Color> Colors { get; set; }
        public int FontSize { get; set; }
        public bool IsRandomColor { get; set; } = true;


        public DynamicLabel() 
        {
            Point = new Point2();
            Text = string.Empty;
            Speed = 1.0;
            FontSize = DefaultFontSize;
            Colors = new List<Color>();
        }

        public DynamicLabel(Point2 point, string text)
        {
            Point = point;
            Text = text;
            Speed = 1.0;
            FontSize = DefaultFontSize;
            Colors = new List<Color>();
        }

        public DynamicLabel(double x, double y, string text)
        {
            Point = new Point2(x, y);
            Text = text;
            Speed = 1.0;
            FontSize = DefaultFontSize;
            Colors = new List<Color>();
        }

        public DynamicLabel(Point2 point, string text, double speed, int fontSize, bool isRandomColor, List<Color> colors)
        {
            Point = point;
            Text = text;
            Speed = speed;
            FontSize = fontSize;
            Colors = colors;
            IsRandomColor = isRandomColor;
        }

        public DynamicLabel(double x, double y, string text, double speed, int fontSize, bool isRandomColor, List<Color> colors)
        {
            Point = new Point2(x, y);
            Text = text;
            Speed = speed;
            FontSize = fontSize;
            Colors = colors;
            IsRandomColor = isRandomColor;
        }

        public void SetRandomColors()
        {
            Colors.Clear();
            var random = new Random();
            foreach(var ch in Text)
            {
                Colors.Add(Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)));
            }
        }

        public void SetColors(Color color)
        {
            Colors.Clear();
            foreach (var ch in Text)
            {
                Colors.Add(color);
            }
        }

        public DynamicLabel Copy()
        {
            var colors = new List<Color>();

            foreach (var color in Colors)
            {
                colors.Add(color);
            }

            return new DynamicLabel(Point, Text, Speed, FontSize, IsRandomColor, colors);
        }
    }
}
