using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountClassLibrary
{
    public class StudentTicket : MovieTicket
    {
        public StudentTicket()
        {
            this.Price = 200;
        }

        public override void Display()
        {
            Console.WriteLine("學生票= {0}", this.Price);
            Console.WriteLine("{0}", this.discountName);
            Console.WriteLine("特價= {0}", this.price);
        }

        public override string Display2()
        {
            return "一張學生票 原價 " + Price.ToString() + ",特價 " + price.ToString();
        }
    }
}