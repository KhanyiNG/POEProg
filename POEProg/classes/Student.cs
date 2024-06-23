using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Semster2Prog
{
    class Student
    {
        private static SqlConnection conn = ConnectionData.GetConnection();


        public int StudentNo { get; set; }
        public string Username { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }

        public Student()
        {
            StudentNo = 0;
            Username = "none";
            Fname = "none";
            Lname = "none";
            Password = "pass";
            Gender = "none";
           

        }

        public Student(int studentNo, string username, string firstName,
            string lastName, string password, string gender)
        {
            StudentNo = studentNo;
            Username = username;
            Fname = firstName;
            Lname = lastName;
            Password = password;
            Gender = gender;
            
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
                SqlCommand insertLine = new SqlCommand($"INSERT INTO StudentTbl(studentNo, username,Fname, Lname, password,gender) VALUES({StudentNo}, '{Username}', '{Fname}',  '{Lname}', '{Password}','{Gender}')", conn);


                conn.Open();
                rowCount = insertLine.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception e)
            {

                errorMsg = e.Message;
            }




        }
        public void getTheData(int empNo, ref string errorMsg)
        {
            SqlDataAdapter selectLine = new SqlDataAdapter($"SELECT * FROM StudentTbl WHERE Id = {StudentNo}", conn);
            DataTable myTable = new DataTable();
            DataRow myRow;

            try
            {
                conn.Open();

                selectLine.Fill(myTable);


                if (myTable.Rows.Count > 0)
                {
                    myRow = myTable.Rows[0];
                    StudentNo = (int)myRow[0];
                    Username = (string)myRow[1];
                    Fname = (string)myRow[2];
                    Lname = (string)myRow[3];
                    Password = (string)myRow[4];
                    Gender = (string)myRow[5];

                }
                else
                {
                    StudentNo = 0;
                    Username = "none";
                    Fname = "none";
                    Fname = "none";
                    Password = "pass";


                    Gender = "none";


                }

                conn.Close();
            }
            catch (Exception e)
            {

                errorMsg = e.Message;
            }
        }
    }
        }
 

