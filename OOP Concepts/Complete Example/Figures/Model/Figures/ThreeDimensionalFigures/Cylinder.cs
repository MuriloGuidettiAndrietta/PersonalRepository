namespace Figures.Model.Figures.ThreeDimensionalFigures
{
    public class Cylinder : ThreeDimensionalFigure
    {
        private double radius;
        private double height;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public override string Name
        {
            get { return name; }
        }

        public override double Volume()
        {
            return Math.PI * Math.Pow(Radius, 2) * Height;
        }

        public Cylinder(double radius, double height) : base()
        {
            Radius = radius;
            Height = height;    
            name += "Cylinder";
        }
    }
}
