using System;

namespace Lesson_3_1
{
    public class Circle : Figure
    {
        private double radius;
        public double Radius => radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Square => Math.PI * radius * radius;

        public override double Perimeter => Math.PI * 2 * radius;

        public override double Semiperimeter => Math.PI * radius;
    }
}
