using Semster2Prog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace POEProg
{
    public partial class ModuleDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int moduleCode, moduleCredit,numberOfWeeks,classHoursPerWeek;
            string ModuleName,startingDate;

            int rowCount = 0;
            string errorMsg = "";

            
            moduleCode = Convert.ToInt32(txtModuleCode.Text);
            ModuleName = txtModulename.Text;
            moduleCredit = Convert.ToInt32(txtModuleCredit.Text);
            startingDate = txtStartingDate.Text;
            numberOfWeeks = Convert.ToInt32(txtNumberOfWeeks.Text);
            classHoursPerWeek = Convert.ToInt32(txtclassHoursPerWeek.Text);

            StudModules stud = new StudModules(moduleCode, ModuleName, moduleCredit,startingDate, numberOfWeeks, classHoursPerWeek);

            stud.addUser(ref rowCount, ref errorMsg);


            Response.Write($"<script> alert('Added Successfully ')</script>");
            StudModules mod = new StudModules();

            DataTable dt = mod.allMod();
            dvgAllModules.DataSource = dt;
            dvgAllModules.DataBind();

        }
    }
}