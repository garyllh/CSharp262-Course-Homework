using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountClassLibrary
{
    public class Vip01 : VipDiscount
    {
        public override string DiscountName()
        {
            return "持花旗卡可以半價，並可累積點數，另外累積點數夠多，還可以換贈品";
        }

        public override double Calculate(double price)
        {
            return price * 0.5;
        }
    }
}