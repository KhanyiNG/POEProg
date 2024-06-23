using Semster2Prog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace POEProg
{
    public partial class Register : System.Web.UI.Page
    {
    
        protected void Page_Load(object sender, EventArgs e)
        {
            Student stu = new Student();
          //  stu.loadGender(ddlGender);

        }

        //Login Button

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        //Register button
        protected void Button3_Click(object sender, EventArgs e)
        {
           
            int StudentNo;
            string fiName, liName, password;
         
            int rowCount = 0;
            string errorMsg = "";

            StudentNo = Convert.ToInt32(txtStudentNo.Text);
            fiName = txtFirstName.Text;
            liName = txtLastName.Text;
            password = txtPassword.Text;
         

            

            Student stu = new Student(StudentNo, fiName, liName, password);

            stu.addStudent(ref rowCount, ref errorMsg);

              Response.Write($"<script> alert('Successfully registered')</script>");
            Response.Redirect("ModuleDetails.aspx");



        }
    }
}