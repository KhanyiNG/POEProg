using Semster2Prog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace POEProg
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       
       
        //Login buttont
        protected void Button1_Click1(object sender, EventArgs e)
        {
            Student stu = new Student();
            int Username = Convert.ToInt32(txtUsername.Text);
            string Password = txtPassword.Text;
            string errorMsg = string.Empty;
                                                              
            stu.getTheData(Username, ref errorMsg);

            if (string.IsNullOrEmpty(errorMsg))
            {

                if (Username == stu.studentNo && Password.Equals(stu.password))
                {
                    Session["theUser"] = $"{stu.fname} {stu.lname}";
                    Response.Redirect("ModuleDetails.aspx");
                }
                else
                {
                    Response.Write($"<script> alert('Invalid Username and Password')</script>");
                }

                }
                else
                {
                Response.Write($"<script> alert({errorMsg})</script>");
                }


        }
        //Register button

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}