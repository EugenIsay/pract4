using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal class Pyramid : Circle
    {
        private float num;
        private bool cone;
        public void Info(float r, float h)
        {
            this.r = r;
            this.h = h;
            l(r);
            cone = true;
        }
        public void Info(float a, float num, float h)
        {
            this.num = num;
            this.a = a;
            this.h = h;
            cone = false;
        }
        private float A()
        {
            result = a / (2 * (float)Math.Tan(Math.PI / num));
            return result;
        }
        private float l(float r)
        {
            result = (float)Math.Sqrt((float)Math.Pow(r, 2) + (float)Math.Pow(h, 2));
            return result;
        }
        private float P()
        {
            if (cone == false)
                result = num * (l(A())+ a);
            else
                result = P(r);
            return result;
        }
        private float S_Base()
        {
            if (cone == false)
                result = (num * a * A()) / 2;
            else if (cone == true)
                result = S(r);
            return result;
        }
        private float S()
        {
            if (cone == false)
                result = S_Base() + ((num * a * l(A())) / 2);
            else if (cone == true)
                result = S_Base() + (float)Math.PI * r * l(r);
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
