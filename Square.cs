using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal class Square
    {
        private float result;
        private float a;
        public void Info(float a)
        {
            this.a = a;
        }
        public float P()
        {
            result = 4 * a;
            return result;
        }
        public float S()
        {
            result = a * a;
            return result;
        }
    }
}


