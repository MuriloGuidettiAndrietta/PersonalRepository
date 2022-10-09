using Figures.Interfaces;

namespace Figures.Figures
{
    public abstract class Figure : INaming, IArea
    {
        protected string name;

        public abstract string Name
        {
            get;
        }

        public abstract double Area();

        protected Figure()
        {
            name = string.Empty;
        }
    }
}
