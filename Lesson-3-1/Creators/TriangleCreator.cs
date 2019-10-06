
namespace Lesson_3_1
{
    public class TriangleCreator : ICreator
    {
        Triangle triangle;

        public TriangleCreator(double a, double b, double c)
        {
            triangle = new Triangle(a, b, c);
        }
        public IFigure Create()
        {
            return triangle;
        }
    }
}
