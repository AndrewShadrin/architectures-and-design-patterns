using System.Drawing;

namespace Lesson_5_1
{
    public class Ellips : IDrawFigure
    {
        public Ellips()
        {
        }

        public void Draw(Graphics graphics, Pen pen, Rectangle rect)
        {
            graphics.DrawEllipse(pen, rect);
        }
    }
}
