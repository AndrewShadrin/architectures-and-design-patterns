
namespace Lesson_3_1
{
    public class RectangleCreator : ICreator
    {
        Rectangle rectangle;

        public RectangleCreator(double a, double b)
        {
            rectangle = new Rectangle(a, b);
        }
        public IFigure Create()
        {
            return rectangle;
        }
    }
}
