
namespace Lesson_2_1
{
    class OrderRepositoryExtended : OrderRepository
    {
        IOrderRepExtConnector ExtConnector;
        public OrderRepositoryExtended(IOrderRepExtConnector orderRepExtConnector=null)
        {
            if (orderRepExtConnector == null)
            {
                // throw new ArgumentNullException();
                // можно не выдавать исключение, а использовать возможности базового класса при отсутствии переданного интерфейса (см. пример в методе Save)
            }
            ExtConnector = orderRepExtConnector;
        }

        public new Order Load(int orderId)
        {
            if (ExtConnector == null)
            {
                return base.Load(orderId);
            }
            else
            {
                return ExtConnector.LoadExt(orderId);
            }
        }

        public new void Save(Order order)
        {
            if (ExtConnector == null)
            {
                base.Save(order);
            }
            else
            {
                ExtConnector.SaveExt(order);
            }
        }

        public new void Update(Order order)
        {
            if (ExtConnector == null)
            {
                base.Update(order);
            }
            else
            {
                ExtConnector.SaveExt(order);
            }
        }

        public new void Delete(Order order)
        {
            if (ExtConnector == null)
            {
                base.Delete(order);
            }
            else
            {
                ExtConnector.DeleteExt(order);
            }
        }
    }


}
