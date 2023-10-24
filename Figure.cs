using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal class Figure
    {
        protected float r;
        protected float a;
        protected float b;
        protected float c;
        protected float h;
        protected float result;
        public virtual void Info(float a)
        {
            this.a = a;
        }
        protected virtual float P(float a, float b)
        {
            result = 2 * (a + b);
            return result;
        }
        protected virtual float S(float a, float b)
        {
            result = a * b;
            return result;
        }
    }
}
