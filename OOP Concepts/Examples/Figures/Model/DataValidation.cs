namespace Figures.Model
{
    public static class DataValidation
    {
        public static void ValidateFigureParameters(List<double> input)
        {
            foreach (var i in input)
            {
                if (i <= 0.0)
                    throw new Exception("No Parameter can be negative.");
            }
        }
    }
}
