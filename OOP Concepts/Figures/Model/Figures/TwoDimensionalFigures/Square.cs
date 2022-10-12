namespace Figures.Model.Figures.TwoDimensionalFigures
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
            return Math.Pow(Side,2);
        }

        public Square(double side) : base()
        {
            Side = side;
            name += "Square";            
        }
    }
}
