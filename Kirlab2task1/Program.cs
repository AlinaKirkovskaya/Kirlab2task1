using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirlab2task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = " Lab2task1";
            double side1, side2;
            Console.Write("Enter the length of the first side of the rectangle: ");
            if (!double.TryParse(Console.ReadLine(), out side1))
            {
                Console.WriteLine("Please, input correct value in double/float format");
                return;
            }

            Console.Write("Enter the length of the second side of the rectangle: ");
            if (!double.TryParse(Console.ReadLine(), out side2))
            {
                Console.WriteLine("Please, input correct value in double/float format");
                return;
            }

            Rectangle rect = new Rectangle(side1, side2);

            Console.WriteLine($"Area of ​​the rectangle: {rect.CalculateArea()}");
            Console.WriteLine($"Perimeter of a rectangle: {rect.CalculatePerimeter()}");

            Console.ReadKey();
        }
    }
}
