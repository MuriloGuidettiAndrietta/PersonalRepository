﻿using Figures.Utilities.Constants;
using Figures.Utilities.UserOptions;

namespace Figures.View
{
    public static class UserInput
    {
        public static byte GetFigureType()
        {
            try
            {
                byte figureType;
                do
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\tFigures\n");
                    Console.WriteLine("\t\t1 - Two Dimensional Figure");
                    Console.WriteLine("\t\t2 - Three Dimensional Figure");
                    Console.Write("\n\t\tChoose one type of Figure: ");
                    figureType = Convert.ToByte(Console.ReadLine());
                } while (figureType != 1 && figureType != 2);
                return figureType;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Enum GetFigureOption(byte figureType)
        {
            try
            {
                Enum figureOption;
                if (figureType == 1)
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

                return figureOption;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<double> GetFigureParameters(Enum figureOption)
        {
            try
            {
                List<double> figureParameters = new List<double>();
                Console.WriteLine("\n\t\tInform the Parameter(s) below:");
                switch (figureOption)
                {
                    case TwoDimensionalFigureOptions.Square:
                        {
                            Console.Write("\t\t\tSide: ");
                            figureParameters.Add(Convert.ToDouble(Console.ReadLine()));
                            break;
                        }
                    case TwoDimensionalFigureOptions.Rectangle:
                        {
                            Console.Write("\t\t\tWidth: ");
                            figureParameters.Add(Convert.ToDouble(Console.ReadLine()));
                            Console.Write("\t\t\tHeight: ");
                            figureParameters.Add(Convert.ToDouble(Console.ReadLine()));
                            break;
                        }
                    case TwoDimensionalFigureOptions.Triangle:
                        {
                            Console.Write("\t\t\tWidth: ");
                            figureParameters.Add(Convert.ToDouble(Console.ReadLine()));
                            Console.Write("\t\t\tHeight: ");
                            figureParameters.Add(Convert.ToDouble(Console.ReadLine()));
                            break;
                        }
                    case TwoDimensionalFigureOptions.Circle:
                        {
                            Console.Write("\t\t\tRadius: ");
                            figureParameters.Add(Convert.ToDouble(Console.ReadLine()));
                            break;
                        }
                    case TwoDimensionalFigureOptions.Trapeze:
                        {
                            Console.Write("\t\t\tSmaller Base: ");
                            figureParameters.Add(Convert.ToDouble(Console.ReadLine()));
                            Console.Write("\t\t\tBigger Base: ");
                            figureParameters.Add(Convert.ToDouble(Console.ReadLine()));
                            Console.Write("\t\t\tHeight: ");
                            figureParameters.Add(Convert.ToDouble(Console.ReadLine()));
                            break;
                        }
                    case TwoDimensionalFigureOptions.Rhombus:
                        {
                            Console.Write("\t\t\tSmaller Diagonal: ");
                            figureParameters.Add(Convert.ToDouble(Console.ReadLine()));
                            Console.Write("\t\t\tBigger Diagonal: ");
                            figureParameters.Add(Convert.ToDouble(Console.ReadLine()));
                            break;
                        }
                    case ThreeDimensionalFigureOptions.Cube:
                        {
                            Console.Write("\t\t\tSide: ");
                            figureParameters.Add(Convert.ToDouble(Console.ReadLine()));
                            break;
                        }
                    case ThreeDimensionalFigureOptions.RectangularPrism:
                        {
                            Console.Write("\t\t\tWidth: ");
                            figureParameters.Add(Convert.ToDouble(Console.ReadLine()));
                            Console.Write("\t\t\tHeight: ");
                            figureParameters.Add(Convert.ToDouble(Console.ReadLine()));
                            Console.Write("\t\t\tLength: ");
                            figureParameters.Add(Convert.ToDouble(Console.ReadLine()));
                            break;
                        }
                    case ThreeDimensionalFigureOptions.RectangularPyramid:
                        {
                            Console.Write("\t\t\tWidth: ");
                            figureParameters.Add(Convert.ToDouble(Console.ReadLine()));
                            Console.Write("\t\t\tHeight: ");
                            figureParameters.Add(Convert.ToDouble(Console.ReadLine()));
                            Console.Write("\t\t\tLength: ");
                            figureParameters.Add(Convert.ToDouble(Console.ReadLine()));
                            break;
                        }
                    case ThreeDimensionalFigureOptions.Cylinder:
                        {
                            Console.Write("\t\t\tRadius: ");
                            figureParameters.Add(Convert.ToDouble(Console.ReadLine()));
                            Console.Write("\t\t\tHeight: ");
                            figureParameters.Add(Convert.ToDouble(Console.ReadLine()));
                            break;
                        }
                    case ThreeDimensionalFigureOptions.Sphere:
                        {
                            Console.Write("\t\t\tRadius: ");
                            figureParameters.Add(Convert.ToDouble(Console.ReadLine()));
                            break;
                        }
                    default: { break; }
                }

                return figureParameters;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool KeepRunning()
        {
            try
            {
                string? option;
                do
                {
                    Console.Clear();
                    Console.WriteLine("\n\tFigures\n");
                    Console.Write("\t\tDo you want to choose another Figure [Y/N]? ");
                    option = Console.ReadLine();
                } while (!option.ToUpper().Equals("Y") && !option.ToUpper().Equals("N"));

                if (option.ToUpper().Equals("Y"))
                    return true;
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void FinalSummary(List<string> names, List<double> areas, List<double> volumes)
        {
            Console.Clear();
            Console.WriteLine("\n\t                                           Final Summary                                         ");
            Console.WriteLine("\n\t   ----------------------------------------------------------------------------------------------");
            Console.WriteLine("\t   |            Figure            |             Area             |            Volume            |");
            Console.WriteLine("\t   ----------------------------------------------------------------------------------------------");

            for (int i = 0; i < names.Count; i++)
            {
                Console.Write("\t   |");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(AlignString(names[i]));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(AlignString(areas[i] == 0.0 ? "N/A" : areas[i].ToString("0.00")));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(AlignString(volumes[i] == 0.0 ? "N/A" : volumes[i].ToString("0.00")));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("|\n");
            }
            Console.WriteLine("\t   ----------------------------------------------------------------------------------------------");
            Console.WriteLine("\n\t                                             Thank you!                                          ");
        }


        private static string AlignString(string disalignedString)
        {
            var numberOfInitialSpaces = (Constants.SizeOfFinalSummaryCell - disalignedString.Length) / 2;
            var numberOfFinalSpaces = Constants.SizeOfFinalSummaryCell - disalignedString.Length - numberOfInitialSpaces;
            string initialSpaces = string.Empty;
            string finalSpaces = string.Empty;
            for (int i = 0; i < numberOfInitialSpaces; i++)
                initialSpaces += " ";
            finalSpaces = initialSpaces;
            if (numberOfInitialSpaces != numberOfFinalSpaces)
                initialSpaces += " ";

            string alignedString = initialSpaces + disalignedString + finalSpaces;
            return alignedString;
        }
    }
}