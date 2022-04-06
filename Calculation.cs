using System;
using FiguresList;

namespace Calculation
{
    public class Calculator
    {
        public double CircleCalc(Circle circl)
        {
            return 3.1415926535897931 * Math.Pow(circl.radius, 2);
        }

        public double TriangleCalc(Triangle triangl)
        {
            double halfPerimeter = (triangl.side_a + triangl.side_b + triangl.side_c) / 2;
            return Math.Sqrt(halfPerimeter
                        * (halfPerimeter - triangl.side_a)
                        * (halfPerimeter - triangl.side_b)
                        * (halfPerimeter - triangl.side_c));
        }

        public bool TriangleCheck(Triangle triangl)
        {
            return Math.Pow(triangl.side_a, 2) 
                + Math.Pow(triangl.side_b, 2) == Math.Pow(triangl.side_c, 2);
        }

    }
}
