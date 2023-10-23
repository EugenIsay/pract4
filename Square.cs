using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal class Square : Figures
    {
        public void Info(float a)
        {
            this.a = a;
        }
        public void ShowResult()
        {
            Console.WriteLine($"Периметр квадрата {P(a, a)}");
            Console.WriteLine($"Площадь квадрата {S(a, a)}");
        }
    }
}


