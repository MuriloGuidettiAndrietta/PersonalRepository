using Figures.Utilities.Interfaces;
using Figures.View;
using Figures.Model;
using Figures.Model.Figures;
using Figures.Model.Figures.TwoDimensionalFigures;
using Figures.Model.Figures.ThreeDimensionalFigures;

try
{
    Enum figureOption;
    List<double> parameterList = new List<double>();
    UserInput.GetUserInput(out figureOption, ref parameterList);
    
    DataValidation.ValidateParameters(parameterList);

    List<Figure> figures = new List<Figure>();
    switch (figureOption)
    {
        case TwoDimensionalFigureOptions.Square: { figures.Add(new Square(parameterList.First())); break; }
        case TwoDimensionalFigureOptions.Rectangle: { figures.Add(new Rectangle(parameterList.First(), parameterList[1])); break; }
        case TwoDimensionalFigureOptions.Triangle: { figures.Add(new Triangle(parameterList.First(), parameterList[1])); break; }
        case TwoDimensionalFigureOptions.Circle: { figures.Add(new Circle(parameterList.First())); break; }
        case TwoDimensionalFigureOptions.Trapeze: { figures.Add(new Trapeze(parameterList.First(), parameterList[1], parameterList[2])); break; }
        case TwoDimensionalFigureOptions.Rhombus: { figures.Add(new Rhombus(parameterList.First(), parameterList[1])); break; }
        case ThreeDimensionalFigureOptions.Cube: { figures.Add(new Cube(parameterList.First())); break; }
        case ThreeDimensionalFigureOptions.RectangularPrism: { figures.Add(new RectangularPrism(parameterList.First(), parameterList[1], parameterList[2])); break; }
        case ThreeDimensionalFigureOptions.RectangularPyramid: { figures.Add(new RectangularPyramid(parameterList.First(), parameterList[1], parameterList[2])); break; }
        case ThreeDimensionalFigureOptions.Cylinder: { figures.Add(new Cylinder(parameterList.First(), parameterList[1])); break; }
        case ThreeDimensionalFigureOptions.Sphere: { figures.Add(new Sphere(parameterList.First())); break; }
        default: { break; }
    }

    foreach(var f in figures)
    {
        Console.Write("\n\t\tFigure: " + f.Name + "   -    ");
        if (f is TwoDimensionalFigure)
            Console.WriteLine("Area: " + ((TwoDimensionalFigure)f).Area());
        else
            Console.WriteLine("Volume: " + ((ThreeDimensionalFigure)f).Volume());
    }
}
catch(Exception ex)
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





