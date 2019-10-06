
namespace Lesson_3_1
{
    public class CircleCreator : ICreator
    {
        Circle circle;

        public CircleCreator(double radius)
        {
            circle = new Circle(radius);
        }
        public IFigure Create()
        {
            return circle;
        }
    }
}
