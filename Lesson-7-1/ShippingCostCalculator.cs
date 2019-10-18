using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_1
{
    public class ShippingCostCalculator
    {
        public double Calculate(Order order)
        {
            if (order.ShippingMethod == null)
            {
                return -1;
            }
            return order.ShippingMethod.Calculate(order);
        }
    }
}
