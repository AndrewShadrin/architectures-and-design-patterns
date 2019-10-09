using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Реализовать шаблон «Одиночка» для многопоточной программы с использованием класса Lazy<T>.
/// Выполнил Шадрин А.
/// </summary>
namespace Lesson_4_2
{
    public class Singlton
    {
        private static Lazy<Singlton> lazyInstance = new Lazy<Singlton>(()=>new Singlton());
        public static Singlton Instance => lazyInstance.Value;
        private Singlton()
        {
                
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
