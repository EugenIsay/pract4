﻿using System;
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
        protected float h;
        protected float result;
        public void Info(float a)
        {
            this.a = a;
        }
        protected float P(float a, float b)
        {
            result = 2 * (a + b);
            return result;
        }
        protected float S(float a, float b)
        {
            result = a * b;
            return result;
        }
        protected float P_Cir(float r)
        {
            result = r * 2 * (float)Math.PI;
            return result;
        }
        protected float S_Cir(float r)
        {
            result = (float)Math.Pow(r, 2) * (float)Math.PI;
            return result;
        }
    }
}