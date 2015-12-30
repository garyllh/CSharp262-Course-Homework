using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountClassLibrary
{
    public class Student00 : StudentDiscount
    {
        public override string DiscountName()
        {
            return "無折扣";
        }

        public override double Calculate(double price)
        {
            return price;
        }
    }
}