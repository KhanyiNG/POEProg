using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace Semster2Prog
{
    class Student
    {
        private static SqlConnection conn = ConnectionData.GetConnection();


        public int studentNo { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string password { get; set; }
        public string gender { get; set; }
        public int UserType { get; set; }
        public Student()
        {
            studentNo = 0;
            fname = "none";
            lname = "none";
            password = "pass";
            gender = "none";
            UserType = 3;

        }

        public Student(int StudentNo,  string Fname,
            string Lname, string Password, string Gender)
        {
            studentNo = StudentNo;
            fname = Fname;
            lname = Lname;
            password = Password;
            gender = Gender;
            UserType = 3;
        }
        /// <summary>
        /// This method will add a new student into the database
        /// </summary>
        /// <param name="rowCount">The number of records to be returned when a new student has been added</param>
        /// <param name="errorMsg">Contains the error message should the operation fail</param>

        public void addStudent(ref int rowCount, ref string errorMsg)
        {

            try
            {
                SqlCommand insertLine = new SqlCommand($"INSERT INTO Studentlb (StudentNo, Fname, Lname, Password,Gender) VALUES('"+ studentNo + "', '"+ fname + "','"+ lname + "', '"+ password + "','"+ gender + "')", conn);

                conn.Open();
                rowCount = insertLine.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception e)
            {

                errorMsg = e.Message;
            }




        }
        public void getTheData(int StudentNo, ref string errorMsg)
        {
            SqlDataAdapter selectLine = new SqlDataAdapter($"SELECT * FROM Studentlb WHERE StudentNo = '"+ StudentNo + "'", conn);
            DataTable myTable = new DataTable();
            DataRow myRow;

            try
            {
                conn.Open();

                selectLine.Fill(myTable);


                if (myTable.Rows.Count > 0)
                {
                    myRow = myTable.Rows[0];
                    studentNo = (int)myRow[0];
                    fname = (string)myRow[1];
                    lname = (string)myRow[2];
                    password = (string)myRow[3];
                    gender = (string)myRow[4];
                    UserType = (int)myRow[5];
                }
                else
                {
                    studentNo = 0;
                    fname = "none";
                    lname = "none";
                    password = "pass";
                    gender = "none";
                    UserType = 3;

                }

                conn.Close();
            }
            catch (Exception e)
            {

                errorMsg = e.Message;
            }
        }
        public void loadGender(DropDownList list)
        {
            string[] arGender = { "Male", "Female" };

            foreach (string p in arGender)
            {
                list.Items.Add(p);
            }
        }
        public DataTable allStud()
        {
            SqlDataAdapter selectLine = new SqlDataAdapter($"SELECT * FROM Studentlb", conn);
            DataTable myTable = new DataTable();

            conn.Open();

            selectLine.Fill(myTable);

            conn.Close();

            return myTable;
        }



    }
}
 

