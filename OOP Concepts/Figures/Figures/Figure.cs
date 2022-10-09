namespace Figures.Figures
{
    public abstract class Figure
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
