using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Security.Policy;
using System.Web;
using System.Net.NetworkInformation;
using System.Text;
using System.Xml;

namespace tvarkarastis.Classes
{
    public class InOutUtils
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static List<Students> ReadClass(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);

            string[] separators = { " " };
            string[] class_data = lines[0].Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int classes_count = Convert.ToInt32(class_data[0]);
            int subject_count = Convert.ToInt32(class_data[1]);
            int readPos = 1;

            List<Students> temp = new List<Students>();


            for (int i = 0; i < classes_count; i++)
            {
                string classNumber = lines[readPos];
                readPos++;

                string weekDay = "";
                for (int j = readPos; j < readPos + 5; j++)
                {
                    List<string> subjects = new List<string>();
                    string[] Values = lines[j].Split(' ');
                    weekDay = Values[0];
                    for (int k = 1; k < subject_count; k++)
                    {
                        subjects.Add(Values[k]);
                    }
                    Students studClass = new Students(classNumber, weekDay, subjects);
                    temp.Add(studClass);
                }
                readPos += 5;
            }

            return temp;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>

        public static List<Teacher> ReadTeachers(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);

            string[] separators = { " " };
            string[] class_data = lines[0].Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int teachers_count = Convert.ToInt32(class_data[0]);
            int availability_count = Convert.ToInt32(class_data[1]);
            int readPos = 1;

            List<Teacher> temp = new List<Teacher>();
            for (int i = 0; i < teachers_count; i++)
            {

                string weekDay = "";
                for (int j = readPos; j < readPos + 5; j++)
                {
                    List<string> availability = new List<string>();

                    string[] Values = lines[j].Split(' ');
                    weekDay = Values[0];
                    for (int k = 1; k < availability_count; k++)
                    {
                        availability.Add(Values[k]);
                    }
                    Teacher teach = new Teacher(weekDay, availability);
                    temp.Add(teach);
                }
                readPos += 5;
            }
            return temp;
        }
    }
}

//Teahcers[0]= mokytojas1
//Teahcers[1] = mokytojas2
//Teahcers[5] 
