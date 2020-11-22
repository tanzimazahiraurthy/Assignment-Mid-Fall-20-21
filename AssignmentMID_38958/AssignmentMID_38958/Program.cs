using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentMID_38958
{
    class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department("Computer Science", 10);

            Course course1 = new Course("Object Oriented Programming 1", 2);
            Course course2 = new Course("Object Oriented Programming 2", 5);
            Course course3 = new Course("Theory Of Computation", 2);

            Faculty faculty1 = new Faculty("Abrar Hossain");
            Faculty faculty2 = new Faculty("Ayesha Sultana");
            Faculty faculty3 = new Faculty("Tanzima Zahir");

            Section section1 = new Section('A',5, faculty1);
            Section section2 = new Section('B',5, faculty2);
            Section section3 = new Section('A',5, faculty1);
            Section section4 = new Section('B', 5, faculty3);
            Section section5 = new Section('C', 5, faculty1);
            Section section6 = new Section('D', 5, faculty1);
            Section section7 = new Section('E', 5, faculty3);
            Section section8 = new Section('A', 3, faculty1);
            Section section9 = new Section('B', 3, faculty2);

            course1.AddSection(section1);
            course1.AddSection(section2);
            course2.AddSection(section3);
            course2.AddSection(section4);
            course2.AddSection(section5);
            course2.AddSection(section6);
            course2.AddSection(section7);
            course3.AddSection(section8);
            course3.AddSection(section9);

            department.AddCourse(course1);
            department.AddCourse(course2);
            department.AddCourse(course3);

            department.DeptInfo();
        }
    }
}
