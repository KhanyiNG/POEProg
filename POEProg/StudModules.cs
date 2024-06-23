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
    class StudModules
    {
        //Getting the connection from the GetConnection class
        private static SqlConnection conn = ConnectionData.GetConnection();
        // Setters and Getters
        public int ModuleCode { get; set; }
        public string ModuleName { get; set; }
        public int ModuleCredit { get; set; }
        public string StartingDate { get; set; }
        public int NumberOfWeeks { get; set; }
        public int ClassHoursPerWeek { get; set; }

        public StudModules()
        {

            ModuleCode = 0;
            ModuleName = "none";
            ModuleCredit = 0;
            StartingDate = "none";
            NumberOfWeeks = 0;
            ClassHoursPerWeek = 0;
        }

        public StudModules(int moduleCode, string moduleName, int moduleCredit, string startingDate, int numberOfWeeks, int classHoursPerWeek)
        {
            ModuleCode = moduleCode;
            ModuleName = moduleName;
            ModuleCredit = moduleCredit;
            StartingDate = startingDate;
            NumberOfWeeks = numberOfWeeks;
            ClassHoursPerWeek = classHoursPerWeek;
        }

        public void addUser(ref int rowCount, ref string errorMsg)
        {
            try
            {
                SqlCommand insertLine = new SqlCommand($"INSERT INTO Usertbl (moduleCode, moduleName, moduleCredit, startingDate, numberOfWeeks, classHoursPerWeek)VALUES ('" + ModuleCode + "','" + ModuleName + "','" + ModuleCredit + "','" + StartingDate + "','" + NumberOfWeeks + "','" + ClassHoursPerWeek + "')", conn);
                conn.Open();
                rowCount = insertLine.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {

                errorMsg = e.Message;
            }

        }
        /// <summary>
        /// This method will retrive Student details with the specific Employee No
        /// </summary>
        /// <param name="studentNo">Student No of an exisiting student</param>
        /// <param name="errorMsg">Contains the error message should the operation fail</param>
        /// 
        public void getTheData(int moduleCode, ref string errorMsg)
        {
            SqlDataAdapter LineSelection = new SqlDataAdapter($"SELECT * FROM Usertbl  WHERE moduleCode = {moduleCode}", conn);
            DataTable myTable = new DataTable();
            DataRow myRow;


            try
            {
                conn.Open();

                LineSelection.Fill(myTable);


                if (myTable.Rows.Count > 0)
                {
                    myRow = myTable.Rows[0];
                    ModuleCode = (int)myRow[0];
                    ModuleName = (string)myRow[1];
                    ModuleCredit = (int)myRow[2];
                    StartingDate = (string)myRow[3];
                    NumberOfWeeks = (int)myRow[4];
                    ClassHoursPerWeek = (int)myRow[5];

                }
                else
                {
                    ModuleCode = 0;
                    ModuleName = "none";
                    ModuleCredit = 0;
                    StartingDate = "none";
                    NumberOfWeeks = 0;
                    ClassHoursPerWeek = 0;

                }
                conn.Close();
            }
            catch (Exception e)
            {

                errorMsg = e.Message;
            }
        }
        /// <summary>
        ///  This will be the method that will update the Student (User) information
        /// </summary>




        public void Update(int moduleCode, ref int rowCount, ref string errorMsg)
        {
            SqlCommand updateCmd = new SqlCommand($"UPDATE Usertbl SET moduleName= '{ModuleName}', moduleCredit='{ModuleCredit}', startingDate ='{StartingDate}', numberOfWeeks = '{NumberOfWeeks}', classHoursPerWeek= {ClassHoursPerWeek}WHERE moduleCode = {moduleCode}", conn);

            try
            {
                conn.Open();
                rowCount = updateCmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception e)
            {

                errorMsg = e.Message;
            }
        }
        //The method will delete a user

        public void delete(int moduleCode, ref int rowCount, ref string errorMsg)
        {
            SqlCommand deleteCmd = new SqlCommand($"DELETE FROM Usertbl WHERE moduleCode = {moduleCode}", conn);


            try
            {
                conn.Open();
                rowCount = deleteCmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {

                errorMsg = e.Message;
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
        ///
        /// 
        /// Return details of all the Students from the database

        public List<StudModules> allStudentMod()
        {
            SqlDataAdapter selectLine = new SqlDataAdapter($"SELECT * FROM Usertbl", conn);
            DataTable myTable = new DataTable();
            DataRow myRow;
            List<StudModules> stuList = new List<StudModules>();

            conn.Open();

            selectLine.Fill(myTable);


            if (myTable.Rows.Count > 0)
            {
                for (int i = 0; i < myTable.Rows.Count; i++)
                {
                    myRow = myTable.Rows[i];


                    ModuleCode = (int)myRow[0];
                    ModuleName = (string)myRow[1];
                    ModuleCredit = (int)myRow[2];
                    StartingDate = (string)myRow[3];
                    NumberOfWeeks = (int)myRow[4];
                    ClassHoursPerWeek = (int)myRow[5];


                    stuList.Add(new StudModules(ModuleCode, ModuleName, ModuleCredit, StartingDate, NumberOfWeeks, ClassHoursPerWeek));
                }
            }
            else
            {
                ModuleCode = 0;
                ModuleName = "none";
                ModuleCredit = 0;
                StartingDate = "none";
                NumberOfWeeks = 0;
                ClassHoursPerWeek -= 0;

            }
            conn.Close();

            return stuList;

        }
    
        public DataTable stuHours()
        {
            SqlDataAdapter selectLine = new SqlDataAdapter($"SELECT moduleCode, moduleName, classHoursPerWeek FROM Usertbl WHERE numberOfWeeks between 10 AND 30", conn);
            DataTable myTable = new DataTable();

            conn.Open();

            selectLine.Fill(myTable);

            conn.Close();

            return myTable;
        }

        public DataTable allMod()
        {
            SqlDataAdapter selectLine = new SqlDataAdapter($"SELECT * FROM Usertbl", conn);
            DataTable myTable = new DataTable();

            conn.Open();

            selectLine.Fill(myTable);

            conn.Close();

            return myTable;
        }

    }
}