using System;

/// <summary>
/// Применить шаблон «Фабрика» для создания объектов, описывающих геометрические фигуры (круг, квадрат, прямоугольник).
/// Выполнил Шадрин А.
/// </summary>
namespace Lesson_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreator[] creators= { new TriangleCreator(3, 4, 5), new QuadrateCreator(4), new RectangleCreator(5, 6), new CircleCreator(8) };

            foreach (ICreator creator in creators)
            {
                IFigure fig = creator.Create();
                Console.WriteLine($"Фигура: {fig.GetType().Name}, площадь - {fig.Square:n4}, периметр - {fig.Perimeter:n4} ");
            }
            Console.ReadKey();
        }
    }
}
