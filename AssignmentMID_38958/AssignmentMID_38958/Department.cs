using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentMID_38958
{
    class Department
    {
        private string deptName;
        private Course[] courses;

        public Department(string deptName, int size)
        {
            this.deptName = deptName;
            this.courses = new Course[size];
        }
        public string DeptName
        {
            set { this.deptName = value; }
            get { return this.deptName; }
        }
        public void AddCourse(Course courseM)
        {
            for (int i = 0; i < courses.Length; i++)
            {
                if (courses[i] == null)
                {
                    courses[i] = courseM;
                    break;
                }
            }
        }
        public void DeptInfo()
        {
            Console.WriteLine("Department: {0} has following courses:\n\n\n", this.deptName);
            for (int i = 0; i < courses.Length; i++)
            {
                if (courses[i] != null)
                {
                    courses[i].CourseInfo();
                    Console.WriteLine("\n\n");
                }
            }
        }
    }
}
