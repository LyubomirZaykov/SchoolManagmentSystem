using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SchoolManagmentSystem.LoginForm;

namespace SchoolManagmentSystem
{
    public partial class AddStudentForm : UserControl
    {
        public AddStudentForm()
        {
            InitializeComponent();
            DisplayStudentsData(); 
        }
        public void DisplayStudentsData()
        {
            AddStudentData addSD=new AddStudentData();
            studentsGridView.DataSource = addSD.StudentData();
        }
        private String imagePath;
        public void ClearFields()
        {
            studentID.Text = string.Empty;
            studentName.Text = string.Empty;
            studentGender.SelectedIndex = -1;
            studentAddress.Text = string.Empty;
            studentStatus.SelectedIndex = -1;
            studentGrade.SelectedIndex = -1;
            studentSection.SelectedIndex = -1;
            studentImage.ImageLocation = null;
        }
        private void studentAddBtn_Click(object sender, EventArgs e)
        {
            if (studentName.Text == "" || studentID.Text == "" || studentGender.Text == "" ||
                studentAddress.Text == "" || studentGrade.Text == "" ||
                studentImage.Image == null || imagePath == null)
            {
                MessageBox.Show("Please fill all blank fields!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        //Check if teacher ID already exists
                        string checkStudentId = "SELECT COUNT(*) FROM students WHERE student_id=@studentID";
                        using (SqlCommand checkSID = new SqlCommand(checkStudentId, connect))
                        {
                            checkSID.Parameters.AddWithValue("@studentID", studentID.Text.Trim());
                            int count = (int)checkSID.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show($"Student ID: {studentID.Text.Trim()} already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                DateTime today = DateTime.Now;
                                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
                                string insertData = "INSERT INTO students " +
                                                           "(student_id, student_name, student_gender, student_address, student_grade, student_section, student_image, student_status, date_insert)" +
                                                           "VALUES(@studentID, @studentName, @studentGender, @studentAddress, @studentGrade, @studentSection, @studentImage, @studentStatus, @dateInsert)";

                                //To save to your directory
                                string path = Path.Combine(@"C:\Users\lyubo\Desktop\engineering\programming\C#\School Managment System\SchoolManagmentSystem\SchoolManagmentSystem\Student_Directory\", studentID.Text.Trim() + ".jpg");
                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }
                                File.Copy(imagePath, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@studentID", studentID.Text);
                                    cmd.Parameters.AddWithValue("@studentName", studentName.Text);
                                    cmd.Parameters.AddWithValue("@studentGender", studentGender.Text);
                                    cmd.Parameters.AddWithValue("@studentAddress", studentAddress.Text);
                                    cmd.Parameters.AddWithValue("@studentGrade", studentGrade.Text);
                                    cmd.Parameters.AddWithValue("@studentSection", studentSection.Text);
                                    cmd.Parameters.AddWithValue("@studentImage", path);
                                    cmd.Parameters.AddWithValue("@studentStatus", studentStatus.Text);
                                    cmd.Parameters.AddWithValue("@dateInsert", today.ToString());

                                    cmd.ExecuteNonQuery();
                                    connect.Close();
                                    DisplayStudentsData();
                                    MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ClearFields();
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

        private void studentImportBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImageFile = new OpenFileDialog();
            openImageFile.Filter = "Image files (*.jpg; *.png )|*.jpg;*.png";
            if (openImageFile.ShowDialog() == DialogResult.OK)
            {
                imagePath = openImageFile.FileName;
                studentImage.ImageLocation = imagePath;
            }
        }

        private void studentClearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
