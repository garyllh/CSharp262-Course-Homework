using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountClassLibrary
{
    public class Children01 : ChildrenDiscount
    {
        public override string DiscountName()
        {
            return "小朋友如果年齡在10周歲及以下的兒童3折";
        }

        public override double Calculate(double price)
        {
            return price * 0.3;
        }
    }
}