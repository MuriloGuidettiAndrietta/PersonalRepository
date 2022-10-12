using Figures.View;
using Figures.Model;
using Figures.Model.Figures;
using Figures.Model.Figures.TwoDimensionalFigures;
using Figures.Model.Figures.ThreeDimensionalFigures;
using Figures.Utilities.UserOptions;

try
{
    List<Figure> figures = new List<Figure>();
    do
    {
        Enum figureOption;
        List<double> figureParameters = new List<double>();
        UserInput.GetUserInput(out figureOption, ref figureParameters);
        DataValidation.ValidateFigureParameters(figureParameters);

        // MAYBE CREATE A METHOD HERE************************************************ 
        switch (figureOption)
        {
            case TwoDimensionalFigureOptions.Square: { figures.Add(new Square(figureParameters.First())); break; }
            case TwoDimensionalFigureOptions.Rectangle: { figures.Add(new Rectangle(figureParameters.First(), figureParameters[1])); break; }
            case TwoDimensionalFigureOptions.Triangle: { figures.Add(new Triangle(figureParameters.First(), figureParameters[1])); break; }
            case TwoDimensionalFigureOptions.Circle: { figures.Add(new Circle(figureParameters.First())); break; }
            case TwoDimensionalFigureOptions.Trapeze: { figures.Add(new Trapeze(figureParameters.First(), figureParameters[1], figureParameters[2])); break; }
            case TwoDimensionalFigureOptions.Rhombus: { figures.Add(new Rhombus(figureParameters.First(), figureParameters[1])); break; }
            case ThreeDimensionalFigureOptions.Cube: { figures.Add(new Cube(figureParameters.First())); break; }
            case ThreeDimensionalFigureOptions.RectangularPrism: { figures.Add(new RectangularPrism(figureParameters.First(), figureParameters[1], figureParameters[2])); break; }
            case ThreeDimensionalFigureOptions.RectangularPyramid: { figures.Add(new RectangularPyramid(figureParameters.First(), figureParameters[1], figureParameters[2])); break; }
            case ThreeDimensionalFigureOptions.Cylinder: { figures.Add(new Cylinder(figureParameters.First(), figureParameters[1])); break; }
            case ThreeDimensionalFigureOptions.Sphere: { figures.Add(new Sphere(figureParameters.First())); break; }
            default: { break; }
        }
    } while (UserInput.KeepRunning());

    // MAYBE CREATE A METHOD HERE************************************************
    List<string> names = new List<string>();
    List<double> areas = new List<double>();
    List<double> volumes = new List<double>();
    foreach (var f in figures)
    {
        names.Add(f.Name);
        if (f is TwoDimensionalFigure)
        {
            areas.Add(((TwoDimensionalFigure)f).Area());
            volumes.Add(0.0);
        }
        else
        {
            areas.Add(0.0);
            volumes.Add(((ThreeDimensionalFigure)f).Volume());
        }
    }
    UserInput.FinalSummary(names, areas, volumes);
}
catch (Exception ex)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red; 
    Console.WriteLine("\n   ATTENTION");
    Console.WriteLine("\n   There's an issue on the application.");
    Console.WriteLine("\n   Here is the error message returned:");
    Console.WriteLine("\n\t" + ex.Message);
    Console.WriteLine("\n   And here is the whole stack trace with more details:");
    Console.WriteLine("\n" + ex.StackTrace);
}
Console.ReadKey();





