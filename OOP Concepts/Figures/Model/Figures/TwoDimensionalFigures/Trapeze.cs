namespace Figures.Model.Figures.TwoDimensionalFigures
{
    public class Trapeze : TwoDimensionalFigure
    {
        private double smallerBase;
        private double biggerBase;
        private double height;

        public double SmallerBase
        {
            get { return smallerBase; }
            set { smallerBase = value; }
        }

        public double BiggerBase
        {
            get { return biggerBase; }
            set { biggerBase = value; }
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

        public override double Area()
        {
            return ((SmallerBase + BiggerBase) * Height) / (2.0);
        }

        public Trapeze(double smallerBase, double biggerBase, double height) : base()
        {
            SmallerBase = smallerBase;
            BiggerBase = biggerBase;
            Height = height;
            name += "Trapeze";
        }
    }
}
