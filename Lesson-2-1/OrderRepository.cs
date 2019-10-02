
namespace Lesson_2_1
{
    class OrderRepository
    {
        public Order Load(int orderId)
        {
            Order order = new Order();
            order.Name = "Old order";
            return order;
        }
        public void Save(Order order) { }
        public void Update(Order order) { }
        public void Delete(Order order) { }
    }
}
