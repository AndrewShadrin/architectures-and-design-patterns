using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Реализовать «заместителя» при работе с классом Math, ограничив его четырьмя функциями: +, -, *, / .
/// Выполнил Шадрин А.
/// </summary>
namespace Lesson_5_2
{
    public static class MyMath
    {
        public const double PI = 3.1415926535897931; 
        
        public static double Sin(double a)
        {
            return Math.Sin(a);
        }
        public static double Cos(double a)
        {
            return Math.Cos(a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyMath.Sin(MyMath.PI/2));
            Console.ReadKey();
        }
    }
}
