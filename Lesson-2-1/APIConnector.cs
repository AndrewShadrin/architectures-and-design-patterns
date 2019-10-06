using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_1
{
    class  APIConnector : IOrderRepExtConnector
    {
        public void DeleteExt(Order order)
        {
            // удаляем через API
        }

        public Order LoadExt(int orderId)
        {
            // читаем через API
            Order order = new Order();
            order.Name = "Ext order";
            return order;
        }

        public void SaveExt(Order order)
        {
            // записываем через API
        }

        public void UpdateExt(Order order)
        {
            // обновляем через API
        }
    }
}
