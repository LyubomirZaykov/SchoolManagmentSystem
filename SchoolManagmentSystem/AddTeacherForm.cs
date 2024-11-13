using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SchoolManagmentSystem.LoginForm;
using System.IO;
using System.Globalization;

namespace SchoolManagmentSystem
{
    public partial class AddTeacherForm : UserControl
    {

        public AddTeacherForm()
        {
            InitializeComponent();
            TeacherDisplayData();
        }
        public void TeacherDisplayData()
        {
            AddTeachersData addTD = new AddTeachersData();
            teachersGridView.DataSource = addTD.TeacherData();
        }

        private void teacherAddBtn_Click(object sender, EventArgs e)
        {
            if (teacherName.Text=="" || teacherID.Text=="" || teacherGender.SelectedItem==null ||
                teacherAddress.Text=="" || teacherStatus.SelectedItem==null || 
                teacherImage.Image==null || imagePath==null)
            {
                MessageBox.Show("Please fill all blank fields!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State!=ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        //Check if teacher ID already exists
                        string checkTeacherId = "SELECT COUNT(*) FROM teachers WHERE teacher_id=@teacherID";
                        using (SqlCommand checkTID = new SqlCommand(checkTeacherId, connect))
                        {
                            checkTID.Parameters.AddWithValue("@teacherID", teacherID.Text.Trim());
                            int count = (int)checkTID.ExecuteScalar(); 

                            if (count>=1)
                            {
                                MessageBox.Show($"Teacher ID: {teacherID.Text.Trim()} already exists" , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
                                string insertData = "INSERT INTO teachers " +
                                                           "(teacher_id, teacher_name, teacher_gender, teacher_address, teacher_image, teacher_status, date_insert)" +
                                                           "VALUES(@teacherID, @teacherName, @teacherGender, @teacherAddress, @teacherImage, @teacherStatus, @dateInsert)";

                                //To save to your directory
                                string path = Path.Combine(@"C:\Users\lyubo\Desktop\engineering\programming\C#\School Managment System\SchoolManagmentSystem\SchoolManagmentSystem\Teacher_Directory\", teacherID.Text.Trim()+".jpg");
                                File.Copy(imagePath, path, true);
                                string directoryPath=Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                using(SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@teacherID", teacherID.Text);
                                    cmd.Parameters.AddWithValue("@teacherName", teacherName.Text);
                                    cmd.Parameters.AddWithValue("@teacherGender", teacherGender.Text);
                                    cmd.Parameters.AddWithValue("@teacherAddress", teacherAddress.Text);
                                    cmd.Parameters.AddWithValue("@teacherImage", teacherImage.Text);
                                    cmd.Parameters.AddWithValue("@teacherStatus", teacherStatus.Text);
                                    cmd.Parameters.AddWithValue("@dateInsert", today.ToString());
                                    cmd.ExecuteNonQuery();
                                }

                            }
                            
                        }

                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally 
                    {
                        connect.Close();
                    }

                }
            }
        }
        private String imagePath;
        private void teacherImportBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImageFile = new OpenFileDialog();
            openImageFile.Filter = "Image files (*.jpg; *.png )|*.jpg;*.png";
            if (openImageFile.ShowDialog()==DialogResult.OK)
            {
                imagePath = openImageFile.FileName;
                teacherImage.ImageLocation= imagePath;
            }

        }
    }
}
