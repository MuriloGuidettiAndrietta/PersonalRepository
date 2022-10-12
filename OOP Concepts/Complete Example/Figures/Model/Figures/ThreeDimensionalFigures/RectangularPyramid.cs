namespace Figures.Model.Figures.ThreeDimensionalFigures
{
    public class RectangularPyramid : ThreeDimensionalFigure
    {
        private double width;
        private double height;
        private double length;       

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

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public override string Name
        {
            get { return name; }
        }

        public override double Volume()
        {
            return (1.0 / 3.0) * Length * Width * Height;
        }

        public RectangularPyramid(double width, double height, double length) : base()
        {
            Width = width;
            Height = height;
            Length = length;
            name += "Rectangular Pyramid";
        }
    }
}
