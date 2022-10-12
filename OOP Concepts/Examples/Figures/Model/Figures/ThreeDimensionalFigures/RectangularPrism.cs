namespace Figures.Model.Figures.ThreeDimensionalFigures
{
    public class RectangularPrism : ThreeDimensionalFigure
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
            return Length * Width * Height; 
        }

        public RectangularPrism(double width, double height, double length) : base()
        {
            Width = width;
            Height = height;
            Length = length;
            name += "Rectangular Prism";
        }
    }
}
