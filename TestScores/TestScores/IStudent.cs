using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScores
{
    internal interface IStudent
    {
        string Name { get; set; }
        int Chinese { get; set; }
        int English { get; set; }
        int Math { get; set; }

        string Print();
    }
}