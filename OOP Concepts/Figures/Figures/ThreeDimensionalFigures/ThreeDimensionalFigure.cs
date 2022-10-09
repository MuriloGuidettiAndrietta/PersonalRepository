using Figures.Interfaces;

namespace Figures.Figures.ThreeDimensionalFigures
{
    public abstract class ThreeDimensionalFigure : Figure, IVolume
    {
       public abstract double Volume();
    }
}
