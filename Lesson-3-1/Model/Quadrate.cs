
namespace Lesson_3_1
{
    public class Quadrate : Figure
    {
        private double side;
        public double Side => side;

        public override double Square => side * side;

        public override double Perimeter => side * 4;

        public override double Semiperimeter => side * 2;

        public Quadrate(double side)
        {
            this.side = side;
        }
    }
}
