using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountClassLibrary
{
    public class Vip02 : VipDiscount
    {
        public override double Calculate(double price)
        {
            return price * 0.8;
        }

        public override string DiscountName()
        {
            return "持 A 卡可以八折";
        }
    }
}