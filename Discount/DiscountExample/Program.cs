using DiscountClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DiscountExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MovieTicket child = new ChildrenTicket();
            MovieTicket student = new StudentTicket();
            MovieTicket adult = new AdultTicket();

            child.SetDiscount(new Children01());
            child.Display();
            child.SetDiscount(new Children02());
            child.Display();

            student.SetDiscount(new Student01());
            student.Display();
            student.SetDiscount(new Student02());
            student.Display();

            adult.SetDiscount(new Vip01());
            adult.Display();
            adult.SetDiscount(new Vip02());
            adult.Display();
            adult.SetDiscount(new Vip03());
            adult.Display();

            /*
            ticket.discountable = new Children01();
            ticket.Display();
            ticket.discountable = new Student01();
            ticket.Display();
            */
        }
    }
}