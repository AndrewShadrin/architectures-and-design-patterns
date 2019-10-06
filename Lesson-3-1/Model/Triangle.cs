using System;

namespace Lesson_3_1
{
    public class Triangle : Figure
    {
        public double a { get; }
        public double b { get; }
        public double c { get; }

        public override double Square => Math.Sqrt(Semiperimeter * (Semiperimeter - a) * (Semiperimeter - b) * (Semiperimeter - c));

        public override double Perimeter => a+b+c;
        public override double Semiperimeter => (a+b+c)/2;

        public Triangle(double a, double b, double c)
        {
            if (a == 0 || b == 0 || c == 0)
            {
                throw new ArgumentOutOfRangeException("Длина сторон не может быть равна нулю");
            }
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }
}
