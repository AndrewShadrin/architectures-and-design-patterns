
namespace Lesson_7_1
{
    /// <summary>
    /// Расчет стоимости доставки EMS
    /// </summary>
    public class EmsStrategy : IShippingStrategy
    {
        /// <summary>
        /// Производит расчет стоимости доставки по данным заказа
        /// </summary>
        /// <param name="order">Заказ для расчета</param>
        /// <returns>Сумма затрат на доставку по данным заказа</returns>
        public double Calculate(Order order)
        {
            return 3;
        }
    }
}
