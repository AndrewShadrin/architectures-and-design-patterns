using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Реализовать шаблон «Стратегия» без использования делегатов. При решении задачи следует использовать следующий интерфейс:
/// public interface IShippingStrategy
/// {
///     double Calculate(Order order);
/// }
/// Выполнил Шадрин А.
/// </summary>
namespace Lesson_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IShippingStrategy emsStrategy = new EmsStrategy();
            IShippingStrategy upsStrategy = new UpsStrategy();
            IShippingStrategy fedexStrategy = new FedexStrategy();
            ShippingCostCalculator costCalculator = new ShippingCostCalculator();

            Order order1 = new Order();
            order1.ShippingMethod = emsStrategy;
            Order order2 = new Order();
            order2.ShippingMethod = upsStrategy;
            Order order3 = new Order();
            order3.ShippingMethod = fedexStrategy;

            Console.WriteLine($"Затраты на транспортировку по заказу составили {costCalculator.Calculate(order1)}");
            Console.WriteLine($"Затраты на транспортировку по заказу составили {costCalculator.Calculate(order2)}");
            Console.WriteLine($"Затраты на транспортировку по заказу составили {costCalculator.Calculate(order3)}");

            Console.ReadKey();
        }
    }
}
