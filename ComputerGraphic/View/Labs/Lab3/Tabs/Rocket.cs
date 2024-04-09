using ComputerGraphic.Model;

namespace ComputerGraphic.View.Labs.Lab3.Tabs
{
    public struct Rocket
    {
        public List<Point2> Body { get; set; }
        public List<Point2> Bow { get; set; }
        public List<Point2> LeftWing { get; set; }
        public List<Point2> RightWing { get; set; }
        public List<Point2> Fire { get; set; }
        public Point2 Porthole { get; set; }
        public double PortholeRadius { get; set; }

        public Rocket()
        {
            Body = new List<Point2>();
            Body.Add(new Point2(-20, -50));
            Body.Add(new Point2(20, -50));
            Body.Add(new Point2(20, 50));
            Body.Add(new Point2(-20, 50));

            Bow = new List<Point2>();
            Bow.Add(new Point2(-20, -50));
            Bow.Add(new Point2(0, -70));
            Bow.Add(new Point2(20, -50));

            LeftWing = new List<Point2>();
            LeftWing.Add(new Point2(-20, -30));
            LeftWing.Add(new Point2(-20, 10));
            LeftWing.Add(new Point2(-50, 10));

            RightWing = new List<Point2>();
            RightWing.Add(new Point2(20, -30));
            RightWing.Add(new Point2(20, 10));
            RightWing.Add(new Point2(50, 10));

            Fire = new List<Point2>();
            Fire.Add(new Point2(-20, 50));
            Fire.Add(new Point2(20, 50));
            Fire.Add(new Point2(20, 70));
            Fire.Add(new Point2(10, 60));
            Fire.Add(new Point2(0, 70));
            Fire.Add(new Point2(-10, 60));
            Fire.Add(new Point2(-20, 70));

            Porthole = new Point2(0, -20);
            PortholeRadius = 10;
        }

        public Rocket(
            List<Point2> body, 
            List<Point2> bow, 
            List<Point2> leftWing, 
            List<Point2> rightWing,
            List<Point2> fire,
            Point2 porthole, 
            double radius)
        {
            Body = body;
            Bow = bow;
            LeftWing = leftWing;
            RightWing = rightWing;
            Fire = fire;
            Porthole = porthole;
            PortholeRadius= radius;
        }

        public Rocket Transform(TransformMatrix matrix, double portholeScale)
        {
            var body = new List<Point2>();
            var bow = new List<Point2>();
            var leftWing = new List<Point2>();
            var rightWing = new List<Point2>();
            var fire = new List<Point2>();  
            var porthole = Porthole.Transform(matrix);
            var portholeRadius = PortholeRadius * portholeScale;

            foreach (var b in Body)
            {
                body.Add(b.Transform(matrix));
            }

            foreach (var b in Bow)
            {
                bow.Add(b.Transform(matrix));
            }

            foreach (var wing in LeftWing)
            {
                leftWing.Add(wing.Transform(matrix));
            }

            foreach (var wing in RightWing)
            {
                rightWing.Add(wing.Transform(matrix));
            }

            foreach(var f in Fire)
            {
                fire.Add(f.Transform(matrix));
            }

            return new Rocket(body, bow, leftWing, rightWing, fire, porthole, portholeRadius);
        }
    }
}
