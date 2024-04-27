namespace GeneralLabs.Model
{
    public class Cube
    {
        public List<Vector3> Vectors;

        public Cube()
        {
            Vectors = new List<Vector3>();
            Vectors.Add(new Vector3(1, -1, -1, 1, 1, -1));
            Vectors.Add(new Vector3(-1, -1, -1, -1, 1, -1));
            Vectors.Add(new Vector3(-1, -1, -1, 1, -1, -1));
            Vectors.Add(new Vector3(-1, 1, -1, 1, 1, -1));

            Vectors.Add(new Vector3(1, -1, 1, 1, 1, 1));
            Vectors.Add(new Vector3(-1, -1, 1, -1, 1, 1));
            Vectors.Add(new Vector3(-1, -1, 1, 1, -1, 1));
            Vectors.Add(new Vector3(-1, 1, 1, 1, 1, 1));

            Vectors.Add(new Vector3(1, 1, -1, 1, 1, 1));
            Vectors.Add(new Vector3(-1, -1, -1, -1, -1, 1));
            Vectors.Add(new Vector3(1, -1, -1, 1, -1, 1));
            Vectors.Add(new Vector3(-1, 1, -1, -1, 1, 1));
        }

        public Cube(List<Vector3> vectors)
        {
            Vectors = vectors;
        }

        public Cube Transform(TransformMatrix matrix)
        {
            var vectors = new List<Vector3>();

            foreach (var vector in Vectors)
            {
                vectors.Add(vector.Transform(matrix));
            }

            return new Cube(vectors);
        }
    }
}
