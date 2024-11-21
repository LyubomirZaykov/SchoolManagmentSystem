using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using static SchoolManagmentSystem.LoginForm;

namespace SchoolManagmentSystem
{
    class AddStudentData
    {
        public int ID { get; set; }
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentGender { get; set; }
        public string StudentAddress { get; set; }
        public string StudentGrade { get; set; }
        public string StudentSection { get; set; }
        public string StudentImage { get; set; }
        public string Status { get; set; }
        public string DateInsert { get; set; }
        public List<AddStudentData> StudentData()
        {
            List<AddStudentData> listData = new List<AddStudentData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string sqlCommand = "SELECT * FROM students WHERE date_delete IS NULL";
                    using (SqlCommand cmd = new SqlCommand(sqlCommand, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            AddStudentData addSD = new AddStudentData
                            {
                                ID = (int)reader["id"],
                                StudentID = reader["student_id"].ToString(),
                                StudentName = reader["student_name"].ToString(),
                                StudentGender = reader["student_gender"].ToString(),
                                StudentAddress = reader["student_address"].ToString(),
                                StudentGrade = reader["student_grade"].ToString(),
                                StudentSection = reader["student_section"].ToString(),
                                StudentImage = reader["student_image"].ToString(),
                                Status = reader["student_status"].ToString(),
                                DateInsert = reader["date_insert"].ToString(),
                            };
                            listData.Add(addSD);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error connecting Database: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }

            return listData;
        }
    }
}
