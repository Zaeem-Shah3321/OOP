using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using labtask1.BL;
using labtask1.UI;

namespace labtask1.DL
{
    class StudentsDL
    {
        public static List <StudentsBL> students = new List<StudentsBL>();
        public static void AddStudent()
        {
            StudentsDL.students.Add(StudentsUI.GetStudentData());
        }
    }
}
