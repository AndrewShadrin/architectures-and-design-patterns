using System.Drawing;

namespace Lesson_2_2
{
    public class Clothes : Item, IColor, ISize
    {
        private Color color;
        public Color Color => color;
        private Size size;
        public Size Size => size;

        public void SetColor(Color color)
        {
            this.color = color;
        }
        public void SetSize(Size size)
        {
            this.size = size;
        }
    }
}
