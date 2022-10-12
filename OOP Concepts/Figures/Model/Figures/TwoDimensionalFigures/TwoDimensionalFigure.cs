using Figures.Utilities.Interfaces;

namespace Figures.Model.Figures.TwoDimensionalFigures
{
    public abstract class TwoDimensionalFigure : Figure, IArea
    {
        public abstract double Area();
        public TwoDimensionalFigure() : base()
        {
        }
    }
}
