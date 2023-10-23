using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal class Rectangle : Figures
    {
        public void Info(float a, float b)
        {
            this.a = a; this.b = b;
        }
        public void ShowResult()
        {
            Console.WriteLine($"Периметр прямоугольника {P(a, b)}");
            Console.WriteLine($"Площадь прямоугольника {S(a, b)}");
        }
    }
}
