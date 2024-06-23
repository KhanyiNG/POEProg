using Semster2Prog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace POEProg
{
    public partial class Statistics : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudModules stud = new StudModules();
            DataTable dt = stud.stuHours();

            Chart1.DataSource = dt;
            Chart1.DataBind();

            loadStudents();

        }
        void loadStudents()
        {
            StudModules stud = new StudModules();
            DataTable dt = stud.allStud();
            DataRow dr;


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dr = dt.Rows[i];

                ddlStudents.Items.Add(dr[2].ToString());
            }
        }

        protected void Chart1_Load(object sender, EventArgs e)
        {

        }
    }
}