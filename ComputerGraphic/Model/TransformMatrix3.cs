namespace ComputerGraphic.Model
{
    public class TransformMatrix3 : ICloneable
    {
        public float A { get; set; }
        public float B { get; set; }
        public float C { get; set; }
        public float P { get; set; }
        public float D { get; set; }
        public float E { get; set; }
        public float F { get; set; }
        public float Q { get; set; }
        public float G { get; set; }
        public float H { get; set; }
        public float I { get; set; }
        public float R { get; set; }
        public float L { get; set; }
        public float M { get; set; }
        public float N { get; set; }
        public float S { get; set; }


        public float this[int i, int j]
        {
            get
            {
                switch (i)
                {
                    case 0:
                        switch(j)
                        {
                            case 0: return A;
                            case 1: return B;
                            case 2: return C;
                            case 3: return P;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                    case 1:
                        switch (j)
                        {
                            case 0: return D;
                            case 1: return E;
                            case 2: return F;
                            case 3: return Q;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                    case 2:
                        switch (j)
                        {
                            case 0: return G;
                            case 1: return H;
                            case 2: return I;
                            case 3: return R;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                    case 3:
                        switch (j)
                        {
                            case 0: return L;
                            case 1: return M;
                            case 2: return N;
                            case 3: return S;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }

                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                switch (i)
                {
                    case 0:
                        switch (j)
                        {
                            case 0: A = value; break;
                            case 1: B = value; break;
                            case 2: C = value; break;
                            case 3: P = value; break;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                        break;
                    case 1:
                        switch (j)
                        {
                            case 0: D = value; break;
                            case 1: E = value; break;
                            case 2: F = value; break;
                            case 3: Q = value; break;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                        break;
                    case 2:
                        switch (j)
                        {
                            case 0: G = value; break;
                            case 1: H = value; break;
                            case 2: I = value; break;
                            case 3: R = value; break;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                        break;
                    case 3:
                        switch (j)
                        {
                            case 0: L = value; break;
                            case 1: M = value; break;
                            case 2: N = value; break;
                            case 3: S = value; break;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        public TransformMatrix3()
        {
            A = 1; B = 0; C = 0; P = 0;
            D = 0; E = 1; F = 0; Q = 0;
            G = 0; H = 0; I = 1; R = 0;
            L = 0; M = 0; N = 0; S = 1;
        }

        public TransformMatrix3(float a, float b, float c, float p, 
            float d, float e, float f, float q, 
            float g, float h, float i, float r, 
            float l, float m, float n, float s)
        {
            A = a; B = b; C = c; P = p;
            D = d; E = e; F = f; Q = q;
            G = g; H = h; I = i; R = r;
            L = l; M = m; N = n; S = s;
        }

        public object Clone()
        {
            return new TransformMatrix3(
                A, B, C, P,
                D, E, F, Q,
                G, H, I, R,
                L, M, N, S);
        }
    }
}
