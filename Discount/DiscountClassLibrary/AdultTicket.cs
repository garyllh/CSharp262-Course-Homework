using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountClassLibrary
{
    public class AdultTicket : MovieTicket
    {
        public AdultTicket()
        {
            this.Price = 250;
        }

        public override void Display()
        {
            //for Console
            Console.WriteLine("成人票= {0}", this.Price);
            Console.WriteLine("{0}", this.discountName);
            Console.WriteLine("特價= {0}", this.price);
        }

        public override string Display2()
        {
            // for form
            return "一張全票 原價 " + Price.ToString() + ",特價 " + price.ToString();
        }
    }
}