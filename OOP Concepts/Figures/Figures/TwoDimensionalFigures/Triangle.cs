namespace Figures.Figures.TwoDimensionalFigures
{
    public class Triangle : TwoDimensionalFigure
    {
        private double width;
        private double height;

        public double Width
        {
            get { return width; }
            set { width = value; }
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
            return width * height / 2.0;
        }

        public Triangle(double width, double height) : base()
        {
            name += "Triangle";
            this.width = width;
            this.height = height;
        }
    }
}
