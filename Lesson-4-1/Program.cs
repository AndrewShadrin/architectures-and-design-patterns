using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Реализовать шаблон «Одиночка» для многопоточной программы с использованием оператора lock.
/// Выполнил Шадрин А.
/// </summary>
namespace Lesson_4_1
{
    public class Singlton
    {
        private static Singlton instance;
        private static object sync = new Object();

        static Singlton()
        {
        }

        public static Singlton Instance
        {
            get
            {
                lock (sync)
                {
                    if (instance == null)
                    {
                        instance = new Singlton();
                    }
                }
                return instance;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Singlton instanceOne = Singlton.Instance;
            Singlton instanceTwo = Singlton.Instance;
            Console.WriteLine(instanceOne == instanceTwo);
            Console.ReadKey();
        }
    }
}
