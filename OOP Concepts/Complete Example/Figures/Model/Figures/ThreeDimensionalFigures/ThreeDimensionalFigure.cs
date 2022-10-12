using Figures.Utilities.Interfaces;

namespace Figures.Model.Figures.ThreeDimensionalFigures
{
    public abstract class ThreeDimensionalFigure : Figure, IVolume
    {
        public abstract double Volume();
        public ThreeDimensionalFigure() : base()
        {
        }
    }
}
