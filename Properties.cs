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
    internal class Circle
    {
        private float r;
        private float result;
        public void Info(float r)
        {
            this.r = r;
        }
        public float P()
        {
            result = 2 * (float)Math.PI * r;
            return result;
        }
        public float S()
        {
            result = (float)Math.PI * (float)Math.Pow(r, 2);
            return result;
        }
    }
    internal class Triangle
    {
        private float a;
        private float b;
        private float c;
        private float result;
        public void Info(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public bool proverka()
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public float P()
        {
            result = (a + b + c)/2;
            return result;
        }
        public float S()
        {
            result = (float)Math.Sqrt(P() * (P() - a) * (P() - b) * (P() - c));
            return result;
        }
    }
}
