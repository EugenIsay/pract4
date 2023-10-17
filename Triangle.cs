using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Figures
{
    internal class Triangle
    {
        private float a;
        private float b;
        private float c;
        private float result;
        private string temp0;
        private string temp1;
        public void Info(float a, float b, float c)
        {
            if (a > b)
            {
                this.b = b;
                if (a > c) { this.c = a; this.a = c; } else { this.c = c; this.a = a; }
            }
            else
            {
                this.a = a;
                if (b > c) { this.c = b; this.b = c; } else { this.c = c; this.b = b; }
            }
        }
        private bool proverka()
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
        private float P()
        {
            result = (a + b + c) / 2;
            return result;
        }
        private float S()
        {
            result = (float)Math.Sqrt(P() * (P() - a) * (P() - b) * (P() - c));
            return result;
        }
        private (string temp0, string temp1) type()
        {
            if (Math.Pow(c, 2) == Math.Pow(b, 2) + Math.Pow(a, 2))
            {
                temp0 = "прямоугольный";
            }
            else if (Math.Pow(c, 2) > Math.Pow(b, 2) + Math.Pow(a, 2))
            {
                temp0 = "тупоугольный";
            }
            else if (Math.Pow(c, 2) < Math.Pow(b, 2) + Math.Pow(a, 2))
            {
                temp0 = "остроугольный";
            }
            if (a == b && a == c)
            {
                temp1 = "равносторонний";
            }
            else if (a == b || b == c || c == a)
            {
                temp1 = "равнобедренный";
            }
            else
            {
                temp1 = "разносторонний";
            }
            return (temp0, temp1);
        }
        public void ShowResults()
        {
            if (proverka() == true)
            {
                Console.WriteLine($"Периметр треугольника {P() * 2}");
                Console.WriteLine($"Площадь треугольника {S()}");
                Console.WriteLine($"Тип триуольника:{type()}");
            }
            else
            {
                Console.WriteLine($"Такой треугольник не существует");
            }
        }
    }
}
