using System;
using FiguresList;

namespace Calculation
{
    public class Calculator
    {
        public double Calc(Figures obj)
        {
            double reslt = 0;
            if (obj is Circle)
            {
                reslt = CircleCalc(obj as Circle);
            }
            else if (obj is Triangle)
            {
                reslt = TriangleCalc(obj as Triangle);
            }
            else if (obj == null)
            {
                throw new Exception("Тип фигуры не известен");
            }

            return reslt;

            //Для новых версий языка
            //if (obj == null) throw new Exception("Фигура не может быть null");
            //return obj switch
            //{
            //    Circle circle => CircleCalc(obj),
            //    Triangle triangle => TriangleCalc(obj),
            //    _ => throw new Exception("Тип фигуры не известен")
            //};

        }

        public double CircleCalc(Circle circl)
        {
            return Math.PI * Math.Pow(circl.Radius, 2);
        }

        public double TriangleCalc(Triangle triangl)
        {
            double halfPerimeter = (triangl.SideA + triangl.SideB + triangl.SideC) / 2;
            return Math.Sqrt(halfPerimeter
                        * (halfPerimeter - triangl.SideA)
                        * (halfPerimeter - triangl.SideB)
                        * (halfPerimeter - triangl.SideC));
        }

        public bool TriangleCheck(Triangle triangl)
        {
            return Math.Pow(triangl.SideA, 2) 
                + Math.Pow(triangl.SideB, 2) == Math.Pow(triangl.SideC, 2);
        }

    }
}
