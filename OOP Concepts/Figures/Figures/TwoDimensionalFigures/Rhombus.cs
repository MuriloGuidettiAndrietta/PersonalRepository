namespace Figures.Figures.TwoDimensionalFigures
{
    public class Rhombus : TwoDimensionalFigure
    {
        private double biggerDiagonal;
        private double smallerDiagonal;

        public double BiggerDiagonal
        {
            get { return biggerDiagonal; }
            set { biggerDiagonal = value; }
        }

        public double SmallerDiagonal
        {
            get { return smallerDiagonal; }
            set { smallerDiagonal = value; }
        }

        public override string Name
        {
            get { return name; }
        }

        public override double Area()
        {
            return (biggerDiagonal * smallerDiagonal) / (2.0);
        }

        public Rhombus(double smallerDiagonal, double biggerDiagonal) : base()
        {
            name += "Rhombus";
            this.biggerDiagonal = biggerDiagonal;
            this.smallerDiagonal = smallerDiagonal;
        }
    }
}
