using Figures.Utilities.Interfaces;

namespace Figures.Model.Figures
{
    public abstract class Figure : INaming
    {
        protected string name;

        public abstract string Name
        {
            get;
        }
        protected Figure()
        {
            name = string.Empty;
        }
    }
}
