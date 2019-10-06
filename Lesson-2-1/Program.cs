using System;

/// <summary>
/// Применить принцип открытости / закрытости. 
/// Класс OrderRepository изначально был реализован для работы с заказами, хранящимися в MySQL.
/// Но однажды нам потребовалось реализовать работу с данными о заказах, например, через API стороннего веб-сервиса.Какие изменения нам надо будет внести?
/// Выполнил Шадрин Андрей
/// Создан класс-потомок с внедрением зависимости через конструктор в виде интерфейса,
/// в котором можно реализовывать всю гамму возможностей работы с различными источниками данных
/// </summary>
namespace Lesson_2_1
{
    class Program
    {
        static APIConnector APIConnect = new APIConnector();
        static int orderId = 1;
        static void Main(string[] args)
        {
            OrderRepositoryExtended orderRepository = new OrderRepositoryExtended();
            Order order = orderRepository.Load(orderId);
            Console.WriteLine(order.Name);
            OrderRepositoryExtended orderRepositoryExtended = new OrderRepositoryExtended(APIConnect);
            Order orderExt = orderRepositoryExtended.Load(orderId);
            Console.WriteLine(orderExt.Name);
            Console.ReadLine();
        }
    }
}
