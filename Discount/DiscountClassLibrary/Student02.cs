using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountClassLibrary
{
    public class Student02 : StudentDiscount
    {
        public override double Calculate(double price)
        {
            return price * 0.75;
        }

        public override string DiscountName()
        {
            return "學生憑學生證女生可享受票價7.5折優惠";
        }
    }
}