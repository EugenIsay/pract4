using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal class Rectangle
    {
        private float result;
        private float a;
        private float b;
        public void Info(float a, float b)
        {
            this.a = a; this.b = b;
        }
        public float P()
        {
            result = 2 * a + 2 * b;
            return result;
        }
        public float S()
        {
            result = a * b;
            return result;
        }
    }
}
