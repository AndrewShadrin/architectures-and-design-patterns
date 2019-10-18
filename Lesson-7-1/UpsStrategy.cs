
namespace Lesson_7_1
{
    public class UpsStrategy : IShippingStrategy
    {
        public double Calculate(Order order)
        {
            return 4;
        }
    }
}
