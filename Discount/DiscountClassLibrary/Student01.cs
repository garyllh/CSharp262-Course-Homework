using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountClassLibrary
{
    public class Student01 : StudentDiscount
    {
        public override string DiscountName()
        {
            return "學生憑學生證可享受票價8折優惠";
        }

        public override double Calculate(double price)
        {
            return price * 0.8;
        }
    }
}