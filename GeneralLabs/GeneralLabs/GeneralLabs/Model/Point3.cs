namespace GeneralLabs.Model
{
    public class Point3 : IEquatable<Point3>, ICloneable
    {
        public float X { get; set; }

        public float Y { get; set; }

        public float Z { get; set; }

        public float W { get; set; }

        public float this[int index]
        {
            get
            {
                switch(index)
                {
                    case 0:
                        return X;
                    case 1:
                        return Y;
                    case 2:
                        return Z;
                    case 3:
                        return W;
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
                    case 3:
                        W = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
        }

        public Point3()
        {
            X = 0;
            Y = 0;
            Z = 0;
            W = 1;
        }

        public Point3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
            W = 1;
        }

        public Point3(float x, float y, float z, float w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        public void Unscale()
        {
            X /= W;
            Y /= W;
            Z /= W;
            W = 1;
        }

        public Point3 Transform(TransformMatrix matrix)
        {
            var point = new Point3();

            for (var i = 0; i < 4; i++)
            {
                var temp = 0f;
                for (var col = 0; col < 4; col++)
                {
                    for (var row = 0; row < 4; row++)
                    {
                        temp += this[col] * matrix[row, col];
                    }
                }
                point[i] = temp;
            }

            point.Unscale();

            return point;
        }

        public bool Equals(Point3 other)
        {
            if (this == other)
            {
                return true;
            }

            return X == other.X && Y == other.Y && Z == other.Z && W == other.W;
        }

        public object Clone()
        {
            return new Point3(X, Y, Z, W);
        }
    }
}
