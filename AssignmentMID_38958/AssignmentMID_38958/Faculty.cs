using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentMID_38958
{
    class Faculty
    {
        private string name;
        private int weeklyLoad;

        public Faculty(string name)
        {
            this.name = name;
            this.weeklyLoad = 0;
        }
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public void addLoad(int creditHour)
        {
            if((weeklyLoad+creditHour)<=21)
            {
                this.weeklyLoad = this.weeklyLoad + creditHour;
            }
        }
        public void Info()
        {
            Console.WriteLine("Faculty Info:\nName: {0}\nWeekly Load:{1}", this.name, this.weeklyLoad);
        }
    }
}
