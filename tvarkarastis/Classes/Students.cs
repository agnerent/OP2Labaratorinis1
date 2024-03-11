using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tvarkarastis
{
    public class Students
    {
        public string ClassName { get; set; }
        public string WeekDay { get; set; }

        private List<string> Subjects;
        public Students(string className, string weekDay, List<string> subjects)
        {
            ClassName = className;
            WeekDay = weekDay;
            Subjects = subjects;
        }

        public List<string> GetSubjects()
        {
            return Subjects;
        }

        public override string ToString()
        {
            string line;
            line = String.Format("| | | |", ClassName, WeekDay, Subjects);
            return line;
        }

        public void SetSubjects(string subjects, int index)
        {
            this.Subjects[index] = subjects;
        }

    }
}