
namespace Lesson_3_1
{
    public class Rectangle : Figure
    {
        public double a { get; }
        public double b { get; }
        public override double Square => a * b;

        public override double Perimeter => (a + b) * 2;

        public override double Semiperimeter => a + b;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
    }
}
