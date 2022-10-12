namespace Figures.Model.Figures.ThreeDimensionalFigures
{
    public class Cube : ThreeDimensionalFigure
    {
        private double side;

        public double Side
        {
            get { return side; }
            set { side = value; }
        }

        public override string Name
        {
            get { return name; }
        }

        public override double Volume()
        {
            return Math.Pow(Side, 3);
        }

        public Cube(double side) : base()
        {
            Side = side;
            name += "Cube";
        }
    }
}
