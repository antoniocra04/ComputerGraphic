namespace ComputerGraphic.Model
{
    public class Model3
    {
        public struct VectorIndexed
        {
            public int StartIndex;
            public int EndIndex;

            public VectorIndexed()
            {
                StartIndex = 0;
                EndIndex = 0;
            }

            public VectorIndexed(int startIndex, int endIndex)
            {
                StartIndex = startIndex;
                EndIndex = endIndex;
            }

            public int this[int index]
            {
                get
                {
                    switch (index)
                    {
                        case 0:
                            return StartIndex;
                        case 1:
                            return EndIndex;
                        default:
                            throw new IndexOutOfRangeException();
                    }
                }
                set
                {
                    switch (index)
                    {
                        case 0:
                            StartIndex = value;
                            break;
                        case 1:
                            EndIndex = value;
                            break;
                        default:
                            throw new IndexOutOfRangeException();
                    }
                }
            }
        }

        public List<Point3> Points { get; set; }
        public List<VectorIndexed> Vectors { get; set; }

        public Model3()
        {
            Points = new List<Point3>();
            Vectors = new List<VectorIndexed>();
        }

        public Vector3 GetVectorFromIndex(int index)
        {
            return new Vector3(
                Points[Vectors[index].StartIndex],
                Points[Vectors[index].EndIndex]);
        }

        public Model3 Transform(TransformMatrix3 matrix)
        {
            var model = new Model3();
            model.Vectors = Vectors;

            foreach (var point in Points)
            {
                model.Points.Add(point.Transform(matrix));
            }

            return model;
        }
    }
}
