using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events_hw
{
    class StudentList
    {
        public event EventHandler FivePrcDiscount;

        public List<Student> Students {  get; set; }
        
        public StudentList()
        {
            Students = new List<Student>();

        }

        public void AddStudent(Student s)
        {
            Students.Add(s);
            if (Students.Count % 5 == 0)
                OnFiveStudentJoined();
        }

        private void OnFiveStudentJoined()
        {
            FivePrcDiscount?.Invoke(this, new EventArgs());
        }
    }
}
