namespace ComputerGraphic.Model
{
    /// <summary>
    /// Хранит данные о матрице преобразования.
    /// </summary>
    public class TransformMatrix
    {
        public double A;
        public double B;
        public double C;
        public double D;
        public double P;
        public double Q;
        public double M;
        public double N;
        public double S;


        /// <summary>
        /// Возвращает или задает элемент матрицы преобразования.
        /// </summary>
        /// <param name="i">Ряд.</param>
        /// <param name="j">Столбец.</param>
        /// <returns>Элемент матрицы преобразования.</returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public double this[int i, int j]
        {
            get
            {
                switch (i)
                {
                    case 0:
                        switch(j)
                        {
                            case 0:
                                return A;
                            case 1:
                                return B;
                            case 2:
                                return P;
                            default:
                                throw new IndexOutOfRangeException();
                        }
                    case 1:
                        switch (j)
                        {
                            case 0:
                                return C;
                            case 1:
                                return D;
                            case 2:
                                return Q;
                            default:
                                throw new IndexOutOfRangeException();
                        }
                    case 2:
                        switch (j)
                        {
                            case 0:
                                return M;
                            case 1:
                                return N;
                            case 2:
                                return S;
                            default:
                                throw new IndexOutOfRangeException();
                        }
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
            set
            {
                switch (i)
                {
                    case 0:
                        switch (j)
                        {
                            case 0:
                                A = value;
                                break;
                            case 1:
                                B = value;
                                break;
                            case 2:
                                P = value;
                                break;
                            default:
                                throw new IndexOutOfRangeException();
                        }
                        break;
                    case 1:
                        switch (j)
                        {
                            case 0:
                                C = value;
                                break;
                            case 1:
                                D = value;
                                break;
                            case 2:
                                Q = value;
                                break;
                            default:
                                throw new IndexOutOfRangeException();
                        }
                        break;
                    case 2:
                        switch (j)
                        {
                            case 0:
                                M = value;
                                break;
                            case 1:
                                N = value;
                                break;
                            case 2:
                                S = value;
                                break;
                            default:
                                throw new IndexOutOfRangeException();
                        }
                        break;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
        }

        /// <summary>
        /// Создает единичную матрицу преобразования.
        /// </summary>
        public TransformMatrix()
        {
            A = 1; B = 0; P = 0;
            C = 0; D = 1; Q = 0;
            M = 0; N = 0; S = 1;
        }

        /// <summary>
        /// Создает матрицу преобразования.
        /// </summary>
        public TransformMatrix(
            double a, double b, double p, 
            double c, double d, double q, 
            double m, double n, double s)
        {
            A = a; B = b; P = p;
            C = c; D = d; Q = q;
            M = m; N = n; S = s;
        }

        public TransformMatrix Copy()
        {
            return new TransformMatrix(A, B, P, C, D, Q, M, N, S);
        }
    } 
}
