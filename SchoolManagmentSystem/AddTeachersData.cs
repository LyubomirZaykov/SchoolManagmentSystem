using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static SchoolManagmentSystem.LoginForm;
namespace SchoolManagmentSystem
{
    class AddTeachersData
    {
        public int ID { get; set; }
        public string TeacherID { get; set; }
        public string TeacherName { get; set; }
        public string TeacherGender { get; set; }
        public string TeacherAddress { get; set;}
        public string TeacherImage { get; set; }
        public string Status { get; set; }
        public string DateInsert { get; set; }
        public List<AddTeachersData> TeacherData()
        {
            List<AddTeachersData> listData = new List<AddTeachersData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string sqlCommand = "SELECT * FROM teachers WHERE date_delete IS NULL";
                    using (SqlCommand cmd = new SqlCommand(sqlCommand, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            AddTeachersData addTD = new AddTeachersData
                            {
                                ID = (int)reader["id"],
                                TeacherID = reader["teacher_id"].ToString(),
                                TeacherName = reader["teacher_name"].ToString(),
                                TeacherGender = reader["teacher_gender"].ToString(),
                                TeacherAddress = reader["teacher_address"].ToString(),
                                TeacherImage = reader["teacher_image"].ToString(),
                                Status = reader["teacher_status"].ToString(),
                                DateInsert = reader["date_insert"].ToString(),
                            };
                            listData.Add(addTD);
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
