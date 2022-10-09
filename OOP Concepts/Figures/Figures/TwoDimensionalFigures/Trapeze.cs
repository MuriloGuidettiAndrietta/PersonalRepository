namespace Figures.Figures.TwoDimensionalFigures
{
    public class Trapeze : TwoDimensionalFigure
    {
        private double smallerBase;
        private double higherBase;
        private double height;

        public double SmallerBase
        {
            get { return smallerBase; }
            set { smallerBase = value; }
        }

        public double HigherBase
        {
            get { return higherBase; }
            set { higherBase = value; }
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
            return ((smallerBase + higherBase) * height) / (2.0);
        }

        public Trapeze(double smallerBase, double higherBase, double height) : base()
        {
            name += "Trapeze";
            this.smallerBase = smallerBase;
            this.higherBase = higherBase;
            this.height = height;
        }
    }
}
