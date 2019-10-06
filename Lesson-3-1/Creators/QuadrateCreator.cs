
namespace Lesson_3_1
{
    public class QuadrateCreator : ICreator
    {
        Quadrate quadrate;

        public QuadrateCreator(double side)
        {
            quadrate = new Quadrate(side);
        }
        public IFigure Create()
        {
            return quadrate;
        }
    }
}
