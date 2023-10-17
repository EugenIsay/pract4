using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal class Pyramid
    {
        private float num;
        private float a;
        private float h;
        private float r;
        private float result;
        public void InfoCir(float r, float h)
        {
            this.r = r;
            this.h = h;
        }
        public void Info(float a, float num, float h)
        {
            this.num = num;
            this.a = a;
            this.h = h;
        }
        private float A()
        {
            result = a / (2 * (float)Math.Tan(Math.PI / num));
            return result;
        }
        private float P()
        {
            result = num * (float)Math.Sqrt((float)Math.Pow(A(), 2) + (float)Math.Pow(h, 2)) + num * a;
            return result;
        }
        private float S_Base()
        {
            result = (num * A() * a) / 2;
            return result;
        }
        private float S()
        {
            result = S_Base() + (num * a * ((float)Math.Sqrt((float)Math.Pow(h, 2) + (float)Math.Pow(A(), 2)))) / 2;
            return result;
        }
        private float V()
        {
            result = (S_Base() * h) / 3;
            return result;
        }
        public void ShowResults()
        {
            Console.WriteLine($"Периметр пирамиды {P()}");
            Console.WriteLine($"Площадь пирамиды {S()}");
            Console.WriteLine($"Объём пирамиды {V()}");
        }
    }
}
