using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirlab2task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of points for the figure (3-5): ");
            if (!int.TryParse(Console.ReadLine(), out int numPoints) || numPoints < 3 || numPoints > 5)
            {
                Console.WriteLine("Please enter a valid number of points (3-5).");
                return;
            }

            List<Point> figurePoints = new List<Point>();
            for (int i = 0; i < numPoints; i++)
            {
                Console.Write($"Enter X coordinate for point {i + 1}: ");
                if (!double.TryParse(Console.ReadLine(), out double x))
                {
                    Console.WriteLine("Please, input correct value in double/float format");
                    return;
                }

                Console.Write($"Enter Y coordinate for point {i + 1}: ");
                if (!double.TryParse(Console.ReadLine(), out double y))
                {
                    Console.WriteLine("Please, input correct value in double/float format");
                    return;
                }

                Console.Write($"Enter a name for point {i + 1}: ");
                string name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Point name cannot be empty.");
                    return;
                }

                figurePoints.Add(new Point(x, y, name));
            }

            Figure figure = new Figure(figurePoints.ToArray());
            double perimeter = figure.CalculatePerimeter();
            Console.WriteLine($"Perimeter of the {figurePoints.Count}-sided figure is {perimeter}");

        }
    }
    }

