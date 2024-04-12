namespace ComputerGraphic.Model
{
    public class Point2 
    {
        private double _x;
        private double _y;
        private double _z = 1.0;

        public double X
        {
            get
            {
                if (Z != 1.0)
                {
                    _x /= Z;
                    _y /= Z;
                }
                Z = 1.0;
                return _x;
            }
            set => _x = value;
        }
        public double Y
        {
            get
            {
                if (Z != 1.0)
                {
                    _x /= Z;
                    _y /= Z;
                }
                Z = 1.0;
                return _y;
            }
            set => _y = value;
        }
        public double Z
        {
            get => _z;
            set => _z = value;
        }

        public double this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return X;
                    case 1:
                        return Y;
                    case 2:
                        return Z;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        X = value;
                        break;
                    case 1:
                        Y = value;
                        break;
                    case 2:
                        Z = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
        }

        public Point2()
        {
            X = 0;
            Y = 0;
        }

        public Point2(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Point2(Point2 point)
        {
            X = point.X;
            Y = point.Y;
        }

        public static Point2 operator +(Point2 a, Point2 b)
        {
            return new Point2(a.X + b.X, a.Y + b.Y);
        }

        public static Point2 operator -(Point2 a, Point2 b)
        {
            return new Point2(a.X - b.X, a.Y - b.Y);
        }

        public static Point2 operator *(Point2 vector, int k)
        {
            return new Point2(vector.X * k, vector.Y * k);
        }

        public static Point2 operator /(Point2 vector, int k)
        {
            return new Point2(vector.X / k, vector.Y / k);
        }

        public Point2 Copy()
        {
            return new Point2(X, Y);
        }

        public Point2 Transform(TransformMatrix matrix)
        {
            var point = new Point2();

            for (int i = 0; i < 3; i++)
            {
                point[i] = 0;
                for (int j = 0; j < 3; j++)
                {
                    point[i] += this[j] * matrix[j, i];
                }
            }

            return point;
        }

        public double Distance(Point2 other)
        {
            return Math.Sqrt((X - other.X) * (X - other.X) + (Y - other.Y) * (Y - other.Y));
        }
    }
}
