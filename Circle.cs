using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal class Circle : Figures
    {
        public void Info(float r)
        {
            this.r = r;
        }
        public void ShowResult()
        {
            Console.WriteLine($"Периметр круга {P_Cir(r)}");
            Console.WriteLine($"Площадь круга {S_Cir(r)}");
        }
    }
}
