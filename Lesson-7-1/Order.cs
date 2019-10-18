using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_1
{
    public class Order
    {
        public IShippingStrategy ShippingMethod { get; set; }
        public Address Destination { get; set; }
        public Address Origin { get; set; }
    }
}
