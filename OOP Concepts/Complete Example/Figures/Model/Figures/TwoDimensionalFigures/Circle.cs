namespace Figures.Model.Figures.TwoDimensionalFigures
{
    public class Circle : TwoDimensionalFigure
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

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2.0);
        }

        public Circle(double radius) : base()
        {
            Radius = radius;
            name += "Circle";            
        }
    }
}
