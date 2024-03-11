using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace tvarkarastis.Classes
{
    public class TaskUtils
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="k"></param>
        /// <param name="teachers"></param>
        /// <param name="students"></param>
        public static int FillTheSchedule(int k, List<Teacher> teachers, List<Students> students)
        {
            if (k < 1)
                return -1;
            else
            {  
                for (int n = 0; n < 2; n++) //through out the all teachers
                {
                    for (int i = 0; i < 5; i++) // through out the days
                    {
                        for (int j = 0; j < 7; j++) // through out the lessons
                        {
                            if (teachers[n].WeekDay == students[n].WeekDay && teachers[n].GetAvailability()[j] == "0" && students[n].GetSubjects()[j] == "-" )
                            {
                                teachers[n].SetAvailability("1", j);
                                // teachers[i + 5].GetAvailability()[j] = "x";
                                students[n].SetSubjects("kuno kutlura", j);
                               // students[i + 5].GetSubjects()[j] = "kuno kutlura";
                                // teachers[i].Check[j] = 1;
                                // teachers[i + 5].Check[j] = 1;
                                FillTheSchedule(k - 1, teachers, students);
                                i = 6; //break
                                j = 8; // end findings;
                            }
                        }
                    }
                }
            }
            return k;
        }

    }
}