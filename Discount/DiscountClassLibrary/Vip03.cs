using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountClassLibrary
{
    public class Vip03 : VipDiscount
    {
        public override double Calculate(double price)
        {
            return price * 0.6;
        }

        public override string DiscountName()
        {
            return "持 B 卡可以六折";
        }
    }
}