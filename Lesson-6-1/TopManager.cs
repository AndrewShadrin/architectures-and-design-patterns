﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_1
{
    public class TopManager : Worker
    {
        protected override void Write(int summ)
        {
            Console.WriteLine($"I can approve {summ} rubles. TopManager.");
        }
        public TopManager(int sum) : base(sum)
        {

        }
    }
}
