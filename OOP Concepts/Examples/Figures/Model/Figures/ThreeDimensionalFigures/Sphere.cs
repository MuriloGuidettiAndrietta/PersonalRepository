namespace Figures.Model.Figures.ThreeDimensionalFigures
{
    public class Sphere : ThreeDimensionalFigure
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public override string Name
        {
            get { return name; }
        }

        public override double Volume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
        }

        public Sphere(double radius) : base()
        {
            Radius = radius;
            name += "Sphere";
        }
    }
}
