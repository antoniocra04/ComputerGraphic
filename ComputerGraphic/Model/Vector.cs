using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGraphic.Model
{
    public class Vector
    {
        public Point Start { get; set; }
        public Point End { get; set; }

        public double SlopeCoefficient
        {
            get
            {
                return (double)(End.Y - Start.Y) / (End.X - Start.X);
            }
        }

        public Vector()
        {
            Start = new Point(0, 0);
            End = new Point(0, 0);
        }

        public Vector(int startX, int startY, int endX, int endY)
        {
            Start = new Point(startX, startY);
            End = new Point(endX, endY);
        }

        public Vector(Point start, Point end) 
        {
            Start = start;
            End = end;  
        }

        public Vector GetScaled(double scaleX, double scaleY)
        {
            var startX = (int)(Start.X * scaleX);
            var startY = (int)(Start.Y * scaleY);
            var EndX = (int)(End.X * scaleX);
            var EndY = (int)(End.Y * scaleY);
            return new Vector(new Point(startX, startY), new Point(EndX, EndY));
        }

        public bool Consider(Point point)
        {
            return Consider(point.X, point.Y);
        }

        public bool Consider(int x, int y)
        {
            return ((Start.X <= x && x <= End.X) || (End.X <= x && x <= Start.X)) &&
                ((Start.Y <= y && y <= End.Y) || (End.Y <= y && y <= Start.Y));
        }

        public Vector Clone()
        {
            return new Vector(Start.X, Start.Y, End.X, End.Y);
        }
    }
}
