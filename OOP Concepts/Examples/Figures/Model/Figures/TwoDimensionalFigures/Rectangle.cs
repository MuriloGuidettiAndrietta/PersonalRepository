namespace Figures.Model.Figures.TwoDimensionalFigures
{
    public class Rectangle : TwoDimensionalFigure
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
            return Width * Height;
        }

        public Rectangle(double width, double height) : base()
        {
            Width = width;
            Height = height;
            name += "Rectangle";            
        }
    }
}
