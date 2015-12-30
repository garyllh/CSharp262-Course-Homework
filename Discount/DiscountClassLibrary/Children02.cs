using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountClassLibrary
{
    public class Children02 : ChildrenDiscount
    {
        public override double Calculate(double price)
        {
            return price * 0.7;
        }

        public override string DiscountName()
        {
            return "小學生與屁孩7折優惠";
        }
    }
}