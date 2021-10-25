using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events_hw
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentList sl = new StudentList();
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            Student s4 = new Student();
            Student s5 = new Student();
            DiscountsManage dm = new DiscountsManage();

            sl.FivePrcDiscount += dm.GetFivePrcntDiscount;
            sl.AddStudent(s1);
            sl.AddStudent(s2);
            sl.AddStudent(s3);
            sl.AddStudent(s4);
            sl.AddStudent(s5);
        }
    }
}
