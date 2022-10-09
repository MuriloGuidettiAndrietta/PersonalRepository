
using Figures.Figures;

Console.WriteLine("\n\tFigures\n");
Console.WriteLine("\t\t1 - Rectangle");
Console.WriteLine("\t\t2 - Circle");
Console.Write("\n\t\tChoose the Figure you want: ");
var option = Convert.ToByte(Console.ReadLine());
Figure figure;

if (option == 1)
{
    Console.Write("\n\t\tType the width: ");
    var width = Convert.ToDouble(Console.ReadLine());
    Console.Write("\t\tType the height: ");
    var height = Convert.ToDouble(Console.ReadLine());
    figure = new Rectangle(width, height);
}
else
{
    Console.Write("\n\t\tType the radius: ");
    var radius = Convert.ToDouble(Console.ReadLine());
    figure = new Circle(radius);
}

Console.WriteLine("\n\t\tThe Area is: " + figure.Area());
Console.Write("\t\t");
Console.ReadKey();





