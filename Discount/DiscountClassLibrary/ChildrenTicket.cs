using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountClassLibrary
{
    public class ChildrenTicket : MovieTicket
    {
        public ChildrenTicket()
        {
            this.Price = 100;
        }

        public override void Display()
        {
            Console.WriteLine("兒童票= {0}", this.Price);
            Console.WriteLine("{0}", this.discountName);
            Console.WriteLine("特價= {0}", this.price);
        }

        public override string Display2()
        {
            return "一張兒童票 原價 " + Price.ToString() + ",特價 " + price.ToString();
        }
    }
}