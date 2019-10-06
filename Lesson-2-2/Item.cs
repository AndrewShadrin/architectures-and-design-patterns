using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_2
{
    public abstract class Item : IItem
    {
        private double price;
        private double discount;
        private string promocode;

        public double Price => price;
        public double Discount => discount;
        public string Promocode => promocode;

        public void SetDiscount(double discount)
        {
            this.discount = discount;
        }
        public void SetPrice(double price)
        {
            this.price = price;
        }
        public void SetPromocode(string promocode)
        {
            this.promocode = promocode;
        }
    }
}
