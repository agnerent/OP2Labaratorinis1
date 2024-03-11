using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Web;

namespace tvarkarastis.Classes
{
    public class Teacher
    {
        public string WeekDay { get; set; }
        private List<string> Availability;
       // private int[] Check;
        public Teacher(string weekDay, List<string> availability)
        {
            this.WeekDay = weekDay;
            Availability = availability;
         //   this.Check = check;
        }
       
        public List<string> GetAvailability()
        {
            return Availability;
        }

        public void SetAvailability(string availability,int index)
        {
            this.Availability[index] = availability;
        }
        /*   public int[] GetCheck()
           {
               return Check;
           }*/


    }
}