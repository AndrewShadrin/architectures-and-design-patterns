
namespace Lesson_2_1
{
    interface IOrderRepExtConnector
    {
        Order LoadExt(int orderId);
        void SaveExt(Order order);
        void UpdateExt(Order order);
        void DeleteExt(Order order);
    }
}
