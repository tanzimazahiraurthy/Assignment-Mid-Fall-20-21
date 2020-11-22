using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentMID_38958
{
    class Section
    {
        private char sec;
        private int weeklyLoad;
        private Faculty faculty;

        public Section(char sec, int weeklyLoad, Faculty faculty)
        {
            this.sec = sec;
            this.weeklyLoad = weeklyLoad;
            this.faculty = faculty;
            faculty.addLoad(weeklyLoad);
        }
        public char Sec
        {
            set { this.sec = value; }
            get { return this.sec; }
        }
        public void assignFaculty(Faculty faculty)
        {

        }
        public void ShowSectionInfo()
        {
            Console.WriteLine("Section: {0}", this.sec);
            faculty.Info();
        }
    }
}
