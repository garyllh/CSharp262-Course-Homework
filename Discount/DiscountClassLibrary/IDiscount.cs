using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountClassLibrary
{
    public interface IDiscount
    {
        string DiscountName();

        double Calculate(double price);
    }
}