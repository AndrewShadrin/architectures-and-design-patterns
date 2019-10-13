using System.Drawing;

namespace Lesson_5_1
{
    public class Rectan : IDrawFigure
    {
        public Rectan()
        {
        }

        public void Draw(Graphics graphics, Pen pen, Rectangle rect)
        {
            graphics.DrawRectangle(pen, rect);
        }
    }
}
