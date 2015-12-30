using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountClassLibrary
{
    public abstract class MovieTicket
    {
        public IDiscount discountable;

        public double Price { get; set; }
        public double price;
        public string discountName;

        public abstract void Display();

        public abstract String Display2();

        public void SetDiscount(IDiscount discount)
        {
            this.price = discount.Calculate(this.Price);
            this.discountName = discount.DiscountName();
        }

        /*
        public double SetDiscount(IDiscount)
        {
            return discountable.Calculate(price);
        }

        public string GetDiscountName()
        {
            return discountable.DiscountName();
        }
        */
    }
}