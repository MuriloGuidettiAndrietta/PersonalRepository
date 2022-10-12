namespace Figures.Model.Figures.TwoDimensionalFigures
{
    public class Rhombus : TwoDimensionalFigure
    {
        private double smallerDiagonal;
        private double biggerDiagonal;

        public double SmallerDiagonal
        {
            get { return smallerDiagonal; }
            set { smallerDiagonal = value; }
        }

        public double BiggerDiagonal
        {
            get { return biggerDiagonal; }
            set { biggerDiagonal = value; }
        }        

        public override string Name
        {
            get { return name; }
        }

        public override double Area()
        {
            return (BiggerDiagonal * SmallerDiagonal) / (2.0);
        }

        public Rhombus(double smallerDiagonal, double biggerDiagonal) : base()
        {
            BiggerDiagonal = biggerDiagonal;
            SmallerDiagonal = smallerDiagonal;
            name += "Rhombus";
        }
    }
}
