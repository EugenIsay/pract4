using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal class Circle
    {
        private float r;
        private float result;
        public void Info(float r)
        {
            this.r = r;
        }
        private float P()
        {
            result = 2 * (float)Math.PI * r;
            return result;
        }
        private float S()
        {
            result = (float)Math.PI * (float)Math.Pow(r, 2);
            return result;
        }
        public void ShowResult()
        {
            Console.WriteLine($"Периметр круга {P()}");
            Console.WriteLine($"Площадь круга {S()}");
        }
    }
}
