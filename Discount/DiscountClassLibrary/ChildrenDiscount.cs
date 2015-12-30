using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountClassLibrary
{
    public abstract class ChildrenDiscount : IDiscount
    {
        public abstract string DiscountName();

        public abstract double Calculate(double price);
    }
}