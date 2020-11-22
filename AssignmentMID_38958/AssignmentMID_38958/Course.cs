using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentMID_38958
{
    class Course
    {
        private string courseName;
        private Section[] section;

        public Course(string courseName, int size)
        {
            this.courseName = courseName;
            this.section = new Section[size];
        }
        public void AddSection(Section sec)
        {
            for (int i = 0; i < section.Length; i++)
            {
                if (section[i] == null)
                {
                    section[i] = sec;
                    break;
                }
            }
        }
        public void CourseInfo()
        {
            Console.WriteLine("Course Name: " + this.courseName);
            for (int i = 0; i < section.Length; i++)
            {
                if (section[i] != null)
                {
                    section[i].ShowSectionInfo();
                    Console.WriteLine();
                }
            }
        }
    }
}
