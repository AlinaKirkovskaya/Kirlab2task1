using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirlab2task2
{
    internal class Figure
    {
        private List<Point> points = new List<Point>();
        public Figure(params Point[] figurePoints)
        {
            if (figurePoints.Length < 3 || figurePoints.Length > 5)
            {
                throw new ArgumentException("A figure must have 3 to 5 points.");
            }

            foreach (var point in figurePoints)
            {
                points.Add(point);
            }
        }

        public double GetSideLength(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        public double CalculatePerimeter()
        {
            double perimeter = 0;

            for (int i = 0; i < points.Count; i++)
            {
                int nextIndex = (i + 1) % points.Count;
                perimeter += GetSideLength(points[i], points[nextIndex]);
            }
            return perimeter;
        }
    }
}
