using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresList
{
    public class Figures
    {
    }

    public class Triangle: Figures
    {
        public double side_a { get; set; }
        public double side_b { get; set; }
        public double side_c { get; set; }
    }

    public class Circle: Figures
    {
        public double radius { get; set; }
    }
}
