using System.Drawing;

namespace Lesson_5_1
{
    public interface IDrawFigure
    {
        void Draw(Graphics graphics, Pen pen, Rectangle rect);
    }
}
