using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_1
{
    public class RandomRect
    {
        private Random random;
        private int maxValue;
        
        public RandomRect(int value)
        {
            SetMaxValue(value);
        }

        public Rectangle GetRect 
        {
            get
            {
                return new Rectangle(random.Next(maxValue), random.Next(maxValue), random.Next(maxValue), random.Next(maxValue));
            } 
        }

        public void SetMaxValue(int value)
        {
            maxValue = value;
            random = new Random(maxValue);
        }
    }
}
