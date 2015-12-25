using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScores
{
    public class Student : IStudent, IComparable<Student>
    {
        public string Name { get; set; }
        public int Chinese { get; set; }
        public int English { get; set; }
        public int Math { get; set; }
        public int Total { get; set; }

        public String Print()
        {
            return String.Format("{0}\t{1}\t{2}\t{3}\t{4}",
                this.Name, this.Chinese, this.English, this.Math,
                this.Chinese + this.English + this.Math
                );
        }

        public int CompareTo(Student other)
        {
            return other.Chinese - this.Chinese;
        }

        public class sortEnglish : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                Student s1 = (Student)x;
                Student s2 = (Student)y;
                return s2.English - s1.English;
            }
        }

        public class sortMath : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                Student s1 = (Student)x;
                Student s2 = (Student)y;
                return s2.Math - s1.Math;
            }
        }

        public class sortTotal : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                Student s1 = (Student)x;
                Student s2 = (Student)y;
                return (s2.Chinese + s2.English + s2.Math) - (s1.Chinese + s1.English + s1.Math);
            }
        }
    }
}