
namespace Lesson_7_1
{
    public class FedexStrategy : IShippingStrategy
    {
        public double Calculate(Order order)
        {
            return 5;
        }
    }
}
