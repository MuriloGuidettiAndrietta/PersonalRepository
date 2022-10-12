using Figures.Utilities.Interfaces;

namespace Figures.View
{
    public static class UserInput
    {
        public static Enum GetUserInput(out Enum figureOption, ref List<double> parameterList)
        {
            try
            {
                int typeOfFigureOption;
                do
                {
                    Console.Clear();
                    Console.WriteLine("\n\tFigures\n");
                    Console.WriteLine("\t\t1 - Two Dimensional Figure");
                    Console.WriteLine("\t\t2 - Three Dimensional Figure");
                    Console.Write("\n\t\tChoose one type of Figure: ");
                    typeOfFigureOption = Convert.ToByte(Console.ReadLine());
                } while (typeOfFigureOption != 1 && typeOfFigureOption != 2);

                if (typeOfFigureOption == 1)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("\n\tTwo Dimensional Figures\n");
                        Console.WriteLine("\t\t1 - Square");
                        Console.WriteLine("\t\t2 - Rectangle");
                        Console.WriteLine("\t\t3 - Triangle");
                        Console.WriteLine("\t\t4 - Circle");
                        Console.WriteLine("\t\t5 - Trapeze");
                        Console.WriteLine("\t\t6 - Rhombus");

                        Console.Write("\n\t\tChoose one two dimensional Figure: ");
                        figureOption = (TwoDimensionalFigureOptions)Convert.ToInt32(Console.ReadLine());

                    } while (!Enum.IsDefined(typeof(TwoDimensionalFigureOptions), figureOption));
                }
                else
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("\n\tThree Dimensional Figures\n");
                        Console.WriteLine("\t\t1 - Cube");
                        Console.WriteLine("\t\t2 - Rectangular Prism");
                        Console.WriteLine("\t\t3 - Rectangular Pyramid");
                        Console.WriteLine("\t\t4 - Cylinder");
                        Console.WriteLine("\t\t5 - Sphere");

                        Console.Write("\n\t\tChoose one three dimensional Figure: ");
                        figureOption = (ThreeDimensionalFigureOptions)(Convert.ToInt32(Console.ReadLine()) + 6); // 6 is needed to "continue" counting from the last 2D Figure Option.
                    } while (!Enum.IsDefined(typeof(ThreeDimensionalFigureOptions), figureOption));
                }

                Console.WriteLine("\n\t\tInform the Parameter(s) below:");
                switch (figureOption)
                {
                    case TwoDimensionalFigureOptions.Square:
                        {
                            Console.Write("\t\t\tSide: ");
                            parameterList.Add(Convert.ToDouble(Console.ReadLine()));
                            break;
                        }
                    case TwoDimensionalFigureOptions.Rectangle:
                        {
                            Console.Write("\t\t\tWidth: ");
                            parameterList.Add(Convert.ToDouble(Console.ReadLine()));
                            Console.Write("\t\t\tHeight: ");
                            parameterList.Add(Convert.ToDouble(Console.ReadLine()));
                            break;
                        }
                    case TwoDimensionalFigureOptions.Triangle:
                        {
                            Console.Write("\t\t\tWidth: ");
                            parameterList.Add(Convert.ToDouble(Console.ReadLine()));
                            Console.Write("\t\t\tHeight: ");
                            parameterList.Add(Convert.ToDouble(Console.ReadLine()));
                            break;
                        }
                    case TwoDimensionalFigureOptions.Circle:
                        {
                            Console.Write("\t\t\tRadius: ");
                            parameterList.Add(Convert.ToDouble(Console.ReadLine()));
                            break;
                        }
                    case TwoDimensionalFigureOptions.Trapeze:
                        {
                            Console.Write("\t\t\tSmaller Base: ");
                            parameterList.Add(Convert.ToDouble(Console.ReadLine()));
                            Console.Write("\t\t\tBigger Base: ");
                            parameterList.Add(Convert.ToDouble(Console.ReadLine()));
                            Console.Write("\t\t\tHeight: ");
                            parameterList.Add(Convert.ToDouble(Console.ReadLine()));
                            break;
                        }
                    case TwoDimensionalFigureOptions.Rhombus:
                        {
                            Console.Write("\t\t\tSmaller Diagonal: ");
                            parameterList.Add(Convert.ToDouble(Console.ReadLine()));
                            Console.Write("\t\t\tBigger Diagonal: ");
                            parameterList.Add(Convert.ToDouble(Console.ReadLine()));
                            break;
                        }
                    case ThreeDimensionalFigureOptions.Cube:
                        {
                            Console.Write("\t\t\tSide: ");
                            parameterList.Add(Convert.ToDouble(Console.ReadLine()));
                            break;
                        }
                    case ThreeDimensionalFigureOptions.RectangularPrism:
                        {
                            Console.Write("\t\t\tWidth: ");
                            parameterList.Add(Convert.ToDouble(Console.ReadLine()));
                            Console.Write("\t\t\tHeight: ");
                            parameterList.Add(Convert.ToDouble(Console.ReadLine()));
                            Console.Write("\t\t\tLength: ");
                            parameterList.Add(Convert.ToDouble(Console.ReadLine()));
                            break;
                        }
                    case ThreeDimensionalFigureOptions.RectangularPyramid:
                        {
                            Console.Write("\t\t\tWidth: ");
                            parameterList.Add(Convert.ToDouble(Console.ReadLine()));
                            Console.Write("\t\t\tHeight: ");
                            parameterList.Add(Convert.ToDouble(Console.ReadLine()));
                            Console.Write("\t\t\tLength: ");
                            parameterList.Add(Convert.ToDouble(Console.ReadLine()));
                            break;
                        }
                    case ThreeDimensionalFigureOptions.Cylinder:
                        {
                            Console.Write("\t\t\tRadius: ");
                            parameterList.Add(Convert.ToDouble(Console.ReadLine()));
                            Console.Write("\t\t\tHeight: ");
                            parameterList.Add(Convert.ToDouble(Console.ReadLine()));
                            break;
                        }
                    case ThreeDimensionalFigureOptions.Sphere:
                        {
                            Console.Write("\t\t\tRadius: ");
                            parameterList.Add(Convert.ToDouble(Console.ReadLine()));
                            break;
                        }
                    default: { break; }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return figureOption;
        }
    }
}
