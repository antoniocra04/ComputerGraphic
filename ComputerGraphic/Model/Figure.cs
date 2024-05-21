namespace ComputerGraphic.Model
{
    public class Figure
    {
        public List<Vector3> Vectors;

        public Figure()
        {
            var cubePen = new Pen(Color.Black, 5);
            var xPen = new Pen(Color.Red, 2);
            var yPen = new Pen(Color.Green, 2);
            var zPen = new Pen(Color.Blue, 2);

            Vectors = new List<Vector3>();
            Vectors.Add(new Vector3(0, 0, 0, 1, 0, 0, xPen));
            Vectors.Add(new Vector3(0, 0, 0, 0, 1, 0, yPen));
            Vectors.Add(new Vector3(0, 0, 0, 0, 0, 1, zPen));

            Vectors.Add(new Vector3(1, -1, -1, 1, 1, -1, cubePen));
            Vectors.Add(new Vector3(-1, -1, -1, -1, 1, -1, cubePen));
            Vectors.Add(new Vector3(-1, -1, -1, 1, -1, -1, cubePen));
            Vectors.Add(new Vector3(-1, 1, -1, 1, 1, -1, cubePen));

            Vectors.Add(new Vector3(1, -1, 1, 1, 1, 1, cubePen));
            Vectors.Add(new Vector3(-1, -1, 1, -1, 1, 1, cubePen));
            Vectors.Add(new Vector3(-1, -1, 1, 1, -1, 1, cubePen));
            Vectors.Add(new Vector3(-1, 1, 1, 1, 1, 1, cubePen));

            Vectors.Add(new Vector3(1, 1, -1, 1, 1, 1, cubePen));
            Vectors.Add(new Vector3(-1, -1, -1, -1, -1, 1, cubePen));
            Vectors.Add(new Vector3(1, -1, -1, 1, -1, 1, cubePen));
            Vectors.Add(new Vector3(-1, 1, -1, -1, 1, 1, cubePen));
        }

        public Figure(List<Vector3> vectors)
        {
            Vectors = vectors;
        }

        public Figure Transform(TransformMatrix3 matrix)
        {
            var vectors = new List<Vector3>();

            foreach (var vector in Vectors)
            {
                vectors.Add(vector.Transform(matrix));
            }

            return new Figure(vectors);
        }
    }
}
