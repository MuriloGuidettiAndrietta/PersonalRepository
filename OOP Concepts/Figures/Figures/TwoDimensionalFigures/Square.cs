namespace Figures.Figures.TwoDimensionalFigures
{
    public class Square : TwoDimensionalFigure
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

        public override double Area()
        {
            return Math.Pow(side,2);
        }

        public Square(double side) : base()
        {
            name += "Square";
            this.side = side;
        }
    }
}
