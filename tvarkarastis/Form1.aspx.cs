using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tvarkarastis.Classes;

namespace tvarkarastis
{

    public partial class Form1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          
            string classes = Server.MapPath("~/App_Data/Klases.txt");
            List<Students> students = InOutUtils.ReadClass(classes);

            string teachers = Server.MapPath("~/App_Data/Mokytojai.txt");
            List<Teacher> lectors = InOutUtils.ReadTeachers(teachers);

            TaskUtils.FillTheSchedule(2, lectors, students);


        }
    }
}