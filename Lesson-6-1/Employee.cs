using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_1
{
    public class Employee : Worker
    {
        protected override void Write(int summ)
        {
            Console.WriteLine($"I can approve {summ} rubles. Employee");
        }

        public Employee(int sum) : base(sum)
        {

        }
    }
}
