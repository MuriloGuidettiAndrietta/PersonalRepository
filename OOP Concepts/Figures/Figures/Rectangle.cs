namespace Figures.Figures
{
    public class Rectangle : Figure
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
            return width * height; 
        }

        public Rectangle(double width, double height) : base()
        {
            name += "Rectangle";
            this.width = width;
            this.height = height;
        }
    }
}
