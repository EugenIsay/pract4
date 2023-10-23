using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal class Circle : Figure
    {
        protected float P(float r)
        {
            result = r * 2 * (float)Math.PI;
            return result;
        }
        protected float S(float r)
        {
            result = (float)Math.Pow(r, 2) * (float)Math.PI;
            return result;
        }
        public void ShowResult()
        {
            Console.WriteLine($"Периметр круга {P(a)}");
            Console.WriteLine($"Площадь круга {S(a)}");
        }
    }
}
